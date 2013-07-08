using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdaptivePaymentsSampleApp.UseCaseSamples
{
    public partial class EmbeddedPayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string currentPath = HttpContext.Current.Request.Url.OriginalString;
            this.returnURL.Value = currentPath;
            this.cancelURL.Value = currentPath;
        }
    }
}