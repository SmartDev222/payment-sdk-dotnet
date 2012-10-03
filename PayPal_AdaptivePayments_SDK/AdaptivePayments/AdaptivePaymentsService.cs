using System.Xml;
using PayPal;
using PayPal.Authentication;
using PayPal.Util;
using PayPal.Manager;
using PayPal.AdaptivePayments.Model;

namespace PayPal.AdaptivePayments {
	public partial class AdaptivePaymentsService : BasePayPalService {

		// Service Version
		private static string ServiceVersion = "1.8.1";

		// Service Name
		private static string ServiceName = "AdaptivePayments";

		public AdaptivePaymentsService() : base(ServiceName, ServiceVersion)
		{
		}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public CancelPreapprovalResponse CancelPreapproval(CancelPreapprovalRequest cancelPreapprovalRequest, string apiUserName)
	 	{
			string response = Call("CancelPreapproval", cancelPreapprovalRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return CancelPreapprovalResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CancelPreapprovalResponse CancelPreapproval(CancelPreapprovalRequest cancelPreapprovalRequest)
	 	{
	 		return CancelPreapproval(cancelPreapprovalRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public ConfirmPreapprovalResponse ConfirmPreapproval(ConfirmPreapprovalRequest confirmPreapprovalRequest, string apiUserName)
	 	{
			string response = Call("ConfirmPreapproval", confirmPreapprovalRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return ConfirmPreapprovalResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public ConfirmPreapprovalResponse ConfirmPreapproval(ConfirmPreapprovalRequest confirmPreapprovalRequest)
	 	{
	 		return ConfirmPreapproval(confirmPreapprovalRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public ConvertCurrencyResponse ConvertCurrency(ConvertCurrencyRequest convertCurrencyRequest, string apiUserName)
	 	{
			string response = Call("ConvertCurrency", convertCurrencyRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return ConvertCurrencyResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public ConvertCurrencyResponse ConvertCurrency(ConvertCurrencyRequest convertCurrencyRequest)
	 	{
	 		return ConvertCurrency(convertCurrencyRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public ExecutePaymentResponse ExecutePayment(ExecutePaymentRequest executePaymentRequest, string apiUserName)
	 	{
			string response = Call("ExecutePayment", executePaymentRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return ExecutePaymentResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public ExecutePaymentResponse ExecutePayment(ExecutePaymentRequest executePaymentRequest)
	 	{
	 		return ExecutePayment(executePaymentRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAllowedFundingSourcesResponse GetAllowedFundingSources(GetAllowedFundingSourcesRequest getAllowedFundingSourcesRequest, string apiUserName)
	 	{
			string response = Call("GetAllowedFundingSources", getAllowedFundingSourcesRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return GetAllowedFundingSourcesResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetAllowedFundingSourcesResponse GetAllowedFundingSources(GetAllowedFundingSourcesRequest getAllowedFundingSourcesRequest)
	 	{
	 		return GetAllowedFundingSources(getAllowedFundingSourcesRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetPaymentOptionsResponse GetPaymentOptions(GetPaymentOptionsRequest getPaymentOptionsRequest, string apiUserName)
	 	{
			string response = Call("GetPaymentOptions", getPaymentOptionsRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return GetPaymentOptionsResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetPaymentOptionsResponse GetPaymentOptions(GetPaymentOptionsRequest getPaymentOptionsRequest)
	 	{
	 		return GetPaymentOptions(getPaymentOptionsRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public PaymentDetailsResponse PaymentDetails(PaymentDetailsRequest paymentDetailsRequest, string apiUserName)
	 	{
			string response = Call("PaymentDetails", paymentDetailsRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return PaymentDetailsResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public PaymentDetailsResponse PaymentDetails(PaymentDetailsRequest paymentDetailsRequest)
	 	{
	 		return PaymentDetails(paymentDetailsRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public PayResponse Pay(PayRequest payRequest, string apiUserName)
	 	{
			string response = Call("Pay", payRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return PayResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public PayResponse Pay(PayRequest payRequest)
	 	{
	 		return Pay(payRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalDetailsResponse PreapprovalDetails(PreapprovalDetailsRequest preapprovalDetailsRequest, string apiUserName)
	 	{
			string response = Call("PreapprovalDetails", preapprovalDetailsRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return PreapprovalDetailsResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalDetailsResponse PreapprovalDetails(PreapprovalDetailsRequest preapprovalDetailsRequest)
	 	{
	 		return PreapprovalDetails(preapprovalDetailsRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalResponse Preapproval(PreapprovalRequest preapprovalRequest, string apiUserName)
	 	{
			string response = Call("Preapproval", preapprovalRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return PreapprovalResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalResponse Preapproval(PreapprovalRequest preapprovalRequest)
	 	{
	 		return Preapproval(preapprovalRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public RefundResponse Refund(RefundRequest refundRequest, string apiUserName)
	 	{
			string response = Call("Refund", refundRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return RefundResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public RefundResponse Refund(RefundRequest refundRequest)
	 	{
	 		return Refund(refundRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public SetPaymentOptionsResponse SetPaymentOptions(SetPaymentOptionsRequest setPaymentOptionsRequest, string apiUserName)
	 	{
			string response = Call("SetPaymentOptions", setPaymentOptionsRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return SetPaymentOptionsResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public SetPaymentOptionsResponse SetPaymentOptions(SetPaymentOptionsRequest setPaymentOptionsRequest)
	 	{
	 		return SetPaymentOptions(setPaymentOptionsRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetFundingPlansResponse GetFundingPlans(GetFundingPlansRequest getFundingPlansRequest, string apiUserName)
	 	{
			string response = Call("GetFundingPlans", getFundingPlansRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return GetFundingPlansResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetFundingPlansResponse GetFundingPlans(GetFundingPlansRequest getFundingPlansRequest)
	 	{
	 		return GetFundingPlans(getFundingPlansRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAvailableShippingAddressesResponse GetAvailableShippingAddresses(GetAvailableShippingAddressesRequest getAvailableShippingAddressesRequest, string apiUserName)
	 	{
			string response = Call("GetAvailableShippingAddresses", getAvailableShippingAddressesRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return GetAvailableShippingAddressesResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetAvailableShippingAddressesResponse GetAvailableShippingAddresses(GetAvailableShippingAddressesRequest getAvailableShippingAddressesRequest)
	 	{
	 		return GetAvailableShippingAddresses(getAvailableShippingAddressesRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetShippingAddressesResponse GetShippingAddresses(GetShippingAddressesRequest getShippingAddressesRequest, string apiUserName)
	 	{
			string response = Call("GetShippingAddresses", getShippingAddressesRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return GetShippingAddressesResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetShippingAddressesResponse GetShippingAddresses(GetShippingAddressesRequest getShippingAddressesRequest)
	 	{
	 		return GetShippingAddresses(getShippingAddressesRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetUserLimitsResponse GetUserLimits(GetUserLimitsRequest getUserLimitsRequest, string apiUserName)
	 	{
			string response = Call("GetUserLimits", getUserLimitsRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return GetUserLimitsResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetUserLimitsResponse GetUserLimits(GetUserLimitsRequest getUserLimitsRequest)
	 	{
	 		return GetUserLimits(getUserLimitsRequest, null);
	 	}
	}
}
