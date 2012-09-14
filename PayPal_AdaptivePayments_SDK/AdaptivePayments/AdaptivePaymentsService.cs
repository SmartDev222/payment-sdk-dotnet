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
	 	public CancelPreapprovalResponse CancelPreapproval(CancelPreapprovalRequest CancelPreapprovalRequest, string apiUsername)
	 	{
			string resp = call("CancelPreapproval", CancelPreapprovalRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return CancelPreapprovalResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CancelPreapprovalResponse CancelPreapproval(CancelPreapprovalRequest CancelPreapprovalRequest)
	 	{
	 		return CancelPreapproval(CancelPreapprovalRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public ConfirmPreapprovalResponse ConfirmPreapproval(ConfirmPreapprovalRequest ConfirmPreapprovalRequest, string apiUsername)
	 	{
			string resp = call("ConfirmPreapproval", ConfirmPreapprovalRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return ConfirmPreapprovalResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public ConfirmPreapprovalResponse ConfirmPreapproval(ConfirmPreapprovalRequest ConfirmPreapprovalRequest)
	 	{
	 		return ConfirmPreapproval(ConfirmPreapprovalRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public ConvertCurrencyResponse ConvertCurrency(ConvertCurrencyRequest ConvertCurrencyRequest, string apiUsername)
	 	{
			string resp = call("ConvertCurrency", ConvertCurrencyRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return ConvertCurrencyResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public ConvertCurrencyResponse ConvertCurrency(ConvertCurrencyRequest ConvertCurrencyRequest)
	 	{
	 		return ConvertCurrency(ConvertCurrencyRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public ExecutePaymentResponse ExecutePayment(ExecutePaymentRequest ExecutePaymentRequest, string apiUsername)
	 	{
			string resp = call("ExecutePayment", ExecutePaymentRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return ExecutePaymentResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public ExecutePaymentResponse ExecutePayment(ExecutePaymentRequest ExecutePaymentRequest)
	 	{
	 		return ExecutePayment(ExecutePaymentRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAllowedFundingSourcesResponse GetAllowedFundingSources(GetAllowedFundingSourcesRequest GetAllowedFundingSourcesRequest, string apiUsername)
	 	{
			string resp = call("GetAllowedFundingSources", GetAllowedFundingSourcesRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return GetAllowedFundingSourcesResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetAllowedFundingSourcesResponse GetAllowedFundingSources(GetAllowedFundingSourcesRequest GetAllowedFundingSourcesRequest)
	 	{
	 		return GetAllowedFundingSources(GetAllowedFundingSourcesRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetPaymentOptionsResponse GetPaymentOptions(GetPaymentOptionsRequest GetPaymentOptionsRequest, string apiUsername)
	 	{
			string resp = call("GetPaymentOptions", GetPaymentOptionsRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return GetPaymentOptionsResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetPaymentOptionsResponse GetPaymentOptions(GetPaymentOptionsRequest GetPaymentOptionsRequest)
	 	{
	 		return GetPaymentOptions(GetPaymentOptionsRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public PaymentDetailsResponse PaymentDetails(PaymentDetailsRequest PaymentDetailsRequest, string apiUsername)
	 	{
			string resp = call("PaymentDetails", PaymentDetailsRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return PaymentDetailsResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public PaymentDetailsResponse PaymentDetails(PaymentDetailsRequest PaymentDetailsRequest)
	 	{
	 		return PaymentDetails(PaymentDetailsRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public PayResponse Pay(PayRequest PayRequest, string apiUsername)
	 	{
			string resp = call("Pay", PayRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return PayResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public PayResponse Pay(PayRequest PayRequest)
	 	{
	 		return Pay(PayRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalDetailsResponse PreapprovalDetails(PreapprovalDetailsRequest PreapprovalDetailsRequest, string apiUsername)
	 	{
			string resp = call("PreapprovalDetails", PreapprovalDetailsRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return PreapprovalDetailsResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalDetailsResponse PreapprovalDetails(PreapprovalDetailsRequest PreapprovalDetailsRequest)
	 	{
	 		return PreapprovalDetails(PreapprovalDetailsRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalResponse Preapproval(PreapprovalRequest PreapprovalRequest, string apiUsername)
	 	{
			string resp = call("Preapproval", PreapprovalRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return PreapprovalResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalResponse Preapproval(PreapprovalRequest PreapprovalRequest)
	 	{
	 		return Preapproval(PreapprovalRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public RefundResponse Refund(RefundRequest RefundRequest, string apiUsername)
	 	{
			string resp = call("Refund", RefundRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return RefundResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public RefundResponse Refund(RefundRequest RefundRequest)
	 	{
	 		return Refund(RefundRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public SetPaymentOptionsResponse SetPaymentOptions(SetPaymentOptionsRequest SetPaymentOptionsRequest, string apiUsername)
	 	{
			string resp = call("SetPaymentOptions", SetPaymentOptionsRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return SetPaymentOptionsResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public SetPaymentOptionsResponse SetPaymentOptions(SetPaymentOptionsRequest SetPaymentOptionsRequest)
	 	{
	 		return SetPaymentOptions(SetPaymentOptionsRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetFundingPlansResponse GetFundingPlans(GetFundingPlansRequest GetFundingPlansRequest, string apiUsername)
	 	{
			string resp = call("GetFundingPlans", GetFundingPlansRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return GetFundingPlansResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetFundingPlansResponse GetFundingPlans(GetFundingPlansRequest GetFundingPlansRequest)
	 	{
	 		return GetFundingPlans(GetFundingPlansRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAvailableShippingAddressesResponse GetAvailableShippingAddresses(GetAvailableShippingAddressesRequest GetAvailableShippingAddressesRequest, string apiUsername)
	 	{
			string resp = call("GetAvailableShippingAddresses", GetAvailableShippingAddressesRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return GetAvailableShippingAddressesResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetAvailableShippingAddressesResponse GetAvailableShippingAddresses(GetAvailableShippingAddressesRequest GetAvailableShippingAddressesRequest)
	 	{
	 		return GetAvailableShippingAddresses(GetAvailableShippingAddressesRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetShippingAddressesResponse GetShippingAddresses(GetShippingAddressesRequest GetShippingAddressesRequest, string apiUsername)
	 	{
			string resp = call("GetShippingAddresses", GetShippingAddressesRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return GetShippingAddressesResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetShippingAddressesResponse GetShippingAddresses(GetShippingAddressesRequest GetShippingAddressesRequest)
	 	{
	 		return GetShippingAddresses(GetShippingAddressesRequest, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetUserLimitsResponse GetUserLimits(GetUserLimitsRequest GetUserLimitsRequest, string apiUsername)
	 	{
			string resp = call("GetUserLimits", GetUserLimitsRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return GetUserLimitsResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetUserLimitsResponse GetUserLimits(GetUserLimitsRequest GetUserLimitsRequest)
	 	{
	 		return GetUserLimits(GetUserLimitsRequest, null);
	 	}
	}
}
