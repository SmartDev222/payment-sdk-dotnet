using System;
using System.Web;

namespace AdaptivePaymentsSampleApp.UseCaseSamples
{
    public partial class PreapprovalPayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string currentPath = HttpContext.Current.Request.Url.OriginalString;
            this.returnURL.Value = currentPath;
            this.cancelURL.Value = currentPath;
            this.startingDate.Value = DateTime.Now.ToString("yyyy-MM-dd");
            this.endingDate.Value = DateTime.Now.AddDays(60).ToString("yyyy-MM-dd");
        }
    }
}