using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Collections.Generic;
using System.Collections.Specialized;
using PayPal;
using PayPal.Exception;
using PayPal.Util;
using PayPal.AdaptivePayments;
using System.Configuration;
using PayPal.AdaptivePayments.Model;

namespace AdaptivePaymentsSampleApp
{
    /// <summary>
    /// Summary description for codebehindclassname
    /// </summary>

    public class adaptivepaymentshandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            String strCall = context.Request.Params["AdaptivePaymentsBtn"];

            if (strCall.Equals("Pay"))
            {
                Pay(context);
            }
            else if (strCall.Equals("PaymentDetails"))
            {
                PaymentDetails(context);
            }
            else if (strCall.Equals("Preapproval"))
            {
                Preapproval(context);
            }
            else if (strCall.Equals("PreapprovalDetails"))
            {
                PreapprovalDetails(context);
            }
            else if (strCall.Equals("CancelPreapproval"))
            {
                CancelPreapproval(context);
            }
            else if (strCall.Equals("ConfirmPreapproval"))
            {
                ConfirmPreapproval(context);
            }
            else if (strCall.Equals("Refund"))
            {
                Refund(context);
            }
            else if (strCall.Equals("ConvertCurrency"))
            {
                ConvertCurrency(context);
            }
            else if (strCall.Equals("GetAllowedFundingSources"))
            {
                GetAllowedFundingSources(context);
            }
            else if (strCall.Equals("GetFundingPlans"))
            {
                GetFundingPlans(context);
            }
            else if (strCall.Equals("GetShippingAddresses"))
            {
                GetShippingAddresses(context);
            }
            else if (strCall.Equals("GetAvailableShippingAddresses"))
            {
                GetAvailableShippingAddresses(context);
            }
            else if (strCall.Equals("SetPaymentOptions"))
            {
                SetPaymentOptions(context);
            }
            else if (strCall.Equals("GetPaymentOptions"))
            {
                GetPaymentOptions(context);
            }
            else if (strCall.Equals("ExecutePayment"))
            {
                ExecutePayment(context);
            }
            else if (strCall.Equals("GetUserLimits"))
            {
                GetUserLimits(context);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Handle Pay API calls
        /// </summary>
        /// <param name="context"></param>
        private void Pay(HttpContext context)
        {
            NameValueCollection parameters = context.Request.Params;
            ReceiverList receiverList = new ReceiverList();
            receiverList.receiver = new List<Receiver>();
            string[] amt = context.Request.Form.GetValues("receiverAmount");
            string[] receiverEmail = context.Request.Form.GetValues("receiverEmail");
            string[] phoneCountry = context.Request.Form.GetValues("phoneCountry");
            string[] phoneNumber = context.Request.Form.GetValues("phoneNumber");
            string[] phoneExtn = context.Request.Form.GetValues("phoneExtn");
            string[] primaryReceiver = context.Request.Form.GetValues("primaryReceiver");
            string[] invoiceId = context.Request.Form.GetValues("invoiceId");
            string[] paymentType = context.Request.Form.GetValues("paymentType");
            string[] paymentSubType = context.Request.Form.GetValues("paymentSubType");
            for (int i = 0; i < amt.Length; i++)
            {
                Receiver rec = new Receiver(Decimal.Parse(amt[i]));
                if(receiverEmail[i] != "")
                    rec.email = receiverEmail[i];
                if (phoneCountry[i] != "" && phoneNumber[i] != "")
                {
                    rec.phone = new PhoneNumberType(phoneCountry[i], phoneNumber[i]);
                    if (phoneExtn[i] != "")
                    {
                        rec.phone.extension = phoneExtn[i];
                    }
                }
                if (primaryReceiver[i] != "")
                    rec.primary = Boolean.Parse(primaryReceiver[i]);
                if (invoiceId[i] != "")
                    rec.invoiceId = invoiceId[i];
                if (paymentType[i] != "")
                    rec.paymentType = paymentType[i];
                if (paymentSubType[i] != "")
                    rec.paymentSubType = paymentSubType[i];
                receiverList.receiver.Add(rec);
            }            
            PayRequest req = new PayRequest(new RequestEnvelope("en_US"), parameters["actionType"], 
                                parameters["cancelUrl"], parameters["currencyCode"], 
                                receiverList, parameters["returnUrl"]);
            // set optional parameters
            if (parameters["reverseAllParallelPaymentsOnError"] != "")
                req.reverseAllParallelPaymentsOnError = 
                    Boolean.Parse(parameters["reverseAllParallelPaymentsOnError"]);
            if (parameters["senderEmail"] != "")
                req.senderEmail = parameters["senderEmail"];
            if (parameters["trackingId"] != "")
                req.trackingId = parameters["trackingId"];
            if (parameters["fundingConstraint"] != "")
            {
                req.fundingConstraint = new FundingConstraint();
                req.fundingConstraint.allowedFundingType = new FundingTypeList();
                req.fundingConstraint.allowedFundingType.fundingTypeInfo.Add(
                    new FundingTypeInfo(parameters["fundingConstraint"]));
            }
            if (parameters["emailIdentifier"] != ""
                || (parameters["senderPhoneCountry"] != "" && parameters["senderPhoneNumber"] != "")
                || parameters["useCredentials"] != "")
            {
                req.sender = new SenderIdentifier();
                if (parameters["emailIdentifier"] != "")
                    req.sender.email = parameters["emailIdentifier"];
                if (parameters["senderPhoneCountry"] != "" && parameters["senderPhoneNumber"] != "")
                {
                    req.sender.phone = new PhoneNumberType(parameters["senderPhoneCountry"], parameters["senderPhoneNumber"]);
                    if (parameters["senderPhoneExtn"] != "")
                        req.sender.phone.extension = parameters["senderPhoneExtn"];
                }
                if (parameters["useCredentials"] != "")
                    req.sender.useCredentials = Boolean.Parse(parameters["useCredentials"]);
            }

            // All set. Fire the request            
            AdaptivePaymentsService service = new AdaptivePaymentsService();
            PayResponse resp = null;
            try
            {
                resp = service.Pay(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if ( !(resp.responseEnvelope.ack == AckCode.FAILURE) && 
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING) )
            {
                redirectUrl = ConfigurationManager.AppSettings["PAYPAL_REDIRECT_URL"]
                                     + "_ap-payment&paykey=" + resp.payKey;
                keyResponseParams.Add("Pay key", resp.payKey);
                keyResponseParams.Add("Payment execution status", resp.paymentExecStatus);
                if (resp.defaultFundingPlan != null && resp.defaultFundingPlan.senderFees != null)
                {
                    keyResponseParams.Add("Sender fees", resp.defaultFundingPlan.senderFees.amount +
                                                resp.defaultFundingPlan.senderFees.code);
                }
            }
            displayResponse(context, "Pay", keyResponseParams, service.getLastRequest(), service.getLastResponse(), 
                resp.error, redirectUrl);            
        }

        /// <summary>
        /// Handle PaymentDetails API call
        /// </summary>
        /// <param name="context"></param>
        private void PaymentDetails(HttpContext context)
        {
            NameValueCollection parameters = context.Request.Params;
            PaymentDetailsRequest req = new PaymentDetailsRequest(new RequestEnvelope("en_US")); 
            // set optional parameters
            if (parameters["payKey"] != "")
                req.payKey = parameters["payKey"];
            if (parameters["transactionId"] != "")
                req.transactionId = parameters["transactionId"];
            if (parameters["trackingId"] != "")
                req.trackingId = parameters["trackingId"];

            // All set. Fire the request            
            AdaptivePaymentsService service = new AdaptivePaymentsService();
            PaymentDetailsResponse resp = null;
            try
            {
                resp = service.PaymentDetails(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {                
                keyResponseParams.Add("Pay key", resp.payKey);
                keyResponseParams.Add("Payment execution status", resp.status);
                keyResponseParams.Add("Sender email", resp.senderEmail);
            }
            displayResponse(context, "PaymentDetails", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }

        /// <summary>
        /// Handle Preapproval API
        /// </summary>
        /// <param name="context"></param>
        private void Preapproval(HttpContext context)
        {
            NameValueCollection parameters = context.Request.Params;
            PreapprovalRequest req = new PreapprovalRequest(new RequestEnvelope("en_US"), parameters["cancelUrl"], 
                    parameters["currencyCode"], parameters["returnUrl"], parameters["startingDate"]);
            // set optional parameters
            if(parameters["dateOfMonth"] != "") 
            {
	            req.dateOfMonth = Int32.Parse(parameters["dateOfMonth"]);
            }
            if(parameters["dayOfWeek"] != "" && parameters["dayOfWeek"] != "") 
            {
                req.dayOfWeek = (PayPal.AdaptivePayments.Model.DayOfWeek)
                        Enum.Parse(typeof(PayPal.AdaptivePayments.Model.DayOfWeek), parameters["dayOfWeek"]);
            }
            if(parameters["dateOfMonth"] != "") 
            {
	            req.dateOfMonth = Int32.Parse(parameters["dateOfMonth"]);
            }
            if(parameters["endingDate"] != "") 
            {
	            req.endingDate = parameters["endingDate"];
            }
            if(parameters["maxAmountPerPayment"] != "") 
            {
	            req.maxAmountPerPayment = Decimal.Parse(parameters["maxAmountPerPayment"]);
            }
            if(parameters["maxNumberOfPayments"] != "" ) 
            {
	            req.maxNumberOfPayments = Int32.Parse(parameters["maxNumberOfPayments"]);
            }
            if(parameters["maxNumberOfPaymentsPerPeriod"] != "") 
            {
	            req.maxNumberOfPaymentsPerPeriod = Int32.Parse(parameters["maxNumberOfPaymentsPerPeriod"]);
            }
            if(parameters["maxTotalAmountOfAllPayments"] != "") 
            {
	            req.maxTotalAmountOfAllPayments = Decimal.Parse(parameters["maxTotalAmountOfAllPayments"]);
            }
            if(parameters["paymentPeriod"] != "" && parameters["paymentPeriod"] != "") 
            {
	            req.paymentPeriod = parameters["paymentPeriod"];
            }
            if(parameters["memo"] != "") 
            {
	            req.memo = parameters["memo"];
            }
            if(parameters["ipnNotificationUrl"] != "") 
            {
	            req.ipnNotificationUrl = parameters["ipnNotificationUrl"];
            }
            if(parameters["senderEmail"] != "") 
            {
	            req.senderEmail = parameters["senderEmail"];
            }
            if(parameters["pinType"] != "" && parameters["pinType"] != "") 
            {
	            req.pinType = parameters["pinType"];
            }
            if(parameters["feesPayer"] != "") 
            {
	            req.feesPayer = parameters["feesPayer"];
            }
            if (parameters["displayMaxTotalAmount"] != "")
            {
                req.displayMaxTotalAmount = Boolean.Parse(parameters["displayMaxTotalAmount"]);
            }

            // All set. Fire the request            
            AdaptivePaymentsService service = new AdaptivePaymentsService();
            PreapprovalResponse resp = null;
            try
            {
                resp = service.Preapproval(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {
                keyResponseParams.Add("Preapproval key", resp.preapprovalKey);
            }
            displayResponse(context, "Preapproval", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }


        /// <summary>
        /// Handle PreapprovalDetails API call
        /// </summary>
        /// <param name="context"></param>
        private void PreapprovalDetails(HttpContext context)
        {
            NameValueCollection parameters = context.Request.Params;
            PreapprovalDetailsRequest req = new PreapprovalDetailsRequest(new RequestEnvelope("en_US"), 
                parameters["preapprovalKey"]);
            // set optional parameters
            if (parameters["getBillingAddress"] != "")
                req.getBillingAddress = Boolean.Parse(parameters["getBillingAddress"]);

            // All set. Fire the request            
            AdaptivePaymentsService service = new AdaptivePaymentsService();
            PreapprovalDetailsResponse resp = null;
            try
            {
                resp = service.PreapprovalDetails(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {
                keyResponseParams.Add("Status", resp.status);
                keyResponseParams.Add("Starting date", resp.startingDate);
                keyResponseParams.Add("Ending date", resp.endingDate);
                keyResponseParams.Add("Sender email", resp.senderEmail);
                keyResponseParams.Add("Currency code", resp.currencyCode);
                keyResponseParams.Add("Maximum amount (across all payments)", resp.maxTotalAmountOfAllPayments.ToString());                
            }
            displayResponse(context, "PreapprovalDetails", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }

        /// <summary>
        /// Handle CancelPreapproval API call
        /// </summary>
        /// <param name="context"></param>
        private void CancelPreapproval(HttpContext context)
        {
            NameValueCollection parameters = context.Request.Params;
            CancelPreapprovalRequest req = new CancelPreapprovalRequest(new RequestEnvelope("en_US"),
                parameters["preapprovalKey"]);

            // All set. Fire the request            
            AdaptivePaymentsService service = new AdaptivePaymentsService();
            CancelPreapprovalResponse resp = null;
            try
            {
                resp = service.CancelPreapproval(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {
                //nothing to add
            }
            displayResponse(context, "CancelPreapproval", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }

        /// <summary>
        /// Handle ConfirmPreapproval API call
        /// </summary>
        /// <param name="context"></param>
        private void ConfirmPreapproval(HttpContext context)
        {
            NameValueCollection parameters = context.Request.Params;
            ConfirmPreapprovalRequest req = new ConfirmPreapprovalRequest(new RequestEnvelope("en_US"),
                parameters["preapprovalKey"]);
            // Set optional parameters
            if (parameters["pin"] != "")
                req.pin = parameters["pin"];
            if (parameters["fundingSourceId"] != "")
                req.fundingSourceId = parameters["fundingSourceId"];

            // All set. Fire the request            
            AdaptivePaymentsService service = new AdaptivePaymentsService();
            ConfirmPreapprovalResponse resp = null;
            try
            {
                resp = service.ConfirmPreapproval(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {
                //nothing to add
            }
            displayResponse(context, "ConfirmPreapproval", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }


        /// <summary>
        /// Handle Refund API call
        /// </summary>
        /// <param name="context"></param>
        private void Refund(HttpContext context)
        {
            NameValueCollection parameters = context.Request.Params;
            RefundRequest req = new RefundRequest(new RequestEnvelope("en_US"));
            // Set optional parameters
            if(parameters["receiverEmail"].Length > 0) 
            {
                string[] amt = context.Request.Form.GetValues("receiverAmount");
                string[] receiverEmail = context.Request.Form.GetValues("receiverEmail");
                string[] phoneCountry = context.Request.Form.GetValues("phoneCountry");
                string[] phoneNumber = context.Request.Form.GetValues("phoneNumber");
                string[] phoneExtn = context.Request.Form.GetValues("phoneExtn");
                string[] primaryReceiver = context.Request.Form.GetValues("primaryReceiver");
                string[] invoiceId = context.Request.Form.GetValues("invoiceId");
                string[] paymentType = context.Request.Form.GetValues("paymentType");
                string[] paymentSubType = context.Request.Form.GetValues("paymentSubType");

	            List<Receiver> receivers = new List<Receiver>();
	            for(int i=0; i<amt.Length; i++) {
                    Receiver r = new Receiver(Decimal.Parse(amt[i]));
		            r.email = receiverEmail[i];
                    r.primary = Boolean.Parse(primaryReceiver[i]);
		            if(invoiceId[i] != "") {
			            r.invoiceId = invoiceId[i];
		            }
		            if(paymentType[i] != "") {
			            r.paymentType = paymentType[i];
		            }
		            if(paymentSubType[i] != "") {
			            r.paymentSubType = paymentSubType[i];
		            }
		            if(phoneCountry[i] != "" && phoneNumber[i] != "") {
			            r.phone = new PhoneNumberType(phoneCountry[i], phoneNumber[i]);
			            if(phoneExtn[i] != "") {
				            r.phone.extension = phoneExtn[i];
			            }
		            }
                    receivers.Add(r);
	            }
	            req.receiverList = new ReceiverList(receivers);
            }
            if(parameters["currencyCode"] != "") {
	            req.currencyCode = parameters["currencyCode"];
            }
            if(parameters["payKey"] != "") {
	            req.payKey = parameters["payKey"];
            }
            if(parameters["transactionId"] != "") {
	            req.transactionId = parameters["transactionId"];
            }
            if(parameters["trackingId"] != "") {
                req.trackingId = parameters["trackingId"];
            }            

            // All set. Fire the request            
            AdaptivePaymentsService service = new AdaptivePaymentsService();
            RefundResponse resp = null;
            try
            {
                resp = service.Refund(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {
                keyResponseParams.Add("Currency code", resp.currencyCode);
                int idx = 1;
                foreach (RefundInfo refund in resp.refundInfoList.refundInfo)
                {
                    keyResponseParams.Add("Refund receiver " + idx, refund.receiver.email);
                    keyResponseParams.Add("Refund amount " + idx, refund.receiver.amount.ToString());
                    keyResponseParams.Add("Refund status " + idx, refund.refundStatus);
                }
            }
            displayResponse(context, "Refund", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }


        /// <summary>
        /// Handle ConvertCurrency API call
        /// </summary>
        /// <param name="context"></param>
        private void ConvertCurrency(HttpContext context)
        {
            NameValueCollection parameters = context.Request.Params;           
            string[] fromCurrencyCodes = context.Request.Form.GetValues("currencyCode");
            string[] fromCurrencyAmounts = context.Request.Form.GetValues("currencyAmount");
            string[] toCurrencyCodes = context.Request.Form.GetValues("toCurrencyCode");

            List<CurrencyType> currencies = new List<CurrencyType>();
            for(int i=0; i<fromCurrencyCodes.Length; i++)
            {
                currencies.Add(
                    new CurrencyType(fromCurrencyCodes[i], decimal.Parse(fromCurrencyAmounts[i]))
                );
            }
            CurrencyList baseAmountList = new CurrencyList(currencies);

            List<String> toCurrencyCodeList = new List<String>();
            for (int i = 0; i < toCurrencyCodes.Length; i++)
                toCurrencyCodeList.Add(toCurrencyCodes[i]);
            CurrencyCodeList convertToCurrencyList = new CurrencyCodeList(toCurrencyCodeList);

            ConvertCurrencyRequest req = new ConvertCurrencyRequest(
                new RequestEnvelope("en_US"), baseAmountList, convertToCurrencyList);
            // Add optional parameters
            if (parameters["countryCode"] != "")
                req.countryCode = parameters["countryCode"];
            if (parameters["conversionType"] != "")
                req.conversionType = parameters["conversionType"];


            // All set. Fire the request            
            AdaptivePaymentsService service = new AdaptivePaymentsService();
            ConvertCurrencyResponse resp = null;
            try
            {
                resp = service.ConvertCurrency(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {
                if (resp.estimatedAmountTable != null
                    && resp.estimatedAmountTable.currencyConversionList != null)
                {
                    int idx = 1;
                    foreach (CurrencyConversionList list in resp.estimatedAmountTable.currencyConversionList)
                    {
                        keyResponseParams.Add("Base amount " + idx,
                            list.baseAmount.amount + " " + list.baseAmount.code);
                        idx++;
                    }
                }
            }
            displayResponse(context, "ConvertCurrency", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }

        /// <summary>
        /// Handle GetAllowedFundingSources API call
        /// </summary>
        /// <param name="context"></param>
        private void GetAllowedFundingSources(HttpContext context)
        {
            NameValueCollection parameters = context.Request.Params;
            GetAllowedFundingSourcesRequest req = 
                new GetAllowedFundingSourcesRequest(new RequestEnvelope("en_US"), parameters["key"]);

            // All set. Fire the request            
            AdaptivePaymentsService service = new AdaptivePaymentsService();
            GetAllowedFundingSourcesResponse resp = null;
            try
            {
                resp = service.GetAllowedFundingSources(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {
                int idx = 1;
                foreach (FundingSource source in resp.fundingSource)
                {
                    keyResponseParams.Add("Funding source id " + idx, source.fundingSourceId);
                    keyResponseParams.Add("Funding source name " + idx, source.displayName);
                    idx++;
                }                
            }
            displayResponse(context, "GetAllowedFundingSources", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }


        /// <summary>
        /// Handle GetFundingPlans API call
        /// </summary>
        /// <param name="context"></param>
        private void GetFundingPlans(HttpContext context)
        {
            NameValueCollection parameters = context.Request.Params;
            GetFundingPlansRequest req = new GetFundingPlansRequest(new RequestEnvelope("en_US"),
                parameters["payKey"]);

            // All set. Fire the request            
            AdaptivePaymentsService service = new AdaptivePaymentsService();
            GetFundingPlansResponse resp = null;
            try
            {
                resp = service.GetFundingPlans(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {
                int idx = 1;
                foreach (FundingPlan plan in resp.fundingPlan) {
                    keyResponseParams.Add("Funding plan Id " + idx, plan.fundingPlanId);
                    keyResponseParams.Add("Funding plan amount " + idx, 
                        plan.fundingAmount.amount + plan.fundingAmount.code );
                    idx++;
                }
            }
            displayResponse(context, "GetFundingPlans", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }


        /// <summary>
        /// Handle GetShippingAddresses API call
        /// </summary>
        /// <param name="context"></param>
        private void GetShippingAddresses(HttpContext context)
        {
            NameValueCollection parameters = context.Request.Params;
            GetShippingAddressesRequest req = new GetShippingAddressesRequest(new RequestEnvelope("en_US"),
                parameters["key"]);

            // All set. Fire the request            
            AdaptivePaymentsService service = new AdaptivePaymentsService();
            GetShippingAddressesResponse resp = null;
            try
            {
                resp = service.GetShippingAddresses(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {
                if (resp.selectedAddress != null)
                {
                    keyResponseParams.Add("Address name", resp.selectedAddress.addresseeName);
                    keyResponseParams.Add("Address Id", resp.selectedAddress.addressId);
                    if (resp.selectedAddress.baseAddress != null)
                    {
                        keyResponseParams.Add("Address line", resp.selectedAddress.baseAddress.line1);
                        keyResponseParams.Add("City", resp.selectedAddress.baseAddress.city);
                        keyResponseParams.Add("State", resp.selectedAddress.baseAddress.state);
                    }
                }
            }
            displayResponse(context, "GetShippingAddresses", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }

        /// <summary>
        /// Handle GetAvailableShippingAddresses API call
        /// </summary>
        /// <param name="context"></param>
        private void GetAvailableShippingAddresses(HttpContext context)
        {
            NameValueCollection parameters = context.Request.Params;
            GetAvailableShippingAddressesRequest req = new GetAvailableShippingAddressesRequest(
                    new RequestEnvelope("en_US"), parameters["key"]);

            // All set. Fire the request            
            AdaptivePaymentsService service = new AdaptivePaymentsService();
            GetAvailableShippingAddressesResponse resp = null;
            try
            {
                resp = service.GetAvailableShippingAddresses(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {
                int idx = 1;
                foreach(Address addr in resp.availableAddress) 
                {
                    keyResponseParams.Add("Address name " + idx, addr.addresseeName);
                    keyResponseParams.Add("Address Id " + idx, addr.addressId);
                    if (addr.baseAddress != null)
                    {
                        keyResponseParams.Add("Address line " + idx, addr.baseAddress.line1);
                        keyResponseParams.Add("City " + idx, addr.baseAddress.city);
                        keyResponseParams.Add("State " + idx, addr.baseAddress.state);
                    }
                }
            }
            displayResponse(context, "GetAvailableShippingAddresses", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }

        /// <summary>
        /// Handle SetPaymentOptions API call
        /// </summary>
        /// <param name="context"></param>
        private void SetPaymentOptions(HttpContext context)
        {
            NameValueCollection parameters = context.Request.Params;
            SetPaymentOptionsRequest req = new SetPaymentOptionsRequest(
                    new RequestEnvelope("en_US"), parameters["payKey"]);
            if (parameters["institutionId"] != "")
            {
                req.initiatingEntity = new InitiatingEntity();
                req.initiatingEntity.institutionCustomer = new InstitutionCustomer(
                    parameters["institutionId"], parameters["firstName"], 
                    parameters["lastName"], parameters["displayName"], 
                    parameters["institutionCustomerId"], parameters["countryCode"]);
                if (parameters["email"] != "")
                {
                    req.initiatingEntity.institutionCustomer.email = parameters["email"];
                }
            }
            if (parameters["emailHeaderImageUrl"] != "" || parameters["emailMarketingImageUrl"] != ""
                || parameters["headerImageUrl"] != "" || parameters["businessName"] != "")
            {
                req.displayOptions = new DisplayOptions();
                if (parameters["emailHeaderImageUrl"] != "" )
                    req.displayOptions.emailHeaderImageUrl = parameters["emailHeaderImageUrl"];
                if (parameters["emailMarketingImageUrl"] != "")
                    req.displayOptions.emailMarketingImageUrl = parameters["emailMarketingImageUrl"];
                if(parameters["headerImageUrl"] != "" )
                    req.displayOptions.headerImageUrl = parameters["headerImageUrl"];
                if(parameters["businessName"] != "")
                    req.displayOptions.businessName = parameters["businessName"];
            }
            if (parameters["shippingAddressId"] != "")
            {
                req.shippingAddressId = parameters["shippingAddressId"];
            }
            if (parameters["requireShippingAddressSelection"] != "" || parameters["referrerCode"] != "")
            {
                req.senderOptions = new SenderOptions();
                if (parameters["requireShippingAddressSelection"] != "")
                    req.senderOptions.requireShippingAddressSelection = 
                        Boolean.Parse(parameters["requireShippingAddressSelection"]);
                if (parameters["referrerCode"] != "")
                    req.senderOptions.referrerCode = parameters["referrerCode"];
            }
            req.receiverOptions = new List<ReceiverOptions>();
            ReceiverOptions receiverOption = new ReceiverOptions();
            req.receiverOptions.Add(receiverOption);
            if (parameters["description"] != "")
                receiverOption.description = parameters["description"];
            if (parameters["customId"] != "")
                receiverOption.customId = parameters["customId"];

            string[] name = context.Request.Form.GetValues("name");
            string[] identifier = context.Request.Form.GetValues("identifier");
            string[] price = context.Request.Form.GetValues("price");
            string[] itemPrice = context.Request.Form.GetValues("itemPrice");
            string[] itemCount = context.Request.Form.GetValues("itemCount");
            if (name.Length > 0 && name[0] != "")
            {
                receiverOption.invoiceData = new InvoiceData();
                for (int j = 0; j < name.Length; j++)
                {
                    InvoiceItem item = new InvoiceItem();
                    if (name[j] != "")
                        item.name = name[j];
                    if (identifier[j] != "")
                        item.identifier = identifier[j];
                    if (price[j] != "")
                        item.price = Decimal.Parse(price[j]);
                    if (itemPrice[j] != "")
                        item.itemPrice = Decimal.Parse(itemPrice[j]);
                    if (itemCount[j] != "")
                        item.itemCount = Int32.Parse(itemCount[j]);
                    receiverOption.invoiceData.item.Add(item);
                }
                if (parameters["totalTax"] != "")
                    receiverOption.invoiceData.totalTax = Decimal.Parse(parameters["totalTax"]);
                if (parameters["totalShipping"] != "")
                    receiverOption.invoiceData.totalShipping = Decimal.Parse(parameters["totalShipping"]);
            }
            if (parameters["emailIdentifier"] != "" ||
                (parameters["phoneCountry"] != "" && parameters["phoneNumber"] != ""))
            {
                receiverOption.receiver = new ReceiverIdentifier();
                if(parameters["emailIdentifier"] != "")
                    receiverOption.receiver.email = parameters["emailIdentifier"];
                if (parameters["phoneCountry"] != "" && parameters["phoneNumber"] != "")
                {
                    receiverOption.receiver.phone = 
                        new PhoneNumberType(parameters["phoneCountry"], parameters["phoneNumber"]);
                    if (parameters["phoneExtn"] != "")
                        receiverOption.receiver.phone.extension = parameters["phoneExtn"];
                }
            }
            if (parameters["receiverReferrerCode"] != "")
                receiverOption.referrerCode = parameters["receiverReferrerCode"];

            // All set. Fire the request            
            AdaptivePaymentsService service = new AdaptivePaymentsService();
            SetPaymentOptionsResponse resp = null;
            try
            {
                resp = service.SetPaymentOptions(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();            
            displayResponse(context, "SetPaymentOptions", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, null);
        }

        /// <summary>
        /// Handle GetPaymentOptions API call
        /// </summary>
        /// <param name="context"></param>
        private void GetPaymentOptions(HttpContext context)
        {
            NameValueCollection parameters = context.Request.Params;
            GetPaymentOptionsRequest req = new GetPaymentOptionsRequest(
                    new RequestEnvelope("en_US"), parameters["payKey"]);

            // All set. Fire the request            
            AdaptivePaymentsService service = new AdaptivePaymentsService();
            GetPaymentOptionsResponse resp = null;
            try
            {
                resp = service.GetPaymentOptions(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {
                int idx = 1;
                foreach(ReceiverOptions option in resp.receiverOptions)
                {
                    keyResponseParams.Add("Receiver option " + idx, option.description);
                    if(option.receiver.email != null)
                        keyResponseParams.Add("Receiver email " + idx, option.receiver.email);
                    idx++;
                }
                if(resp.displayOptions != null) 
                {
                    keyResponseParams.Add("Business name", resp.displayOptions.businessName);
                    keyResponseParams.Add("Header image", resp.displayOptions.headerImageUrl);
                    keyResponseParams.Add("Email header image", resp.displayOptions.emailHeaderImageUrl);
                }
                keyResponseParams.Add("Shipping address Id", resp.shippingAddressId);
            }
            displayResponse(context, "GetPaymentOptions", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }

        /// <summary>
        /// Handle ExecutePayment API call
        /// </summary>
        /// <param name="context"></param>
        private void ExecutePayment(HttpContext context)
        {
            NameValueCollection parameters = context.Request.Params;
            ExecutePaymentRequest req = new ExecutePaymentRequest(
                    new RequestEnvelope("en_US"), parameters["payKey"]);

            // All set. Fire the request            
            AdaptivePaymentsService service = new AdaptivePaymentsService();
            ExecutePaymentResponse resp = null;
            try
            {
                resp = service.ExecutePayment(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {
                keyResponseParams.Add("Payment exeucution status", resp.paymentExecStatus);
            }
            displayResponse(context, "ExecutePayment", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }

        /// <summary>
        /// Handle GetUserLimits API call
        /// </summary>
        /// <param name="context"></param>
        private void GetUserLimits(HttpContext context)
        {
            NameValueCollection parameters = context.Request.Params;

            List<string> limitType = new List<string>();
            if(parameters["limitType"] != "")
                limitType.Add(parameters["limitType"]);
            AccountIdentifier accountId = new AccountIdentifier();
            if (parameters["email"] != "")
            {
                accountId.email = parameters["email"];
            }
            if (parameters["phoneCountry"] != "" && parameters["phoneNumber"] != "")
            {
                accountId.phone = new PhoneNumberType(parameters["phoneCountry"], parameters["phoneNumber"]);
                if (parameters["phoneExtension"] != "")
                    accountId.phone.extension = parameters["phoneExtension"];
            }

            GetUserLimitsRequest req = new GetUserLimitsRequest(
                    new RequestEnvelope("en_US"), accountId, parameters["country"], 
                    parameters["currencyCode"], limitType);

            // All set. Fire the request            
            AdaptivePaymentsService service = new AdaptivePaymentsService();
            GetUserLimitsResponse resp = null;
            try
            {
                resp = service.GetUserLimits(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {
                int idx = 1;
                foreach (UserLimit userLimit in resp.userLimit)
                {
                    keyResponseParams.Add("Limit amount " + idx,
                        userLimit.limitAmount.amount + userLimit.limitAmount.code);
                    keyResponseParams.Add("Limit type " + idx, userLimit.limitType);
                    idx++;
                }
            }
            displayResponse(context, "GetAvailableShippingAddresses", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }


        /// <summary>
        /// Utility method for displaying API response
        /// </summary>
        /// <param name="context"></param>
        /// <param name="apiName"></param>
        /// <param name="responseValues"></param>
        /// <param name="requestPayload"></param>
        /// <param name="responsePayload"></param>
        /// <param name="errorMessages"></param>
        /// <param name="redirectUrl"></param>
        private void displayResponse(HttpContext context, string apiName, Dictionary<string, string> responseValues, 
            string requestPayload, string responsePayload, List<ErrorData> errorMessages, string redirectUrl)
        {

            context.Response.Write("<html><head><title>");
            context.Response.Write("PayPal Adaptive Payments - " + apiName);
            context.Response.Write("</title><link rel='stylesheet' href='Content/sdk.css' type='text/css'/></head><body>");
            context.Response.Write("<h3>" + apiName + " response</h3>");
            if (errorMessages != null && errorMessages.Count > 0)
            {
                context.Response.Write("<div class='section_header'>Error messages</div>");
                context.Response.Write("<div class='note'>Investigate the response object for further error information</div><ul>");
                foreach (ErrorData error in errorMessages)
                {   
                    context.Response.Write("<li>" + error.message + "</li>");       
                }
                context.Response.Write("</ul>");
            }
            if (redirectUrl != null)
            {
                string red = "<div>This API involves a web flow. You must now redirect your user to " + redirectUrl;
                red = red + "<br />Please click <a href='" + redirectUrl + "' target='_blank'>here</a> to try the flow.</div><br/>";
                context.Response.Write(red);
            }
            context.Response.Write("<div class='section_header'>Key values from response</div>");
            context.Response.Write("<div class='note'>Consult response object and reference doc for complete list of response values.</div><table>");
            foreach (KeyValuePair<String, String> entry in responseValues) {
                context.Response.Write("<tr><td class='label'>");
                context.Response.Write(entry.Key);
                context.Response.Write(": </td><td>");
                context.Response.Write(entry.Value);
                context.Response.Write("</td></tr>");
            }

            context.Response.Write("</table><h4>Request:</h4><br/><textarea rows=15 cols=80 readonly>");
            context.Response.Write(requestPayload);
            context.Response.Write("</textarea><br/><h4>Response</h4><br/><textarea rows=15 cols=80 readonly>");
            context.Response.Write(responsePayload);
            context.Response.Write("</textarea>");            
            context.Response.Write("<br/><br/><a href='Default.aspx'>Home<a><br/><br/></body></html>");
        }
    }
}