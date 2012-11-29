using System.Xml;
using PayPal;
using PayPal.Authentication;
using PayPal.Util;
using PayPal.Manager;
using PayPal.NVP;
using PayPal.AdaptivePayments.Model;

namespace PayPal.AdaptivePayments 
{
	public partial class AdaptivePaymentsService : BasePayPalService 
	{

		// Service Version
		private const string ServiceVersion = "1.8.2";

		// Service Name
		private const string ServiceName = "AdaptivePayments";
		
		//SDK Name
		private const string SDKName = "adaptivepayments-dotnet-sdk";
	
		//SDK Version
		private const string SDKVersion = "2.0.96";

		public AdaptivePaymentsService() {}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public CancelPreapprovalResponse CancelPreapproval(CancelPreapprovalRequest cancelPreapprovalRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(cancelPreapprovalRequest.ToNVPString(string.Empty), ServiceName, "CancelPreapproval", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return CancelPreapprovalResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CancelPreapprovalResponse CancelPreapproval(CancelPreapprovalRequest cancelPreapprovalRequest)
	 	{
	 		return CancelPreapproval(cancelPreapprovalRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public CancelPreapprovalResponse CancelPreapproval(CancelPreapprovalRequest cancelPreapprovalRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(cancelPreapprovalRequest.ToNVPString(string.Empty), ServiceName, "CancelPreapproval", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return CancelPreapprovalResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public ConfirmPreapprovalResponse ConfirmPreapproval(ConfirmPreapprovalRequest confirmPreapprovalRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(confirmPreapprovalRequest.ToNVPString(string.Empty), ServiceName, "ConfirmPreapproval", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return ConfirmPreapprovalResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public ConfirmPreapprovalResponse ConfirmPreapproval(ConfirmPreapprovalRequest confirmPreapprovalRequest)
	 	{
	 		return ConfirmPreapproval(confirmPreapprovalRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public ConfirmPreapprovalResponse ConfirmPreapproval(ConfirmPreapprovalRequest confirmPreapprovalRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(confirmPreapprovalRequest.ToNVPString(string.Empty), ServiceName, "ConfirmPreapproval", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return ConfirmPreapprovalResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public ConvertCurrencyResponse ConvertCurrency(ConvertCurrencyRequest convertCurrencyRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(convertCurrencyRequest.ToNVPString(string.Empty), ServiceName, "ConvertCurrency", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return ConvertCurrencyResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public ConvertCurrencyResponse ConvertCurrency(ConvertCurrencyRequest convertCurrencyRequest)
	 	{
	 		return ConvertCurrency(convertCurrencyRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public ConvertCurrencyResponse ConvertCurrency(ConvertCurrencyRequest convertCurrencyRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(convertCurrencyRequest.ToNVPString(string.Empty), ServiceName, "ConvertCurrency", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return ConvertCurrencyResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public ExecutePaymentResponse ExecutePayment(ExecutePaymentRequest executePaymentRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(executePaymentRequest.ToNVPString(string.Empty), ServiceName, "ExecutePayment", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return ExecutePaymentResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public ExecutePaymentResponse ExecutePayment(ExecutePaymentRequest executePaymentRequest)
	 	{
	 		return ExecutePayment(executePaymentRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public ExecutePaymentResponse ExecutePayment(ExecutePaymentRequest executePaymentRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(executePaymentRequest.ToNVPString(string.Empty), ServiceName, "ExecutePayment", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return ExecutePaymentResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAllowedFundingSourcesResponse GetAllowedFundingSources(GetAllowedFundingSourcesRequest getAllowedFundingSourcesRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(getAllowedFundingSourcesRequest.ToNVPString(string.Empty), ServiceName, "GetAllowedFundingSources", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetAllowedFundingSourcesResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetAllowedFundingSourcesResponse GetAllowedFundingSources(GetAllowedFundingSourcesRequest getAllowedFundingSourcesRequest)
	 	{
	 		return GetAllowedFundingSources(getAllowedFundingSourcesRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAllowedFundingSourcesResponse GetAllowedFundingSources(GetAllowedFundingSourcesRequest getAllowedFundingSourcesRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(getAllowedFundingSourcesRequest.ToNVPString(string.Empty), ServiceName, "GetAllowedFundingSources", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetAllowedFundingSourcesResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetPaymentOptionsResponse GetPaymentOptions(GetPaymentOptionsRequest getPaymentOptionsRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(getPaymentOptionsRequest.ToNVPString(string.Empty), ServiceName, "GetPaymentOptions", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetPaymentOptionsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetPaymentOptionsResponse GetPaymentOptions(GetPaymentOptionsRequest getPaymentOptionsRequest)
	 	{
	 		return GetPaymentOptions(getPaymentOptionsRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public GetPaymentOptionsResponse GetPaymentOptions(GetPaymentOptionsRequest getPaymentOptionsRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(getPaymentOptionsRequest.ToNVPString(string.Empty), ServiceName, "GetPaymentOptions", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetPaymentOptionsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public PaymentDetailsResponse PaymentDetails(PaymentDetailsRequest paymentDetailsRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(paymentDetailsRequest.ToNVPString(string.Empty), ServiceName, "PaymentDetails", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return PaymentDetailsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public PaymentDetailsResponse PaymentDetails(PaymentDetailsRequest paymentDetailsRequest)
	 	{
	 		return PaymentDetails(paymentDetailsRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public PaymentDetailsResponse PaymentDetails(PaymentDetailsRequest paymentDetailsRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(paymentDetailsRequest.ToNVPString(string.Empty), ServiceName, "PaymentDetails", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return PaymentDetailsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public PayResponse Pay(PayRequest payRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(payRequest.ToNVPString(string.Empty), ServiceName, "Pay", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return PayResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public PayResponse Pay(PayRequest payRequest)
	 	{
	 		return Pay(payRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public PayResponse Pay(PayRequest payRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(payRequest.ToNVPString(string.Empty), ServiceName, "Pay", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return PayResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalDetailsResponse PreapprovalDetails(PreapprovalDetailsRequest preapprovalDetailsRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(preapprovalDetailsRequest.ToNVPString(string.Empty), ServiceName, "PreapprovalDetails", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return PreapprovalDetailsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalDetailsResponse PreapprovalDetails(PreapprovalDetailsRequest preapprovalDetailsRequest)
	 	{
	 		return PreapprovalDetails(preapprovalDetailsRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalDetailsResponse PreapprovalDetails(PreapprovalDetailsRequest preapprovalDetailsRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(preapprovalDetailsRequest.ToNVPString(string.Empty), ServiceName, "PreapprovalDetails", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return PreapprovalDetailsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalResponse Preapproval(PreapprovalRequest preapprovalRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(preapprovalRequest.ToNVPString(string.Empty), ServiceName, "Preapproval", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return PreapprovalResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalResponse Preapproval(PreapprovalRequest preapprovalRequest)
	 	{
	 		return Preapproval(preapprovalRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public PreapprovalResponse Preapproval(PreapprovalRequest preapprovalRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(preapprovalRequest.ToNVPString(string.Empty), ServiceName, "Preapproval", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return PreapprovalResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public RefundResponse Refund(RefundRequest refundRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(refundRequest.ToNVPString(string.Empty), ServiceName, "Refund", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return RefundResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public RefundResponse Refund(RefundRequest refundRequest)
	 	{
	 		return Refund(refundRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public RefundResponse Refund(RefundRequest refundRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(refundRequest.ToNVPString(string.Empty), ServiceName, "Refund", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return RefundResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public SetPaymentOptionsResponse SetPaymentOptions(SetPaymentOptionsRequest setPaymentOptionsRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(setPaymentOptionsRequest.ToNVPString(string.Empty), ServiceName, "SetPaymentOptions", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return SetPaymentOptionsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public SetPaymentOptionsResponse SetPaymentOptions(SetPaymentOptionsRequest setPaymentOptionsRequest)
	 	{
	 		return SetPaymentOptions(setPaymentOptionsRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public SetPaymentOptionsResponse SetPaymentOptions(SetPaymentOptionsRequest setPaymentOptionsRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(setPaymentOptionsRequest.ToNVPString(string.Empty), ServiceName, "SetPaymentOptions", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return SetPaymentOptionsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetFundingPlansResponse GetFundingPlans(GetFundingPlansRequest getFundingPlansRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(getFundingPlansRequest.ToNVPString(string.Empty), ServiceName, "GetFundingPlans", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetFundingPlansResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetFundingPlansResponse GetFundingPlans(GetFundingPlansRequest getFundingPlansRequest)
	 	{
	 		return GetFundingPlans(getFundingPlansRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public GetFundingPlansResponse GetFundingPlans(GetFundingPlansRequest getFundingPlansRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(getFundingPlansRequest.ToNVPString(string.Empty), ServiceName, "GetFundingPlans", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetFundingPlansResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAvailableShippingAddressesResponse GetAvailableShippingAddresses(GetAvailableShippingAddressesRequest getAvailableShippingAddressesRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(getAvailableShippingAddressesRequest.ToNVPString(string.Empty), ServiceName, "GetAvailableShippingAddresses", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetAvailableShippingAddressesResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetAvailableShippingAddressesResponse GetAvailableShippingAddresses(GetAvailableShippingAddressesRequest getAvailableShippingAddressesRequest)
	 	{
	 		return GetAvailableShippingAddresses(getAvailableShippingAddressesRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAvailableShippingAddressesResponse GetAvailableShippingAddresses(GetAvailableShippingAddressesRequest getAvailableShippingAddressesRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(getAvailableShippingAddressesRequest.ToNVPString(string.Empty), ServiceName, "GetAvailableShippingAddresses", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetAvailableShippingAddressesResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetShippingAddressesResponse GetShippingAddresses(GetShippingAddressesRequest getShippingAddressesRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(getShippingAddressesRequest.ToNVPString(string.Empty), ServiceName, "GetShippingAddresses", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetShippingAddressesResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetShippingAddressesResponse GetShippingAddresses(GetShippingAddressesRequest getShippingAddressesRequest)
	 	{
	 		return GetShippingAddresses(getShippingAddressesRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public GetShippingAddressesResponse GetShippingAddresses(GetShippingAddressesRequest getShippingAddressesRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(getShippingAddressesRequest.ToNVPString(string.Empty), ServiceName, "GetShippingAddresses", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetShippingAddressesResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetUserLimitsResponse GetUserLimits(GetUserLimitsRequest getUserLimitsRequest, string apiUserName)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(getUserLimitsRequest.ToNVPString(string.Empty), ServiceName, "GetUserLimits", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetUserLimitsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetUserLimitsResponse GetUserLimits(GetUserLimitsRequest getUserLimitsRequest)
	 	{
	 		return GetUserLimits(getUserLimitsRequest,(string) null);
	 	}
	 	
	 	/**	
          *AUTO_GENERATED
	 	  */
	 	public GetUserLimitsResponse GetUserLimits(GetUserLimitsRequest getUserLimitsRequest, ICredential credential)
	 	{
	 		IAPICallPreHandler apiCallPreHandler = null;
			apiCallPreHandler = new PlatformAPICallPreHandler(getUserLimitsRequest.ToNVPString(string.Empty), ServiceName, "GetUserLimits", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			string response = Call(apiCallPreHandler);
			NVPUtil util = new NVPUtil();
			return GetUserLimitsResponse.CreateInstance(util.ParseNVPString(response), string.Empty, -1);
			
	 	}
	}
}
