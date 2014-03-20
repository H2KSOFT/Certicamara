using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using System.Security;
using System.Security.Cryptography;

namespace WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    public class Service1 : IService1
    {
        /// <summary>
        /// Metodo que se encarga de registrar una llave publica.
        /// </summary>
        /// <param name="pub">Variable de tipo Registrar.</param>
        /// <returns>Devuelve un objeto de tipo Respuesta con el resutado del proceso.</returns>
        public Respuesta GetRegistrarLlavePublica(Registrar pub)
        {
            try
            {
                RSACryptoServiceProvider rsa;
                const string CONTAINER_NAME = "CRSA";
                CspParameters cspParams;
                cspParams = new CspParameters(1);
                cspParams.Flags = CspProviderFlags.UseDefaultKeyContainer;
                cspParams.KeyContainerName = CONTAINER_NAME;
                rsa = new RSACryptoServiceProvider(cspParams);
                //Se genera el nombre o codigo de la llave publica.
                String pCodigoLlave = DateTime.Now.ToString("ddMMyyyhhmmssffff");
                //Generar y almacenar la llave pública.
                StreamWriter writer = new StreamWriter(@"C:\CreacionLlavesPublicas\" + pCodigoLlave + ".xml");
                string publicOnlyKeyXML = rsa.ToXmlString(false);
                writer.Write(publicOnlyKeyXML);
                writer.Close();
                //
                writer = new StreamWriter(@"C:\CreacionLlavesPublicas\" + pCodigoLlave + "_pp.xml");
                string publicPrivateKeyXML = rsa.ToXmlString(true);
                writer.Write(publicPrivateKeyXML);
                writer.Close();
                //
                Respuesta rp = new Respuesta();
                rp.id = pCodigoLlave;
                //Se devuelve el codigo 201.
                WebOperationContext ctx = WebOperationContext.Current;
                ctx.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.Created;
                return rp;
            }
            catch
            {
                WebOperationContext ctx = WebOperationContext.Current;
                ctx.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.BadRequest;
                return null;
            }
        }
        /// <summary>
        /// Metodo que se encarga de cifrar el texto a partir del id de la llave.
        /// </summary>
        /// <param name="pub">Variable de tipo Cifrar que contiene los datos necesarios para el proceso.</param>
        /// <returns>Devuelve un objeto de tipo Cifrado con el resultado del proceso.</returns>
        public Cifrado GetCifrarTexto(Cifrar pub)
        {
            Cifrado ci = new Cifrado();
            RSACryptoServiceProvider rsa;
            const string CONTAINER_NAME = "CRSA";
            CspParameters cspParams;
            cspParams = new CspParameters(1);
            cspParams.Flags = CspProviderFlags.UseDefaultKeyContainer;
            cspParams.KeyContainerName = CONTAINER_NAME;
            rsa = new RSACryptoServiceProvider(cspParams);
            StreamReader reader = new StreamReader(@"C:\CreacionLlavesPublicas\" + pub.id + ".xml");
            string publicOnlyKeyXML = reader.ReadToEnd();
            rsa.FromXmlString(publicOnlyKeyXML);
            reader.Close();
            byte[] textoPlanoBytes = System.Text.Encoding.UTF8.GetBytes(pub.texto);
            byte[] textoCifradoBytes = rsa.Encrypt(textoPlanoBytes, false);
            string MensajeCifrado = Convert.ToBase64String(textoCifradoBytes);
            ci.textoCifrado = MensajeCifrado;
            WebOperationContext ctx = WebOperationContext.Current;
            ctx.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.OK;
            return ci;
        }
        /// <summary>
        /// Metodo que se encarga de validar un texto encriptado a partir de una llave.
        /// </summary>
        /// <param name="val">Variable de tipo Validar que contiene los datos necesarios para el proceso.</param>
        /// <returns>Devuelve un objeto de tipo HttpStatusCode con el resultado del proceso.</returns>
        public System.Net.HttpStatusCode GetValidarTexto(Validar val)
        {
            try
            {
                RSACryptoServiceProvider rsa;
                const string CONTAINER_NAME = "CRSA";
                CspParameters cspParams;
                cspParams = new CspParameters(1);
                cspParams.Flags = CspProviderFlags.UseDefaultKeyContainer;
                cspParams.KeyContainerName = CONTAINER_NAME;
                rsa = new RSACryptoServiceProvider(cspParams);
                StreamReader reader = new StreamReader(@"C:\CreacionLlavesPublicas\" + val.id + "_pp.xml");
                string publicOnlyKeyXML = reader.ReadToEnd();
                rsa.FromXmlString(publicOnlyKeyXML);
                reader.Close();
                byte[] textoCifradoBytes = Convert.FromBase64String(val.cryptedText);
                byte[] textoPlanoBytes = rsa.Decrypt(textoCifradoBytes, false);
                string MensajeDescifrado = System.Text.Encoding.UTF8.GetString(textoPlanoBytes);
                if (MensajeDescifrado.Equals(val.clearText))
                {
                    WebOperationContext ctx = WebOperationContext.Current;
                    ctx.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.OK;
                    return System.Net.HttpStatusCode.OK;
                }
                else
                {
                    WebOperationContext ctx = WebOperationContext.Current;
                    ctx.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.BadRequest;
                    return System.Net.HttpStatusCode.BadRequest;
                }
            }
            catch
            {
                WebOperationContext ctx = WebOperationContext.Current;
                ctx.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.BadRequest;
                return System.Net.HttpStatusCode.BadRequest;
            }
        }
    }
}
