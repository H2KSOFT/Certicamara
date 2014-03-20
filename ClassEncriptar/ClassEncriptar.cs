using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Security;

namespace ClassEncriptar
{
    public class ClassEncriptar
    {
        /// <summary>
        /// Método que se encarga de firmar una cadena de texto a partir de la ruta de la llave enviada.
        /// </summary>
        /// <param name="pRutaLlavePrivada">Variable que contiene la ruta de la llave privada a consutar.</param>
        /// <param name="pTexto">Variable que contiene el texto a firmar.</param>
        /// <returns>Variable que contiene el resultado de la firma</returns>
        public String EncriptarTexto(String pRutaLlavePrivada,String pTexto)
        {
            String pResultado = "";
            try
            {
                RSACryptoServiceProvider rsa;
                const string CONTAINER_NAME = "CRSA";
                CspParameters cspParams;
                cspParams = new CspParameters(1);
                cspParams.Flags = CspProviderFlags.UseDefaultKeyContainer;
                cspParams.KeyContainerName = CONTAINER_NAME;
                rsa = new RSACryptoServiceProvider(cspParams);
                //Se carga la llave enviada.
                StreamReader reader = new StreamReader(@""+ pRutaLlavePrivada +"");
                string publicOnlyKeyXML = reader.ReadToEnd();
                rsa.FromXmlString(publicOnlyKeyXML);
                reader.Close();
                byte[] textoPlanoBytes = System.Text.Encoding.UTF8.GetBytes(pTexto);
                byte[] textoCifradoBytes = rsa.Encrypt(textoPlanoBytes, false);
                string MensajeCifrado = Convert.ToBase64String(textoCifradoBytes);
                pResultado = MensajeCifrado;
            }
            catch
            {
                throw new Exception("Error al firmar el texto.");
            }
            return pResultado;
        }

        
    }
}
