using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/register", Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Respuesta GetRegistrarLlavePublica(Registrar pub);

        [OperationContract]
        [WebInvoke(UriTemplate = "/validate", Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        System.Net.HttpStatusCode GetValidarTexto(Validar val);

        [OperationContract]
        [WebInvoke(UriTemplate = "/cifrar", Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Cifrado GetCifrarTexto(Cifrar pub);
    }

    [DataContract]
    public class Registrar
    {
        [DataMember]
        public String pub { get; set; }
    }

    [DataContract]
    public class Respuesta
    {
        [DataMember]
        public String id { get; set; }
    }

    [DataContract]
    public class Cifrar
    {
        [DataMember]
        public String id { get; set; }

        [DataMember]
        public String texto { get; set; }
    }

    [DataContract]
    public class Cifrado
    {
        [DataMember]
        public String textoCifrado { get; set; }
    }

    [DataContract]
    public class Validar
    {
        [DataMember]
        public String id { get; set; }

        [DataMember]
        public String clearText { get; set; }

        [DataMember]
        public String cryptedText { get; set; }
    }
}
