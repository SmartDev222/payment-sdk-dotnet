using System;
using System.Web;

namespace AdaptivePaymentsSampleApp.UseCaseSamples
{
    public partial class DeferredPayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string currentPath = HttpContext.Current.Request.Url.OriginalString;
            this.returnURL.Value = currentPath;
            this.cancelURL.Value = currentPath;
        }
    }
}