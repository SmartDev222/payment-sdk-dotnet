using System;
using System.Web;

namespace AdaptivePaymentsSampleApp.UseCaseSamples
{
    public partial class PreapprovalPayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Context.Request.QueryString["cancelURL"] != null)
            {
                returnURL.Text = Request.QueryString["cancelURL"];
            }

            if (Context.Request.QueryString["returnURL"] != null)
            {
                returnURL.Text = Request.QueryString["returnURL"];
            }

            if (Context.Request.QueryString["preapprovalkey"] != null)
            {
                returnURL.Text = Request.QueryString["preapprovalkey"];
            }
        }
    }
}