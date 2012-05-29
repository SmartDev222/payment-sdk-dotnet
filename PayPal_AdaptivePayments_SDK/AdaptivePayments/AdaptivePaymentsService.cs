/** 
 * Auto generated code
 */

using PayPal.Authentication;

namespace PayPal.AdaptivePayments {

	using PayPal;
	using PayPal.Util;
	using PayPal.Manager;
	using PayPal.AdaptivePayments.Model;

	public partial class AdaptivePaymentsService : BasePayPalService{

		private static string serviceName = "AdaptivePayments";
		private static string serviceVersion = "1.8.0";

		public AdaptivePaymentsService() : base(serviceName, serviceVersion) {}
		/**
		 *
		 */
		public CancelPreapprovalResponse CancelPreapproval(CancelPreapprovalRequest CancelPreapprovalRequest, string apiUsername) 
		{
			string resp = call("CancelPreapproval", CancelPreapprovalRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new CancelPreapprovalResponse(util.parseNVPString(resp), "");
		}

		public CancelPreapprovalResponse CancelPreapproval(CancelPreapprovalRequest CancelPreapprovalRequest) 
		{
			return CancelPreapproval(CancelPreapprovalRequest, null);
		}
		/**
		 *
		 */
		public ConfirmPreapprovalResponse ConfirmPreapproval(ConfirmPreapprovalRequest ConfirmPreapprovalRequest, string apiUsername) 
		{
			string resp = call("ConfirmPreapproval", ConfirmPreapprovalRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new ConfirmPreapprovalResponse(util.parseNVPString(resp), "");
		}

		public ConfirmPreapprovalResponse ConfirmPreapproval(ConfirmPreapprovalRequest ConfirmPreapprovalRequest) 
		{
			return ConfirmPreapproval(ConfirmPreapprovalRequest, null);
		}
		/**
		 *
		 */
		public ConvertCurrencyResponse ConvertCurrency(ConvertCurrencyRequest ConvertCurrencyRequest, string apiUsername) 
		{
			string resp = call("ConvertCurrency", ConvertCurrencyRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new ConvertCurrencyResponse(util.parseNVPString(resp), "");
		}

		public ConvertCurrencyResponse ConvertCurrency(ConvertCurrencyRequest ConvertCurrencyRequest) 
		{
			return ConvertCurrency(ConvertCurrencyRequest, null);
		}
		/**
		 *
		 */
		public ExecutePaymentResponse ExecutePayment(ExecutePaymentRequest ExecutePaymentRequest, string apiUsername) 
		{
			string resp = call("ExecutePayment", ExecutePaymentRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new ExecutePaymentResponse(util.parseNVPString(resp), "");
		}

		public ExecutePaymentResponse ExecutePayment(ExecutePaymentRequest ExecutePaymentRequest) 
		{
			return ExecutePayment(ExecutePaymentRequest, null);
		}
		/**
		 *
		 */
		public GetAllowedFundingSourcesResponse GetAllowedFundingSources(GetAllowedFundingSourcesRequest GetAllowedFundingSourcesRequest, string apiUsername) 
		{
			string resp = call("GetAllowedFundingSources", GetAllowedFundingSourcesRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new GetAllowedFundingSourcesResponse(util.parseNVPString(resp), "");
		}

		public GetAllowedFundingSourcesResponse GetAllowedFundingSources(GetAllowedFundingSourcesRequest GetAllowedFundingSourcesRequest) 
		{
			return GetAllowedFundingSources(GetAllowedFundingSourcesRequest, null);
		}
		/**
		 *
		 */
		public GetPaymentOptionsResponse GetPaymentOptions(GetPaymentOptionsRequest GetPaymentOptionsRequest, string apiUsername) 
		{
			string resp = call("GetPaymentOptions", GetPaymentOptionsRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new GetPaymentOptionsResponse(util.parseNVPString(resp), "");
		}

		public GetPaymentOptionsResponse GetPaymentOptions(GetPaymentOptionsRequest GetPaymentOptionsRequest) 
		{
			return GetPaymentOptions(GetPaymentOptionsRequest, null);
		}
		/**
		 *
		 */
		public PaymentDetailsResponse PaymentDetails(PaymentDetailsRequest PaymentDetailsRequest, string apiUsername) 
		{
			string resp = call("PaymentDetails", PaymentDetailsRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new PaymentDetailsResponse(util.parseNVPString(resp), "");
		}

		public PaymentDetailsResponse PaymentDetails(PaymentDetailsRequest PaymentDetailsRequest) 
		{
			return PaymentDetails(PaymentDetailsRequest, null);
		}
		/**
		 *
		 */
		public PayResponse Pay(PayRequest PayRequest, string apiUsername) 
		{
			string resp = call("Pay", PayRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new PayResponse(util.parseNVPString(resp), "");
		}

		public PayResponse Pay(PayRequest PayRequest) 
		{
			return Pay(PayRequest, null);
		}
		/**
		 *
		 */
		public PreapprovalDetailsResponse PreapprovalDetails(PreapprovalDetailsRequest PreapprovalDetailsRequest, string apiUsername) 
		{
			string resp = call("PreapprovalDetails", PreapprovalDetailsRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new PreapprovalDetailsResponse(util.parseNVPString(resp), "");
		}

		public PreapprovalDetailsResponse PreapprovalDetails(PreapprovalDetailsRequest PreapprovalDetailsRequest) 
		{
			return PreapprovalDetails(PreapprovalDetailsRequest, null);
		}
		/**
		 *
		 */
		public PreapprovalResponse Preapproval(PreapprovalRequest PreapprovalRequest, string apiUsername) 
		{
			string resp = call("Preapproval", PreapprovalRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new PreapprovalResponse(util.parseNVPString(resp), "");
		}

		public PreapprovalResponse Preapproval(PreapprovalRequest PreapprovalRequest) 
		{
			return Preapproval(PreapprovalRequest, null);
		}
		/**
		 *
		 */
		public RefundResponse Refund(RefundRequest RefundRequest, string apiUsername) 
		{
			string resp = call("Refund", RefundRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new RefundResponse(util.parseNVPString(resp), "");
		}

		public RefundResponse Refund(RefundRequest RefundRequest) 
		{
			return Refund(RefundRequest, null);
		}
		/**
		 *
		 */
		public SetPaymentOptionsResponse SetPaymentOptions(SetPaymentOptionsRequest SetPaymentOptionsRequest, string apiUsername) 
		{
			string resp = call("SetPaymentOptions", SetPaymentOptionsRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new SetPaymentOptionsResponse(util.parseNVPString(resp), "");
		}

		public SetPaymentOptionsResponse SetPaymentOptions(SetPaymentOptionsRequest SetPaymentOptionsRequest) 
		{
			return SetPaymentOptions(SetPaymentOptionsRequest, null);
		}
		/**
		 *
		 */
		public GetFundingPlansResponse GetFundingPlans(GetFundingPlansRequest GetFundingPlansRequest, string apiUsername) 
		{
			string resp = call("GetFundingPlans", GetFundingPlansRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new GetFundingPlansResponse(util.parseNVPString(resp), "");
		}

		public GetFundingPlansResponse GetFundingPlans(GetFundingPlansRequest GetFundingPlansRequest) 
		{
			return GetFundingPlans(GetFundingPlansRequest, null);
		}
		/**
		 *
		 */
		public GetAvailableShippingAddressesResponse GetAvailableShippingAddresses(GetAvailableShippingAddressesRequest GetAvailableShippingAddressesRequest, string apiUsername) 
		{
			string resp = call("GetAvailableShippingAddresses", GetAvailableShippingAddressesRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new GetAvailableShippingAddressesResponse(util.parseNVPString(resp), "");
		}

		public GetAvailableShippingAddressesResponse GetAvailableShippingAddresses(GetAvailableShippingAddressesRequest GetAvailableShippingAddressesRequest) 
		{
			return GetAvailableShippingAddresses(GetAvailableShippingAddressesRequest, null);
		}
		/**
		 *
		 */
		public GetShippingAddressesResponse GetShippingAddresses(GetShippingAddressesRequest GetShippingAddressesRequest, string apiUsername) 
		{
			string resp = call("GetShippingAddresses", GetShippingAddressesRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new GetShippingAddressesResponse(util.parseNVPString(resp), "");
		}

		public GetShippingAddressesResponse GetShippingAddresses(GetShippingAddressesRequest GetShippingAddressesRequest) 
		{
			return GetShippingAddresses(GetShippingAddressesRequest, null);
		}
		/**
		 *
		 */
		public GetUserLimitsResponse GetUserLimits(GetUserLimitsRequest GetUserLimitsRequest, string apiUsername) 
		{
			string resp = call("GetUserLimits", GetUserLimitsRequest.toNVPString(""), apiUsername);

			NVPUtil util = new NVPUtil();
			return new GetUserLimitsResponse(util.parseNVPString(resp), "");
		}

		public GetUserLimitsResponse GetUserLimits(GetUserLimitsRequest GetUserLimitsRequest) 
		{
			return GetUserLimits(GetUserLimitsRequest, null);
		}
	}
}

