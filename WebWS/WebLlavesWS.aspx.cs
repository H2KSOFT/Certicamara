using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebWS
{
    public partial class WebLlavesWS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlavesWS.Service1 WS = new LlavesWS.Service1();
            LlavesWS.Registrar clr = new LlavesWS.Registrar();
            LlavesWS.Respuesta clp = new LlavesWS.Respuesta();
            clr.pub = "prueba";
            clp = WS.GetRegistrarLlavePublica(clr);
            lblMensaje.Text = "ok";
        }
    }
}