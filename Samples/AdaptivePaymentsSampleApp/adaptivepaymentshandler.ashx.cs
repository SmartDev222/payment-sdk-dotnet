using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Collections.Generic;
using PayPal;
using PayPal.Exception;
using PayPal.Util;
using PayPal.AdaptivePayments;
using System.Configuration;
using PayPal.AdaptivePayments.Model;

namespace AdaptivePaymentsSampleApp
{
    /// <summary>
    /// Summary description for $codebehindclassname$
    /// </summary>
    
    public class adaptivepaymentshandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
             String strCall = context.Request.Params["AdaptivePaymentsBtn"];

             if(strCall.Equals("Pay")){
                 Pay(context);
             }
             else if (strCall.Equals("Preapproval"))
             {
                 Preapproval(context);
             }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
        private void Pay(HttpContext context)
        {
            PayRequest req = new PayRequest();
            req.requestEnvelope = new RequestEnvelope();
            req.requestEnvelope.errorLanguage = "en_US";
            req.receiverList = new ReceiverList();
            req.receiverList.receiver = new List<Receiver>();
            Receiver rec = new Receiver();
            rec.amount=System.Convert.ToDecimal(context.Request.Params["amount"]);
            rec.email=context.Request.Params["mail"];
            req.receiverList.receiver.Add(rec);
            req.actionType=context.Request.Params["actionType"];
            req.cancelUrl=context.Request.Params["cancelUrl"];
            req.returnUrl=context.Request.Params["returnUrl"];
            req.currencyCode=context.Request.Params["currencyCode"];
            try
            {
                AdaptivePaymentsService service = new AdaptivePaymentsService();
                PayResponse resp = service.Pay(req);
                context.Response.Write("<html><body><textarea rows=30 cols=80>");
                ObjectDumper.Write(resp, 5, context.Response.Output);
                context.Response.Write("</textarea></body></html>");

                string red = "<br>";
                red = red + "<a href=";
                red = red + ConfigurationManager.AppSettings["PAYPAL_REDIRECT_URL"] + "_ap-payment&paykey="
								+ resp.payKey;
                red = red + ">Redirect URL (Click to redirect)</a><br>";
                context.Response.Write(red);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
            }
        }
        private void Preapproval(HttpContext context)
        {
            PreapprovalRequest req = new PreapprovalRequest();
            req.requestEnvelope = new RequestEnvelope();
            req.requestEnvelope.errorLanguage = "en_US";
            req.cancelUrl = context.Request.Params["cancelUrl"];
            req.returnUrl = context.Request.Params["returnUrl"];
            req.currencyCode = context.Request.Params["currencyCode"];
            req.startingDate=context.Request.Params["startDate"];
            try
            {
                AdaptivePaymentsService service = new AdaptivePaymentsService();
                PreapprovalResponse resp = service.Preapproval(req);
                context.Response.Write("<html><body><textarea rows=30 cols=80>");
                ObjectDumper.Write(resp, 5, context.Response.Output);
                context.Response.Write("</textarea></body></html>");

                string red = "<br>";
                red = red + "<a href=";
                red = red + ConfigurationManager.AppSettings["PAYPAL_REDIRECT_URL"] + "_ap-preapproval&preapprovalkey="
                                + resp.preapprovalKey;
                red = red + ">Redirect URL (Click to redirect)</a><br>";
                context.Response.Write(red);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
            }
        }
    }
}
