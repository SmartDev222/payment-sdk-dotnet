/**
  * Stub objects for AdaptivePayments 
  * AUTO_GENERATED_CODE 
  */
using System;
using System.Text;
using System.Web;
using System.Xml;
using System.Collections;
using System.ComponentModel;
using System.Collections.Generic;
using PayPal.Util;

namespace PayPal.AdaptivePayments.Model
{

	public class EnumUtils
	{
		public static string getDescription(Enum value)
		{
			string description = "";
			DescriptionAttribute[] attributes = (DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
			{
				description= attributes[0].Description;
			}
			return description;
		}
		
		public static object getValue(String value,Type enumType)
		{
			string[] names = Enum.GetNames(enumType);
			foreach(string name in names)
            {
            	if (getDescription((Enum)Enum.Parse(enumType, name)).Equals(value))
            	{
					return Enum.Parse(enumType, name);
				}
			}
			return null;
		}
	}


	/**
      *
      */
	public partial class AccountIdentifier	
	{

		/**
          *
		  */
		private string emailField;
		public string email
		{
			get
			{
				return this.emailField;
			}
			set
			{
				this.emailField = value;
			}
		}
		

		/**
          *
		  */
		private PhoneNumberType phoneField;
		public PhoneNumberType phone
		{
			get
			{
				return this.phoneField;
			}
			set
			{
				this.phoneField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public AccountIdentifier(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.email != null)
			{
					sb.Append(prefix).Append("email").Append("=").Append(HttpUtility.UrlEncode(this.email, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.phone != null)
			{
					string newPrefix = prefix + "phone" + ".";
					sb.Append(this.phoneField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}
		public AccountIdentifier(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "email";
			if(map.ContainsKey(key))
			{
				this.email = map[key];
			}
			key = prefix + "phone";
			if(map.ContainsKey(key + ".countryCode"))
			{
				this.phone = new PhoneNumberType(map, key + ".");
			}
		}
		
	}




	/**
      *
      */
	public partial class BaseAddress	
	{

		/**
          *
		  */
		private string line1Field;
		public string line1
		{
			get
			{
				return this.line1Field;
			}
			set
			{
				this.line1Field = value;
			}
		}
		

		/**
          *
		  */
		private string line2Field;
		public string line2
		{
			get
			{
				return this.line2Field;
			}
			set
			{
				this.line2Field = value;
			}
		}
		

		/**
          *
		  */
		private string cityField;
		public string city
		{
			get
			{
				return this.cityField;
			}
			set
			{
				this.cityField = value;
			}
		}
		

		/**
          *
		  */
		private string stateField;
		public string state
		{
			get
			{
				return this.stateField;
			}
			set
			{
				this.stateField = value;
			}
		}
		

		/**
          *
		  */
		private string postalCodeField;
		public string postalCode
		{
			get
			{
				return this.postalCodeField;
			}
			set
			{
				this.postalCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string countryCodeField;
		public string countryCode
		{
			get
			{
				return this.countryCodeField;
			}
			set
			{
				this.countryCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string typeField;
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public BaseAddress(){
		}


		public BaseAddress(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "line1";
			if(map.ContainsKey(key))
			{
				this.line1 = map[key];
			}
			key = prefix + "line2";
			if(map.ContainsKey(key))
			{
				this.line2 = map[key];
			}
			key = prefix + "city";
			if(map.ContainsKey(key))
			{
				this.city = map[key];
			}
			key = prefix + "state";
			if(map.ContainsKey(key))
			{
				this.state = map[key];
			}
			key = prefix + "postalCode";
			if(map.ContainsKey(key))
			{
				this.postalCode = map[key];
			}
			key = prefix + "countryCode";
			if(map.ContainsKey(key))
			{
				this.countryCode = map[key];
			}
			key = prefix + "type";
			if(map.ContainsKey(key))
			{
				this.type = map[key];
			}
		}
		
	}




	/**
      *Details about the end user of the application invoking this
      *service. 
      */
	public partial class ClientDetailsType	
	{

		/**
          *
		  */
		private string ipAddressField;
		public string ipAddress
		{
			get
			{
				return this.ipAddressField;
			}
			set
			{
				this.ipAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string deviceIdField;
		public string deviceId
		{
			get
			{
				return this.deviceIdField;
			}
			set
			{
				this.deviceIdField = value;
			}
		}
		

		/**
          *
		  */
		private string applicationIdField;
		public string applicationId
		{
			get
			{
				return this.applicationIdField;
			}
			set
			{
				this.applicationIdField = value;
			}
		}
		

		/**
          *
		  */
		private string modelField;
		public string model
		{
			get
			{
				return this.modelField;
			}
			set
			{
				this.modelField = value;
			}
		}
		

		/**
          *
		  */
		private string geoLocationField;
		public string geoLocation
		{
			get
			{
				return this.geoLocationField;
			}
			set
			{
				this.geoLocationField = value;
			}
		}
		

		/**
          *
		  */
		private string customerTypeField;
		public string customerType
		{
			get
			{
				return this.customerTypeField;
			}
			set
			{
				this.customerTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string partnerNameField;
		public string partnerName
		{
			get
			{
				return this.partnerNameField;
			}
			set
			{
				this.partnerNameField = value;
			}
		}
		

		/**
          *
		  */
		private string customerIdField;
		public string customerId
		{
			get
			{
				return this.customerIdField;
			}
			set
			{
				this.customerIdField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ClientDetailsType(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.ipAddress != null)
			{
					sb.Append(prefix).Append("ipAddress").Append("=").Append(HttpUtility.UrlEncode(this.ipAddress, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.deviceId != null)
			{
					sb.Append(prefix).Append("deviceId").Append("=").Append(HttpUtility.UrlEncode(this.deviceId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.applicationId != null)
			{
					sb.Append(prefix).Append("applicationId").Append("=").Append(HttpUtility.UrlEncode(this.applicationId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.model != null)
			{
					sb.Append(prefix).Append("model").Append("=").Append(HttpUtility.UrlEncode(this.model, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.geoLocation != null)
			{
					sb.Append(prefix).Append("geoLocation").Append("=").Append(HttpUtility.UrlEncode(this.geoLocation, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.customerType != null)
			{
					sb.Append(prefix).Append("customerType").Append("=").Append(HttpUtility.UrlEncode(this.customerType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.partnerName != null)
			{
					sb.Append(prefix).Append("partnerName").Append("=").Append(HttpUtility.UrlEncode(this.partnerName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.customerId != null)
			{
					sb.Append(prefix).Append("customerId").Append("=").Append(HttpUtility.UrlEncode(this.customerId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *
      */
	public partial class CurrencyType	
	{

		/**
          *
		  */
		private string codeField;
		public string code
		{
			get
			{
				return this.codeField;
			}
			set
			{
				this.codeField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? amountField;
		public decimal? amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public CurrencyType(string code, decimal? amount){
			this.code = code;
			this.amount = amount;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public CurrencyType(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.code != null)
			{
					sb.Append(prefix).Append("code").Append("=").Append(HttpUtility.UrlEncode(this.code, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.amount != null)
			{
					sb.Append(prefix).Append("amount").Append("=").Append(this.amount).Append("&");
			}
			return sb.ToString();
		}
		public CurrencyType(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "code";
			if(map.ContainsKey(key))
			{
				this.code = map[key];
			}
			key = prefix + "amount";
			if(map.ContainsKey(key))
			{
				this.amount = System.Convert.ToDecimal(map[key]);
			}
		}
		
	}




	/**
      *This type contains the detailed error information resulting
      *from the service operation. 
      */
	public partial class ErrorData	
	{

		/**
          *
		  */
		private int? errorIdField;
		public int? errorId
		{
			get
			{
				return this.errorIdField;
			}
			set
			{
				this.errorIdField = value;
			}
		}
		

		/**
          *
		  */
		private string domainField;
		public string domain
		{
			get
			{
				return this.domainField;
			}
			set
			{
				this.domainField = value;
			}
		}
		

		/**
          *
		  */
		private string subdomainField;
		public string subdomain
		{
			get
			{
				return this.subdomainField;
			}
			set
			{
				this.subdomainField = value;
			}
		}
		

		/**
          *
		  */
		private ErrorSeverity? severityField;
		public ErrorSeverity? severity
		{
			get
			{
				return this.severityField;
			}
			set
			{
				this.severityField = value;
			}
		}
		

		/**
          *
		  */
		private ErrorCategory? categoryField;
		public ErrorCategory? category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
			}
		}
		

		/**
          *
		  */
		private string messageField;
		public string message
		{
			get
			{
				return this.messageField;
			}
			set
			{
				this.messageField = value;
			}
		}
		

		/**
          *
		  */
		private string exceptionIdField;
		public string exceptionId
		{
			get
			{
				return this.exceptionIdField;
			}
			set
			{
				this.exceptionIdField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorParameter> parameterField = new List<ErrorParameter>();
		public List<ErrorParameter> parameter
		{
			get
			{
				return this.parameterField;
			}
			set
			{
				this.parameterField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ErrorData(){
		}


		public ErrorData(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "errorId";
			if(map.ContainsKey(key))
			{
				this.errorId = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "domain";
			if(map.ContainsKey(key))
			{
				this.domain = map[key];
			}
			key = prefix + "subdomain";
			if(map.ContainsKey(key))
			{
				this.subdomain = map[key];
			}
			key = prefix + "severity";
			if(map.ContainsKey(key))
			{
				this.severity = (ErrorSeverity)EnumUtils.getValue(map[key],typeof(ErrorSeverity));;
			}
			key = prefix + "category";
			if(map.ContainsKey(key))
			{
				this.category = (ErrorCategory)EnumUtils.getValue(map[key],typeof(ErrorCategory));;
			}
			key = prefix + "message";
			if(map.ContainsKey(key))
			{
				this.message = map[key];
			}
			key = prefix + "exceptionId";
			if(map.ContainsKey(key))
			{
				this.exceptionId = map[key];
			}
			i = 0;
			while(true){
				key = prefix + "parameter" + "(" + i + ")";
				if(map.ContainsKey(key))
				{
					this.parameter.Add(new ErrorParameter(map, key));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *
      */
	public partial class ErrorParameter	
	{

		/**
          *
		  */
		private string nameField;
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		

		/**
          *
		  */
		private string valueField;
		public string value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ErrorParameter(){
		}


		public ErrorParameter(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + ".name";
			if(map.ContainsKey(key))
			{
				this.name = map[key];
			}
			key = prefix ;
			if(map.ContainsKey(key))
			{
				this.value = map[key];
			}
		}
		
	}




	/**
      *This specifies a fault, encapsulating error data, with
      *specific error codes. 
      */
	public partial class FaultMessage	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public FaultMessage(){
		}


		public FaultMessage(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".errorId"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *
      */
	public partial class PhoneNumberType	
	{

		/**
          *
		  */
		private string countryCodeField;
		public string countryCode
		{
			get
			{
				return this.countryCodeField;
			}
			set
			{
				this.countryCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string phoneNumberField;
		public string phoneNumber
		{
			get
			{
				return this.phoneNumberField;
			}
			set
			{
				this.phoneNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string extensionField;
		public string extension
		{
			get
			{
				return this.extensionField;
			}
			set
			{
				this.extensionField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public PhoneNumberType(string countryCode, string phoneNumber){
			this.countryCode = countryCode;
			this.phoneNumber = phoneNumber;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public PhoneNumberType(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.countryCode != null)
			{
					sb.Append(prefix).Append("countryCode").Append("=").Append(HttpUtility.UrlEncode(this.countryCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.phoneNumber != null)
			{
					sb.Append(prefix).Append("phoneNumber").Append("=").Append(HttpUtility.UrlEncode(this.phoneNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.extension != null)
			{
					sb.Append(prefix).Append("extension").Append("=").Append(HttpUtility.UrlEncode(this.extension, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
		public PhoneNumberType(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "countryCode";
			if(map.ContainsKey(key))
			{
				this.countryCode = map[key];
			}
			key = prefix + "phoneNumber";
			if(map.ContainsKey(key))
			{
				this.phoneNumber = map[key];
			}
			key = prefix + "extension";
			if(map.ContainsKey(key))
			{
				this.extension = map[key];
			}
		}
		
	}




	/**
      *This specifies the list of parameters with every request to
      *the service. 
      */
	public partial class RequestEnvelope	
	{

		/**
          *
		  */
		private DetailLevelCode? detailLevelField;
		public DetailLevelCode? detailLevel
		{
			get
			{
				return this.detailLevelField;
			}
			set
			{
				this.detailLevelField = value;
			}
		}
		

		/**
          *
		  */
		private string errorLanguageField;
		public string errorLanguage
		{
			get
			{
				return this.errorLanguageField;
			}
			set
			{
				this.errorLanguageField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public RequestEnvelope(string errorLanguage){
			this.errorLanguage = errorLanguage;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public RequestEnvelope(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.detailLevel != null)
			{
					sb.Append(prefix).Append("detailLevel").Append("=").Append(EnumUtils.getDescription(detailLevel));
					sb.Append("&");
			}
			if (this.errorLanguage != null)
			{
					sb.Append(prefix).Append("errorLanguage").Append("=").Append(HttpUtility.UrlEncode(this.errorLanguage, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *This specifies a list of parameters with every response from
      *a service. 
      */
	public partial class ResponseEnvelope	
	{

		/**
          *
		  */
		private string timestampField;
		public string timestamp
		{
			get
			{
				return this.timestampField;
			}
			set
			{
				this.timestampField = value;
			}
		}
		

		/**
          *
		  */
		private AckCode? ackField;
		public AckCode? ack
		{
			get
			{
				return this.ackField;
			}
			set
			{
				this.ackField = value;
			}
		}
		

		/**
          *
		  */
		private string correlationIdField;
		public string correlationId
		{
			get
			{
				return this.correlationIdField;
			}
			set
			{
				this.correlationIdField = value;
			}
		}
		

		/**
          *
		  */
		private string buildField;
		public string build
		{
			get
			{
				return this.buildField;
			}
			set
			{
				this.buildField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ResponseEnvelope(){
		}


		public ResponseEnvelope(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "timestamp";
			if(map.ContainsKey(key))
			{
				this.timestamp = map[key];
			}
			key = prefix + "ack";
			if(map.ContainsKey(key))
			{
				this.ack = (AckCode)EnumUtils.getValue(map[key],typeof(AckCode));;
			}
			key = prefix + "correlationId";
			if(map.ContainsKey(key))
			{
				this.correlationId = map[key];
			}
			key = prefix + "build";
			if(map.ContainsKey(key))
			{
				this.build = map[key];
			}
		}
		
	}




	/**
      * AckCodeType This code identifies the
      * acknowledgment code types that could be used to
      * communicate the status of processing a (request)
      * message to an application. This code would be
      * used as part of a response message that contains
      * an application level acknowledgment element.
      * 
      */
	public enum AckCode {
		[Description("Success")]SUCCESS,	
		[Description("Failure")]FAILURE,	
		[Description("Warning")]WARNING,	
		[Description("SuccessWithWarning")]SUCCESSWITHWARNING,	
		[Description("FailureWithWarning")]FAILUREWITHWARNING	
	}




	/**
      *
      */
	public enum DayOfWeek {
		[Description("NO_DAY_SPECIFIED")]NODAYSPECIFIED,	
		[Description("SUNDAY")]SUNDAY,	
		[Description("MONDAY")]MONDAY,	
		[Description("TUESDAY")]TUESDAY,	
		[Description("WEDNESDAY")]WEDNESDAY,	
		[Description("THURSDAY")]THURSDAY,	
		[Description("FRIDAY")]FRIDAY,	
		[Description("SATURDAY")]SATURDAY	
	}




	/**
      * DetailLevelCodeType
      * 
      */
	public enum DetailLevelCode {
		[Description("ReturnAll")]RETURNALL	
	}




	/**
      *
      */
	public enum ErrorCategory {
		[Description("System")]SYSTEM,	
		[Description("Application")]APPLICATION,	
		[Description("Request")]REQUEST	
	}




	/**
      *
      */
	public enum ErrorSeverity {
		[Description("Error")]ERROR,	
		[Description("Warning")]WARNING	
	}




	/**
      *
      */
	public partial class Address	
	{

		/**
          *
		  */
		private string addresseeNameField;
		public string addresseeName
		{
			get
			{
				return this.addresseeNameField;
			}
			set
			{
				this.addresseeNameField = value;
			}
		}
		

		/**
          *
		  */
		private BaseAddress baseAddressField;
		public BaseAddress baseAddress
		{
			get
			{
				return this.baseAddressField;
			}
			set
			{
				this.baseAddressField = value;
			}
		}
		

		/**
          *
		  */
		private string addressIdField;
		public string addressId
		{
			get
			{
				return this.addressIdField;
			}
			set
			{
				this.addressIdField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public Address(){
		}


		public Address(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "addresseeName";
			if(map.ContainsKey(key))
			{
				this.addresseeName = map[key];
			}
			key = prefix + "baseAddress";
			if(map.ContainsKey(key + ".line1"))
			{
				this.baseAddress = new BaseAddress(map, key + ".");
			}
			key = prefix + "addressId";
			if(map.ContainsKey(key))
			{
				this.addressId = map[key];
			}
		}
		
	}




	/**
      *
      */
	public partial class AddressList	
	{

		/**
          *
		  */
		private List<Address> addressField = new List<Address>();
		public List<Address> address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public AddressList(){
		}


		public AddressList(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			i = 0;
			while(true){
				key = prefix + "address" + "(" + i + ")";
				if(map.ContainsKey(key + ".baseAddress.line1"))
				{
					this.address.Add(new Address(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *A list of ISO currency codes. 
      */
	public partial class CurrencyCodeList	
	{

		/**
          *
		  */
		private List<string> currencyCodeField = new List<string>();
		public List<string> currencyCode
		{
			get
			{
				return this.currencyCodeField;
			}
			set
			{
				this.currencyCodeField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public CurrencyCodeList(List<string> currencyCode){
			this.currencyCode = currencyCode;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public CurrencyCodeList(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < this.currencyCode.Count; i++)
			{
				if (this.currencyCode[i] != null)
				{
					sb.Append(prefix).Append("currencyCode").Append("(").Append(i).Append(")").Append("=").Append(HttpUtility.UrlEncode(this.currencyCode[i], BaseConstants.ENCODING_FORMAT)).Append("&");
				}
			}
			return sb.ToString();
		}
	}




	/**
      *A list of estimated currency conversions for a base
      *currency. 
      */
	public partial class CurrencyConversionList	
	{

		/**
          *
		  */
		private CurrencyType baseAmountField;
		public CurrencyType baseAmount
		{
			get
			{
				return this.baseAmountField;
			}
			set
			{
				this.baseAmountField = value;
			}
		}
		

		/**
          *
		  */
		private CurrencyList currencyListField;
		public CurrencyList currencyList
		{
			get
			{
				return this.currencyListField;
			}
			set
			{
				this.currencyListField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CurrencyConversionList(){
		}


		public CurrencyConversionList(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "baseAmount";
			if(map.ContainsKey(key + ".code"))
			{
				this.baseAmount = new CurrencyType(map, key + ".");
			}
			key = prefix + "currencyList";
			if(map.ContainsKey(key + ".currency(0).code"))
			{
				this.currencyList = new CurrencyList(map, key + ".");
			}
		}
		
	}




	/**
      *A table that contains a list of estimated currency
      *conversions for a base currency in each row. 
      */
	public partial class CurrencyConversionTable	
	{

		/**
          *
		  */
		private List<CurrencyConversionList> currencyConversionListField = new List<CurrencyConversionList>();
		public List<CurrencyConversionList> currencyConversionList
		{
			get
			{
				return this.currencyConversionListField;
			}
			set
			{
				this.currencyConversionListField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CurrencyConversionTable(){
		}


		public CurrencyConversionTable(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			i = 0;
			while(true){
				key = prefix + "currencyConversionList" + "(" + i + ")";
				if(map.ContainsKey(key + ".baseAmount.code"))
				{
					this.currencyConversionList.Add(new CurrencyConversionList(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *A list of ISO currencies. 
      */
	public partial class CurrencyList	
	{

		/**
          *
		  */
		private List<CurrencyType> currencyField = new List<CurrencyType>();
		public List<CurrencyType> currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.currencyField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public CurrencyList(List<CurrencyType> currency){
			this.currency = currency;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public CurrencyList(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < this.currency.Count; i++)
			{
				if (this.currency[i] != null)
				{
					string newPrefix = prefix + "currency" + "(" + i + ").";
					sb.Append(this.currency[i].toNVPString(newPrefix));
				}
			}
			return sb.ToString();
		}
		public CurrencyList(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			i = 0;
			while(true){
				key = prefix + "currency" + "(" + i + ")";
				if(map.ContainsKey(key + ".code"))
				{
					this.currency.Add(new CurrencyType(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *Customizable options that a client application can specify
      *for display purposes. 
      */
	public partial class DisplayOptions	
	{

		/**
          *
		  */
		private string emailHeaderImageUrlField;
		public string emailHeaderImageUrl
		{
			get
			{
				return this.emailHeaderImageUrlField;
			}
			set
			{
				this.emailHeaderImageUrlField = value;
			}
		}
		

		/**
          *
		  */
		private string emailMarketingImageUrlField;
		public string emailMarketingImageUrl
		{
			get
			{
				return this.emailMarketingImageUrlField;
			}
			set
			{
				this.emailMarketingImageUrlField = value;
			}
		}
		

		/**
          *
		  */
		private string headerImageUrlField;
		public string headerImageUrl
		{
			get
			{
				return this.headerImageUrlField;
			}
			set
			{
				this.headerImageUrlField = value;
			}
		}
		

		/**
          *
		  */
		private string businessNameField;
		public string businessName
		{
			get
			{
				return this.businessNameField;
			}
			set
			{
				this.businessNameField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public DisplayOptions(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.emailHeaderImageUrl != null)
			{
					sb.Append(prefix).Append("emailHeaderImageUrl").Append("=").Append(HttpUtility.UrlEncode(this.emailHeaderImageUrl, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.emailMarketingImageUrl != null)
			{
					sb.Append(prefix).Append("emailMarketingImageUrl").Append("=").Append(HttpUtility.UrlEncode(this.emailMarketingImageUrl, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.headerImageUrl != null)
			{
					sb.Append(prefix).Append("headerImageUrl").Append("=").Append(HttpUtility.UrlEncode(this.headerImageUrl, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.businessName != null)
			{
					sb.Append(prefix).Append("businessName").Append("=").Append(HttpUtility.UrlEncode(this.businessName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
		public DisplayOptions(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "emailHeaderImageUrl";
			if(map.ContainsKey(key))
			{
				this.emailHeaderImageUrl = map[key];
			}
			key = prefix + "emailMarketingImageUrl";
			if(map.ContainsKey(key))
			{
				this.emailMarketingImageUrl = map[key];
			}
			key = prefix + "headerImageUrl";
			if(map.ContainsKey(key))
			{
				this.headerImageUrl = map[key];
			}
			key = prefix + "businessName";
			if(map.ContainsKey(key))
			{
				this.businessName = map[key];
			}
		}
		
	}




	/**
      *
      */
	public partial class ErrorList	
	{

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ErrorList(){
		}


		public ErrorList(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".errorId"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *
      */
	public partial class FundingConstraint	
	{

		/**
          *
		  */
		private FundingTypeList allowedFundingTypeField;
		public FundingTypeList allowedFundingType
		{
			get
			{
				return this.allowedFundingTypeField;
			}
			set
			{
				this.allowedFundingTypeField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public FundingConstraint(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.allowedFundingType != null)
			{
					string newPrefix = prefix + "allowedFundingType" + ".";
					sb.Append(this.allowedFundingTypeField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}
		public FundingConstraint(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "allowedFundingType";
			if(map.ContainsKey(key + ".fundingTypeInfo(0).fundingType"))
			{
				this.allowedFundingType = new FundingTypeList(map, key + ".");
			}
		}
		
	}




	/**
      *FundingTypeInfo represents one allowed funding type. 
      */
	public partial class FundingTypeInfo	
	{

		/**
          *
		  */
		private string fundingTypeField;
		public string fundingType
		{
			get
			{
				return this.fundingTypeField;
			}
			set
			{
				this.fundingTypeField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public FundingTypeInfo(string fundingType){
			this.fundingType = fundingType;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public FundingTypeInfo(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.fundingType != null)
			{
					sb.Append(prefix).Append("fundingType").Append("=").Append(HttpUtility.UrlEncode(this.fundingType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
		public FundingTypeInfo(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "fundingType";
			if(map.ContainsKey(key))
			{
				this.fundingType = map[key];
			}
		}
		
	}




	/**
      *
      */
	public partial class FundingTypeList	
	{

		/**
          *
		  */
		private List<FundingTypeInfo> fundingTypeInfoField = new List<FundingTypeInfo>();
		public List<FundingTypeInfo> fundingTypeInfo
		{
			get
			{
				return this.fundingTypeInfoField;
			}
			set
			{
				this.fundingTypeInfoField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public FundingTypeList(List<FundingTypeInfo> fundingTypeInfo){
			this.fundingTypeInfo = fundingTypeInfo;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public FundingTypeList(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < this.fundingTypeInfo.Count; i++)
			{
				if (this.fundingTypeInfo[i] != null)
				{
					string newPrefix = prefix + "fundingTypeInfo" + "(" + i + ").";
					sb.Append(this.fundingTypeInfo[i].toNVPString(newPrefix));
				}
			}
			return sb.ToString();
		}
		public FundingTypeList(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			i = 0;
			while(true){
				key = prefix + "fundingTypeInfo" + "(" + i + ")";
				if(map.ContainsKey(key+".fundingType"))
				{
					this.fundingTypeInfo.Add(new FundingTypeInfo(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *Describes the conversion between 2 currencies. 
      */
	public partial class CurrencyConversion	
	{

		/**
          *
		  */
		private CurrencyType fromField;
		public CurrencyType from
		{
			get
			{
				return this.fromField;
			}
			set
			{
				this.fromField = value;
			}
		}
		

		/**
          *
		  */
		private CurrencyType toField;
		public CurrencyType to
		{
			get
			{
				return this.toField;
			}
			set
			{
				this.toField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? exchangeRateField;
		public decimal? exchangeRate
		{
			get
			{
				return this.exchangeRateField;
			}
			set
			{
				this.exchangeRateField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CurrencyConversion(){
		}


		public CurrencyConversion(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "from";
			if(map.ContainsKey(key + ".code"))
			{
				this.from = new CurrencyType(map, key + ".");
			}
			key = prefix + "to";
			if(map.ContainsKey(key + ".code"))
			{
				this.to = new CurrencyType(map, key + ".");
			}
			key = prefix + "exchangeRate";
			if(map.ContainsKey(key))
			{
				this.exchangeRate = System.Convert.ToDecimal(map[key]);
			}
		}
		
	}




	/**
      *Funding source information. 
      */
	public partial class FundingSource	
	{

		/**
          *
		  */
		private string lastFourOfAccountNumberField;
		public string lastFourOfAccountNumber
		{
			get
			{
				return this.lastFourOfAccountNumberField;
			}
			set
			{
				this.lastFourOfAccountNumberField = value;
			}
		}
		

		/**
          *
		  */
		private string typeField;
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}
		

		/**
          *
		  */
		private string displayNameField;
		public string displayName
		{
			get
			{
				return this.displayNameField;
			}
			set
			{
				this.displayNameField = value;
			}
		}
		

		/**
          *
		  */
		private string fundingSourceIdField;
		public string fundingSourceId
		{
			get
			{
				return this.fundingSourceIdField;
			}
			set
			{
				this.fundingSourceIdField = value;
			}
		}
		

		/**
          *
		  */
		private bool? allowedField;
		public bool? allowed
		{
			get
			{
				return this.allowedField;
			}
			set
			{
				this.allowedField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public FundingSource(){
		}


		public FundingSource(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "lastFourOfAccountNumber";
			if(map.ContainsKey(key))
			{
				this.lastFourOfAccountNumber = map[key];
			}
			key = prefix + "type";
			if(map.ContainsKey(key))
			{
				this.type = map[key];
			}
			key = prefix + "displayName";
			if(map.ContainsKey(key))
			{
				this.displayName = map[key];
			}
			key = prefix + "fundingSourceId";
			if(map.ContainsKey(key))
			{
				this.fundingSourceId = map[key];
			}
			key = prefix + "allowed";
			if(map.ContainsKey(key))
			{
				this.allowed = System.Convert.ToBoolean(map[key]);
			}
		}
		
	}




	/**
      *Amount to be charged to a particular funding source. 
      */
	public partial class FundingPlanCharge	
	{

		/**
          *
		  */
		private CurrencyType chargeField;
		public CurrencyType charge
		{
			get
			{
				return this.chargeField;
			}
			set
			{
				this.chargeField = value;
			}
		}
		

		/**
          *
		  */
		private FundingSource fundingSourceField;
		public FundingSource fundingSource
		{
			get
			{
				return this.fundingSourceField;
			}
			set
			{
				this.fundingSourceField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public FundingPlanCharge(){
		}


		public FundingPlanCharge(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "charge";
			if(map.ContainsKey(key + ".code"))
			{
				this.charge = new CurrencyType(map, key + ".");
			}
			key = prefix + "fundingSource";
			if(map.ContainsKey(key + ".type"))
			{
				this.fundingSource = new FundingSource(map, key + ".");
			}
		}
		
	}




	/**
      *FundingPlan describes the funding sources to be used for a
      *specific payment. 
      */
	public partial class FundingPlan	
	{

		/**
          *
		  */
		private string fundingPlanIdField;
		public string fundingPlanId
		{
			get
			{
				return this.fundingPlanIdField;
			}
			set
			{
				this.fundingPlanIdField = value;
			}
		}
		

		/**
          *
		  */
		private CurrencyType fundingAmountField;
		public CurrencyType fundingAmount
		{
			get
			{
				return this.fundingAmountField;
			}
			set
			{
				this.fundingAmountField = value;
			}
		}
		

		/**
          *
		  */
		private FundingSource backupFundingSourceField;
		public FundingSource backupFundingSource
		{
			get
			{
				return this.backupFundingSourceField;
			}
			set
			{
				this.backupFundingSourceField = value;
			}
		}
		

		/**
          *
		  */
		private CurrencyType senderFeesField;
		public CurrencyType senderFees
		{
			get
			{
				return this.senderFeesField;
			}
			set
			{
				this.senderFeesField = value;
			}
		}
		

		/**
          *
		  */
		private CurrencyConversion currencyConversionField;
		public CurrencyConversion currencyConversion
		{
			get
			{
				return this.currencyConversionField;
			}
			set
			{
				this.currencyConversionField = value;
			}
		}
		

		/**
          *
		  */
		private List<FundingPlanCharge> chargeField = new List<FundingPlanCharge>();
		public List<FundingPlanCharge> charge
		{
			get
			{
				return this.chargeField;
			}
			set
			{
				this.chargeField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public FundingPlan(){
		}


		public FundingPlan(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "fundingPlanId";
			if(map.ContainsKey(key))
			{
				this.fundingPlanId = map[key];
			}
			key = prefix + "fundingAmount";
			if(map.ContainsKey(key + ".code"))
			{
				this.fundingAmount = new CurrencyType(map, key + ".");
			}
			key = prefix + "backupFundingSource";
			if(map.ContainsKey(key + ".type"))
			{
				this.backupFundingSource = new FundingSource(map, key + ".");
			}
			key = prefix + "senderFees";
			if(map.ContainsKey(key + ".code"))
			{
				this.senderFees = new CurrencyType(map, key + ".");
			}
			key = prefix + "currencyConversion";
			if(map.ContainsKey(key + ".from.code"))
			{
				this.currencyConversion = new CurrencyConversion(map, key + ".");
			}
			i = 0;
			while(true){
				key = prefix + "charge" + "(" + i + ")";
				if(map.ContainsKey(key + ".charge.code"))
				{
					this.charge.Add(new FundingPlanCharge(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *Details about the party that initiated this payment. The API
      *user is making this payment on behalf of the initiator. The
      *initiator can simply be an institution or a customer of the
      *institution. 
      */
	public partial class InitiatingEntity	
	{

		/**
          *
		  */
		private InstitutionCustomer institutionCustomerField;
		public InstitutionCustomer institutionCustomer
		{
			get
			{
				return this.institutionCustomerField;
			}
			set
			{
				this.institutionCustomerField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public InitiatingEntity(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.institutionCustomer != null)
			{
					string newPrefix = prefix + "institutionCustomer" + ".";
					sb.Append(this.institutionCustomerField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}
		public InitiatingEntity(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "institutionCustomer";
			if(map.ContainsKey(key + ".institutionId"))
			{
				this.institutionCustomer = new InstitutionCustomer(map, key + ".");
			}
		}
		
	}




	/**
      *The customer of the initiating institution 
      */
	public partial class InstitutionCustomer	
	{

		/**
          *
		  */
		private string institutionIdField;
		public string institutionId
		{
			get
			{
				return this.institutionIdField;
			}
			set
			{
				this.institutionIdField = value;
			}
		}
		

		/**
          *
		  */
		private string firstNameField;
		public string firstName
		{
			get
			{
				return this.firstNameField;
			}
			set
			{
				this.firstNameField = value;
			}
		}
		

		/**
          *
		  */
		private string lastNameField;
		public string lastName
		{
			get
			{
				return this.lastNameField;
			}
			set
			{
				this.lastNameField = value;
			}
		}
		

		/**
          *
		  */
		private string displayNameField;
		public string displayName
		{
			get
			{
				return this.displayNameField;
			}
			set
			{
				this.displayNameField = value;
			}
		}
		

		/**
          *
		  */
		private string institutionCustomerIdField;
		public string institutionCustomerId
		{
			get
			{
				return this.institutionCustomerIdField;
			}
			set
			{
				this.institutionCustomerIdField = value;
			}
		}
		

		/**
          *
		  */
		private string countryCodeField;
		public string countryCode
		{
			get
			{
				return this.countryCodeField;
			}
			set
			{
				this.countryCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string emailField;
		public string email
		{
			get
			{
				return this.emailField;
			}
			set
			{
				this.emailField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public InstitutionCustomer(string institutionId, string firstName, string lastName, string displayName, string institutionCustomerId, string countryCode){
			this.institutionId = institutionId;
			this.firstName = firstName;
			this.lastName = lastName;
			this.displayName = displayName;
			this.institutionCustomerId = institutionCustomerId;
			this.countryCode = countryCode;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public InstitutionCustomer(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.institutionId != null)
			{
					sb.Append(prefix).Append("institutionId").Append("=").Append(HttpUtility.UrlEncode(this.institutionId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.firstName != null)
			{
					sb.Append(prefix).Append("firstName").Append("=").Append(HttpUtility.UrlEncode(this.firstName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.lastName != null)
			{
					sb.Append(prefix).Append("lastName").Append("=").Append(HttpUtility.UrlEncode(this.lastName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.displayName != null)
			{
					sb.Append(prefix).Append("displayName").Append("=").Append(HttpUtility.UrlEncode(this.displayName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.institutionCustomerId != null)
			{
					sb.Append(prefix).Append("institutionCustomerId").Append("=").Append(HttpUtility.UrlEncode(this.institutionCustomerId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.countryCode != null)
			{
					sb.Append(prefix).Append("countryCode").Append("=").Append(HttpUtility.UrlEncode(this.countryCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.email != null)
			{
					sb.Append(prefix).Append("email").Append("=").Append(HttpUtility.UrlEncode(this.email, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
		public InstitutionCustomer(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "institutionId";
			if(map.ContainsKey(key))
			{
				this.institutionId = map[key];
			}
			key = prefix + "firstName";
			if(map.ContainsKey(key))
			{
				this.firstName = map[key];
			}
			key = prefix + "lastName";
			if(map.ContainsKey(key))
			{
				this.lastName = map[key];
			}
			key = prefix + "displayName";
			if(map.ContainsKey(key))
			{
				this.displayName = map[key];
			}
			key = prefix + "institutionCustomerId";
			if(map.ContainsKey(key))
			{
				this.institutionCustomerId = map[key];
			}
			key = prefix + "countryCode";
			if(map.ContainsKey(key))
			{
				this.countryCode = map[key];
			}
			key = prefix + "email";
			if(map.ContainsKey(key))
			{
				this.email = map[key];
			}
		}
		
	}




	/**
      *Describes an individual item for an invoice. 
      */
	public partial class InvoiceItem	
	{

		/**
          *
		  */
		private string nameField;
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		

		/**
          *
		  */
		private string identifierField;
		public string identifier
		{
			get
			{
				return this.identifierField;
			}
			set
			{
				this.identifierField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? priceField;
		public decimal? price
		{
			get
			{
				return this.priceField;
			}
			set
			{
				this.priceField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? itemPriceField;
		public decimal? itemPrice
		{
			get
			{
				return this.itemPriceField;
			}
			set
			{
				this.itemPriceField = value;
			}
		}
		

		/**
          *
		  */
		private int? itemCountField;
		public int? itemCount
		{
			get
			{
				return this.itemCountField;
			}
			set
			{
				this.itemCountField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public InvoiceItem(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.name != null)
			{
					sb.Append(prefix).Append("name").Append("=").Append(HttpUtility.UrlEncode(this.name, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.identifier != null)
			{
					sb.Append(prefix).Append("identifier").Append("=").Append(HttpUtility.UrlEncode(this.identifier, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.price != null)
			{
					sb.Append(prefix).Append("price").Append("=").Append(this.price).Append("&");
			}
			if (this.itemPrice != null)
			{
					sb.Append(prefix).Append("itemPrice").Append("=").Append(this.itemPrice).Append("&");
			}
			if (this.itemCount != null)
			{
					sb.Append(prefix).Append("itemCount").Append("=").Append(this.itemCount).Append("&");
			}
			return sb.ToString();
		}
		public InvoiceItem(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "name";
			if(map.ContainsKey(key))
			{
				this.name = map[key];
			}
			key = prefix + "identifier";
			if(map.ContainsKey(key))
			{
				this.identifier = map[key];
			}
			key = prefix + "price";
			if(map.ContainsKey(key))
			{
				this.price = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "itemPrice";
			if(map.ContainsKey(key))
			{
				this.itemPrice = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "itemCount";
			if(map.ContainsKey(key))
			{
				this.itemCount = System.Convert.ToInt32(map[key]);
			}
		}
		
	}




	/**
      *Describes a payment for a particular receiver (merchant),
      *contains list of additional per item details. 
      */
	public partial class InvoiceData	
	{

		/**
          *
		  */
		private List<InvoiceItem> itemField = new List<InvoiceItem>();
		public List<InvoiceItem> item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? totalTaxField;
		public decimal? totalTax
		{
			get
			{
				return this.totalTaxField;
			}
			set
			{
				this.totalTaxField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? totalShippingField;
		public decimal? totalShipping
		{
			get
			{
				return this.totalShippingField;
			}
			set
			{
				this.totalShippingField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public InvoiceData(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < this.item.Count; i++)
			{
				if (this.item[i] != null)
				{
					string newPrefix = prefix + "item" + "(" + i + ").";
					sb.Append(this.item[i].toNVPString(newPrefix));
				}
			}
			if (this.totalTax != null)
			{
					sb.Append(prefix).Append("totalTax").Append("=").Append(this.totalTax).Append("&");
			}
			if (this.totalShipping != null)
			{
					sb.Append(prefix).Append("totalShipping").Append("=").Append(this.totalShipping).Append("&");
			}
			return sb.ToString();
		}
		public InvoiceData(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			i = 0;
			while(true){
				key = prefix + "item" + "(" + i + ")";
				if(map.ContainsKey(key+".name"))
				{
					this.item.Add(new InvoiceItem(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
			key = prefix + "totalTax";
			if(map.ContainsKey(key))
			{
				this.totalTax = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "totalShipping";
			if(map.ContainsKey(key))
			{
				this.totalShipping = System.Convert.ToDecimal(map[key]);
			}
		}
		
	}




	/**
      *The error that resulted from an attempt to make a payment to
      *a receiver. 
      */
	public partial class PayError	
	{

		/**
          *
		  */
		private Receiver receiverField;
		public Receiver receiver
		{
			get
			{
				return this.receiverField;
			}
			set
			{
				this.receiverField = value;
			}
		}
		

		/**
          *
		  */
		private ErrorData errorField;
		public ErrorData error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PayError(){
		}


		public PayError(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "receiver";
			if(map.ContainsKey(key + ".amount"))
			{
				this.receiver = new Receiver(map, key + ".");
			}
			key = prefix + "error";
			if(map.ContainsKey(key + ".errorId"))
			{
				this.error = new ErrorData(map, key + ".");
			}
		}
		
	}




	/**
      *
      */
	public partial class PayErrorList	
	{

		/**
          *
		  */
		private List<PayError> payErrorField = new List<PayError>();
		public List<PayError> payError
		{
			get
			{
				return this.payErrorField;
			}
			set
			{
				this.payErrorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PayErrorList(){
		}


		public PayErrorList(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			i = 0;
			while(true){
				key = prefix + "payError" + "(" + i + ")";
				if(map.ContainsKey(key + ".receiver.amount"))
				{
					this.payError.Add(new PayError(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *PaymentInfo represents the payment attempt made to a
      *Receiver of a PayRequest. If the execution of the payment
      *has not yet completed, there will not be any transaction
      *details. 
      */
	public partial class PaymentInfo	
	{

		/**
          *
		  */
		private string transactionIdField;
		public string transactionId
		{
			get
			{
				return this.transactionIdField;
			}
			set
			{
				this.transactionIdField = value;
			}
		}
		

		/**
          *
		  */
		private string transactionStatusField;
		public string transactionStatus
		{
			get
			{
				return this.transactionStatusField;
			}
			set
			{
				this.transactionStatusField = value;
			}
		}
		

		/**
          *
		  */
		private Receiver receiverField;
		public Receiver receiver
		{
			get
			{
				return this.receiverField;
			}
			set
			{
				this.receiverField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? refundedAmountField;
		public decimal? refundedAmount
		{
			get
			{
				return this.refundedAmountField;
			}
			set
			{
				this.refundedAmountField = value;
			}
		}
		

		/**
          *
		  */
		private bool? pendingRefundField;
		public bool? pendingRefund
		{
			get
			{
				return this.pendingRefundField;
			}
			set
			{
				this.pendingRefundField = value;
			}
		}
		

		/**
          *
		  */
		private string senderTransactionIdField;
		public string senderTransactionId
		{
			get
			{
				return this.senderTransactionIdField;
			}
			set
			{
				this.senderTransactionIdField = value;
			}
		}
		

		/**
          *
		  */
		private string senderTransactionStatusField;
		public string senderTransactionStatus
		{
			get
			{
				return this.senderTransactionStatusField;
			}
			set
			{
				this.senderTransactionStatusField = value;
			}
		}
		

		/**
          *
		  */
		private string pendingReasonField;
		public string pendingReason
		{
			get
			{
				return this.pendingReasonField;
			}
			set
			{
				this.pendingReasonField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PaymentInfo(){
		}


		public PaymentInfo(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "transactionId";
			if(map.ContainsKey(key))
			{
				this.transactionId = map[key];
			}
			key = prefix + "transactionStatus";
			if(map.ContainsKey(key))
			{
				this.transactionStatus = map[key];
			}
			key = prefix + "receiver";
			if(map.ContainsKey(key + ".amount"))
			{
				this.receiver = new Receiver(map, key + ".");
			}
			key = prefix + "refundedAmount";
			if(map.ContainsKey(key))
			{
				this.refundedAmount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "pendingRefund";
			if(map.ContainsKey(key))
			{
				this.pendingRefund = System.Convert.ToBoolean(map[key]);
			}
			key = prefix + "senderTransactionId";
			if(map.ContainsKey(key))
			{
				this.senderTransactionId = map[key];
			}
			key = prefix + "senderTransactionStatus";
			if(map.ContainsKey(key))
			{
				this.senderTransactionStatus = map[key];
			}
			key = prefix + "pendingReason";
			if(map.ContainsKey(key))
			{
				this.pendingReason = map[key];
			}
		}
		
	}




	/**
      *
      */
	public partial class PaymentInfoList	
	{

		/**
          *
		  */
		private List<PaymentInfo> paymentInfoField = new List<PaymentInfo>();
		public List<PaymentInfo> paymentInfo
		{
			get
			{
				return this.paymentInfoField;
			}
			set
			{
				this.paymentInfoField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PaymentInfoList(){
		}


		public PaymentInfoList(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			i = 0;
			while(true){
				key = prefix + "paymentInfo" + "(" + i + ")";
				if(map.ContainsKey(key + ".receiver.amount"))
				{
					this.paymentInfo.Add(new PaymentInfo(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *Receiver is the party where funds are transferred to. A
      *primary receiver receives a payment directly from the sender
      *in a chained split payment. A primary receiver should not be
      *specified when making a single or parallel split payment. 
      */
	public partial class Receiver	
	{

		/**
          *
		  */
		private decimal? amountField;
		public decimal? amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		

		/**
          *
		  */
		private string emailField;
		public string email
		{
			get
			{
				return this.emailField;
			}
			set
			{
				this.emailField = value;
			}
		}
		

		/**
          *
		  */
		private PhoneNumberType phoneField;
		public PhoneNumberType phone
		{
			get
			{
				return this.phoneField;
			}
			set
			{
				this.phoneField = value;
			}
		}
		

		/**
          *
		  */
		private bool? primaryField;
		public bool? primary
		{
			get
			{
				return this.primaryField;
			}
			set
			{
				this.primaryField = value;
			}
		}
		

		/**
          *
		  */
		private string invoiceIdField;
		public string invoiceId
		{
			get
			{
				return this.invoiceIdField;
			}
			set
			{
				this.invoiceIdField = value;
			}
		}
		

		/**
          *
		  */
		private string paymentTypeField;
		public string paymentType
		{
			get
			{
				return this.paymentTypeField;
			}
			set
			{
				this.paymentTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string paymentSubTypeField;
		public string paymentSubType
		{
			get
			{
				return this.paymentSubTypeField;
			}
			set
			{
				this.paymentSubTypeField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public Receiver(decimal? amount){
			this.amount = amount;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public Receiver(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.amount != null)
			{
					sb.Append(prefix).Append("amount").Append("=").Append(this.amount).Append("&");
			}
			if (this.email != null)
			{
					sb.Append(prefix).Append("email").Append("=").Append(HttpUtility.UrlEncode(this.email, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.phone != null)
			{
					string newPrefix = prefix + "phone" + ".";
					sb.Append(this.phoneField.toNVPString(newPrefix));
			}
			if (this.primary != null)
			{
					sb.Append(prefix).Append("primary").Append("=").Append(this.primary).Append("&");
			}
			if (this.invoiceId != null)
			{
					sb.Append(prefix).Append("invoiceId").Append("=").Append(HttpUtility.UrlEncode(this.invoiceId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.paymentType != null)
			{
					sb.Append(prefix).Append("paymentType").Append("=").Append(HttpUtility.UrlEncode(this.paymentType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.paymentSubType != null)
			{
					sb.Append(prefix).Append("paymentSubType").Append("=").Append(HttpUtility.UrlEncode(this.paymentSubType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
		public Receiver(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "amount";
			if(map.ContainsKey(key))
			{
				this.amount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "email";
			if(map.ContainsKey(key))
			{
				this.email = map[key];
			}
			key = prefix + "phone";
			if(map.ContainsKey(key + ".countryCode"))
			{
				this.phone = new PhoneNumberType(map, key + ".");
			}
			key = prefix + "primary";
			if(map.ContainsKey(key))
			{
				this.primary = System.Convert.ToBoolean(map[key]);
			}
			key = prefix + "invoiceId";
			if(map.ContainsKey(key))
			{
				this.invoiceId = map[key];
			}
			key = prefix + "paymentType";
			if(map.ContainsKey(key))
			{
				this.paymentType = map[key];
			}
			key = prefix + "paymentSubType";
			if(map.ContainsKey(key))
			{
				this.paymentSubType = map[key];
			}
		}
		
	}




	/**
      *
      */
	public partial class ReceiverList	
	{

		/**
          *
		  */
		private List<Receiver> receiverField = new List<Receiver>();
		public List<Receiver> receiver
		{
			get
			{
				return this.receiverField;
			}
			set
			{
				this.receiverField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public ReceiverList(List<Receiver> receiver){
			this.receiver = receiver;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public ReceiverList(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < this.receiver.Count; i++)
			{
				if (this.receiver[i] != null)
				{
					string newPrefix = prefix + "receiver" + "(" + i + ").";
					sb.Append(this.receiver[i].toNVPString(newPrefix));
				}
			}
			return sb.ToString();
		}
	}




	/**
      *The sender identifier type contains information to identify
      *a PayPal account. 
      */
	public partial class ReceiverIdentifier : AccountIdentifier	
	{

		/**
	 	  * Default Constructor
	 	  */
	 	public ReceiverIdentifier(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(base.toNVPString(prefix));
			return sb.ToString();
		}
		public ReceiverIdentifier(Dictionary<string, string> map, string prefix) : base(map, prefix)
		{
			string key = "";
			int i;
		}
		
	}




	/**
      *Options that apply to the receiver of a payment, allows
      *setting additional details for payment using invoice. 
      */
	public partial class ReceiverOptions	
	{

		/**
          *
		  */
		private string descriptionField;
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		

		/**
          *
		  */
		private string customIdField;
		public string customId
		{
			get
			{
				return this.customIdField;
			}
			set
			{
				this.customIdField = value;
			}
		}
		

		/**
          *
		  */
		private InvoiceData invoiceDataField;
		public InvoiceData invoiceData
		{
			get
			{
				return this.invoiceDataField;
			}
			set
			{
				this.invoiceDataField = value;
			}
		}
		

		/**
          *
		  */
		private ReceiverIdentifier receiverField;
		public ReceiverIdentifier receiver
		{
			get
			{
				return this.receiverField;
			}
			set
			{
				this.receiverField = value;
			}
		}
		

		/**
          *
		  */
		private string referrerCodeField;
		public string referrerCode
		{
			get
			{
				return this.referrerCodeField;
			}
			set
			{
				this.referrerCodeField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public ReceiverOptions(ReceiverIdentifier receiver){
			this.receiver = receiver;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public ReceiverOptions(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.description != null)
			{
					sb.Append(prefix).Append("description").Append("=").Append(HttpUtility.UrlEncode(this.description, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.customId != null)
			{
					sb.Append(prefix).Append("customId").Append("=").Append(HttpUtility.UrlEncode(this.customId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.invoiceData != null)
			{
					string newPrefix = prefix + "invoiceData" + ".";
					sb.Append(this.invoiceDataField.toNVPString(newPrefix));
			}
			if (this.receiver != null)
			{
					string newPrefix = prefix + "receiver" + ".";
					sb.Append(this.receiverField.toNVPString(newPrefix));
			}
			if (this.referrerCode != null)
			{
					sb.Append(prefix).Append("referrerCode").Append("=").Append(HttpUtility.UrlEncode(this.referrerCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
		public ReceiverOptions(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "description";
			if(map.ContainsKey(key))
			{
				this.description = map[key];
			}
			key = prefix + "customId";
			if(map.ContainsKey(key))
			{
				this.customId = map[key];
			}
			key = prefix + "invoiceData";
			if(map.ContainsKey(key+".item(0).name"))
			{
				this.invoiceData = new InvoiceData(map, key + ".");
			}
			key = prefix + "receiver";
            if (map.ContainsKey(key + ".email") || map.ContainsKey(key + ".phone.countryCode"))
			{
				this.receiver = new ReceiverIdentifier(map, key + ".");
			}
			key = prefix + "referrerCode";
			if(map.ContainsKey(key))
			{
				this.referrerCode = map[key];
			}
		}
		
	}




	/**
      *RefundInfo represents the refund attempt made to a Receiver
      *of a PayRequest. 
      */
	public partial class RefundInfo	
	{

		/**
          *
		  */
		private Receiver receiverField;
		public Receiver receiver
		{
			get
			{
				return this.receiverField;
			}
			set
			{
				this.receiverField = value;
			}
		}
		

		/**
          *
		  */
		private string refundStatusField;
		public string refundStatus
		{
			get
			{
				return this.refundStatusField;
			}
			set
			{
				this.refundStatusField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? refundNetAmountField;
		public decimal? refundNetAmount
		{
			get
			{
				return this.refundNetAmountField;
			}
			set
			{
				this.refundNetAmountField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? refundFeeAmountField;
		public decimal? refundFeeAmount
		{
			get
			{
				return this.refundFeeAmountField;
			}
			set
			{
				this.refundFeeAmountField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? refundGrossAmountField;
		public decimal? refundGrossAmount
		{
			get
			{
				return this.refundGrossAmountField;
			}
			set
			{
				this.refundGrossAmountField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? totalOfAllRefundsField;
		public decimal? totalOfAllRefunds
		{
			get
			{
				return this.totalOfAllRefundsField;
			}
			set
			{
				this.totalOfAllRefundsField = value;
			}
		}
		

		/**
          *
		  */
		private bool? refundHasBecomeFullField;
		public bool? refundHasBecomeFull
		{
			get
			{
				return this.refundHasBecomeFullField;
			}
			set
			{
				this.refundHasBecomeFullField = value;
			}
		}
		

		/**
          *
		  */
		private string encryptedRefundTransactionIdField;
		public string encryptedRefundTransactionId
		{
			get
			{
				return this.encryptedRefundTransactionIdField;
			}
			set
			{
				this.encryptedRefundTransactionIdField = value;
			}
		}
		

		/**
          *
		  */
		private string refundTransactionStatusField;
		public string refundTransactionStatus
		{
			get
			{
				return this.refundTransactionStatusField;
			}
			set
			{
				this.refundTransactionStatusField = value;
			}
		}
		

		/**
          *
		  */
		private ErrorList errorListField;
		public ErrorList errorList
		{
			get
			{
				return this.errorListField;
			}
			set
			{
				this.errorListField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public RefundInfo(){
		}


		public RefundInfo(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "receiver";
			if(map.ContainsKey(key + ".amount"))
			{
				this.receiver = new Receiver(map, key + ".");
			}
			key = prefix + "refundStatus";
			if(map.ContainsKey(key))
			{
				this.refundStatus = map[key];
			}
			key = prefix + "refundNetAmount";
			if(map.ContainsKey(key))
			{
				this.refundNetAmount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "refundFeeAmount";
			if(map.ContainsKey(key))
			{
				this.refundFeeAmount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "refundGrossAmount";
			if(map.ContainsKey(key))
			{
				this.refundGrossAmount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "totalOfAllRefunds";
			if(map.ContainsKey(key))
			{
				this.totalOfAllRefunds = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "refundHasBecomeFull";
			if(map.ContainsKey(key))
			{
				this.refundHasBecomeFull = System.Convert.ToBoolean(map[key]);
			}
			key = prefix + "encryptedRefundTransactionId";
			if(map.ContainsKey(key))
			{
				this.encryptedRefundTransactionId = map[key];
			}
			key = prefix + "refundTransactionStatus";
			if(map.ContainsKey(key))
			{
				this.refundTransactionStatus = map[key];
			}
			key = prefix + "errorList";
			if(map.ContainsKey(key + ".error(0).errorId"))
			{
				this.errorList = new ErrorList(map, key + ".");
			}
		}
		
	}




	/**
      *
      */
	public partial class RefundInfoList	
	{

		/**
          *
		  */
		private List<RefundInfo> refundInfoField = new List<RefundInfo>();
		public List<RefundInfo> refundInfo
		{
			get
			{
				return this.refundInfoField;
			}
			set
			{
				this.refundInfoField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public RefundInfoList(){
		}


		public RefundInfoList(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			i = 0;
			while(true){
				key = prefix + "refundInfo" + "(" + i + ")";
				if(map.ContainsKey(key + ".receiver.amount"))
				{
					this.refundInfo.Add(new RefundInfo(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *Options that apply to the sender of a payment. 
      */
	public partial class SenderOptions	
	{

		/**
          *
		  */
		private bool? requireShippingAddressSelectionField;
		public bool? requireShippingAddressSelection
		{
			get
			{
				return this.requireShippingAddressSelectionField;
			}
			set
			{
				this.requireShippingAddressSelectionField = value;
			}
		}
		

		/**
          *
		  */
		private string referrerCodeField;
		public string referrerCode
		{
			get
			{
				return this.referrerCodeField;
			}
			set
			{
				this.referrerCodeField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SenderOptions(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requireShippingAddressSelection != null)
			{
					sb.Append(prefix).Append("requireShippingAddressSelection").Append("=").Append(this.requireShippingAddressSelection).Append("&");
			}
			if (this.referrerCode != null)
			{
					sb.Append(prefix).Append("referrerCode").Append("=").Append(HttpUtility.UrlEncode(this.referrerCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
		public SenderOptions(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "requireShippingAddressSelection";
			if(map.ContainsKey(key))
			{
				this.requireShippingAddressSelection = System.Convert.ToBoolean(map[key]);
			}
			key = prefix + "referrerCode";
			if(map.ContainsKey(key))
			{
				this.referrerCode = map[key];
			}
		}
		
	}




	/**
      *The sender identifier type contains information to identify
      *a PayPal account. 
      */
	public partial class SenderIdentifier : AccountIdentifier	
	{

		/**
          *
		  */
		private bool? useCredentialsField;
		public bool? useCredentials
		{
			get
			{
				return this.useCredentialsField;
			}
			set
			{
				this.useCredentialsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SenderIdentifier(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(base.toNVPString(prefix));
			if (this.useCredentials != null)
			{
					sb.Append(prefix).Append("useCredentials").Append("=").Append(this.useCredentials).Append("&");
			}
			return sb.ToString();
		}
		public SenderIdentifier(Dictionary<string, string> map, string prefix) : base(map, prefix)
		{
			string key = "";
			int i;
			key = prefix + "useCredentials";
			if(map.ContainsKey(key))
			{
				this.useCredentials = System.Convert.ToBoolean(map[key]);
			}
		}
		
	}




	/**
      *
      */
	public partial class UserLimit	
	{

		/**
          *
		  */
		private string limitTypeField;
		public string limitType
		{
			get
			{
				return this.limitTypeField;
			}
			set
			{
				this.limitTypeField = value;
			}
		}
		

		/**
          *
		  */
		private CurrencyType limitAmountField;
		public CurrencyType limitAmount
		{
			get
			{
				return this.limitAmountField;
			}
			set
			{
				this.limitAmountField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public UserLimit(){
		}


		public UserLimit(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "limitType";
			if(map.ContainsKey(key))
			{
				this.limitType = map[key];
			}
			key = prefix + "limitAmount";
			if(map.ContainsKey(key + ".code"))
			{
				this.limitAmount = new CurrencyType(map, key + ".");
			}
		}
		
	}




	/**
      *This type contains the detailed warning information
      *resulting from the service operation. 
      */
	public partial class WarningData	
	{

		/**
          *
		  */
		private int? warningIdField;
		public int? warningId
		{
			get
			{
				return this.warningIdField;
			}
			set
			{
				this.warningIdField = value;
			}
		}
		

		/**
          *
		  */
		private string messageField;
		public string message
		{
			get
			{
				return this.messageField;
			}
			set
			{
				this.messageField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public WarningData(){
		}


		public WarningData(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "warningId";
			if(map.ContainsKey(key))
			{
				this.warningId = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "message";
			if(map.ContainsKey(key))
			{
				this.message = map[key];
			}
		}
		
	}




	/**
      *
      */
	public partial class WarningDataList	
	{

		/**
          *
		  */
		private List<WarningData> warningDataField = new List<WarningData>();
		public List<WarningData> warningData
		{
			get
			{
				return this.warningDataField;
			}
			set
			{
				this.warningDataField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public WarningDataList(){
		}


		public WarningDataList(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			i = 0;
			while(true){
				key = prefix + "warningData" + "(" + i + ")";
				if(map.ContainsKey(key+".warningId"))
				{
					this.warningData.Add(new WarningData(map, key));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request to cancel a Preapproval. 
      */
	public partial class CancelPreapprovalRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string preapprovalKeyField;
		public string preapprovalKey
		{
			get
			{
				return this.preapprovalKeyField;
			}
			set
			{
				this.preapprovalKeyField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public CancelPreapprovalRequest(RequestEnvelope requestEnvelope, string preapprovalKey){
			this.requestEnvelope = requestEnvelope;
			this.preapprovalKey = preapprovalKey;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public CancelPreapprovalRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.preapprovalKey != null)
			{
					sb.Append(prefix).Append("preapprovalKey").Append("=").Append(HttpUtility.UrlEncode(this.preapprovalKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *The result of the CancelPreapprovalRequest. 
      */
	public partial class CancelPreapprovalResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public CancelPreapprovalResponse(){
		}


		public CancelPreapprovalResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".errorId"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request to confirm a Preapproval. 
      */
	public partial class ConfirmPreapprovalRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string preapprovalKeyField;
		public string preapprovalKey
		{
			get
			{
				return this.preapprovalKeyField;
			}
			set
			{
				this.preapprovalKeyField = value;
			}
		}
		

		/**
          *
		  */
		private string fundingSourceIdField;
		public string fundingSourceId
		{
			get
			{
				return this.fundingSourceIdField;
			}
			set
			{
				this.fundingSourceIdField = value;
			}
		}
		

		/**
          *
		  */
		private string pinField;
		public string pin
		{
			get
			{
				return this.pinField;
			}
			set
			{
				this.pinField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public ConfirmPreapprovalRequest(RequestEnvelope requestEnvelope, string preapprovalKey){
			this.requestEnvelope = requestEnvelope;
			this.preapprovalKey = preapprovalKey;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public ConfirmPreapprovalRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.preapprovalKey != null)
			{
					sb.Append(prefix).Append("preapprovalKey").Append("=").Append(HttpUtility.UrlEncode(this.preapprovalKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.fundingSourceId != null)
			{
					sb.Append(prefix).Append("fundingSourceId").Append("=").Append(HttpUtility.UrlEncode(this.fundingSourceId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.pin != null)
			{
					sb.Append(prefix).Append("pin").Append("=").Append(HttpUtility.UrlEncode(this.pin, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *The result of the ConfirmPreapprovalRequest. 
      */
	public partial class ConfirmPreapprovalResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ConfirmPreapprovalResponse(){
		}


		public ConfirmPreapprovalResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".errorId"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *A request to convert one or more currencies into their
      *estimated values in other currencies. 
      */
	public partial class ConvertCurrencyRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private CurrencyList baseAmountListField;
		public CurrencyList baseAmountList
		{
			get
			{
				return this.baseAmountListField;
			}
			set
			{
				this.baseAmountListField = value;
			}
		}
		

		/**
          *
		  */
		private CurrencyCodeList convertToCurrencyListField;
		public CurrencyCodeList convertToCurrencyList
		{
			get
			{
				return this.convertToCurrencyListField;
			}
			set
			{
				this.convertToCurrencyListField = value;
			}
		}
		

		/**
          *
		  */
		private string countryCodeField;
		public string countryCode
		{
			get
			{
				return this.countryCodeField;
			}
			set
			{
				this.countryCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string conversionTypeField;
		public string conversionType
		{
			get
			{
				return this.conversionTypeField;
			}
			set
			{
				this.conversionTypeField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public ConvertCurrencyRequest(RequestEnvelope requestEnvelope, CurrencyList baseAmountList, CurrencyCodeList convertToCurrencyList){
			this.requestEnvelope = requestEnvelope;
			this.baseAmountList = baseAmountList;
			this.convertToCurrencyList = convertToCurrencyList;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public ConvertCurrencyRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.baseAmountList != null)
			{
					string newPrefix = prefix + "baseAmountList" + ".";
					sb.Append(this.baseAmountListField.toNVPString(newPrefix));
			}
			if (this.convertToCurrencyList != null)
			{
					string newPrefix = prefix + "convertToCurrencyList" + ".";
					sb.Append(this.convertToCurrencyListField.toNVPString(newPrefix));
			}
			if (this.countryCode != null)
			{
					sb.Append(prefix).Append("countryCode").Append("=").Append(HttpUtility.UrlEncode(this.countryCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.conversionType != null)
			{
					sb.Append(prefix).Append("conversionType").Append("=").Append(HttpUtility.UrlEncode(this.conversionType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *A response that contains a table of estimated converted
      *currencies based on the Convert Currency Request. 
      */
	public partial class ConvertCurrencyResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private CurrencyConversionTable estimatedAmountTableField;
		public CurrencyConversionTable estimatedAmountTable
		{
			get
			{
				return this.estimatedAmountTableField;
			}
			set
			{
				this.estimatedAmountTableField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ConvertCurrencyResponse(){
		}


		public ConvertCurrencyResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			key = prefix + "estimatedAmountTable";
			if(map.ContainsKey(key + ".currencyConversionList(0).baseAmount.code"))
			{
				this.estimatedAmountTable = new CurrencyConversionTable(map, key + ".");
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".errorId"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request to execute the payment request. 
      */
	public partial class ExecutePaymentRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string payKeyField;
		public string payKey
		{
			get
			{
				return this.payKeyField;
			}
			set
			{
				this.payKeyField = value;
			}
		}
		

		/**
          *
		  */
		private string actionTypeField;
		public string actionType
		{
			get
			{
				return this.actionTypeField;
			}
			set
			{
				this.actionTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string fundingPlanIdField;
		public string fundingPlanId
		{
			get
			{
				return this.fundingPlanIdField;
			}
			set
			{
				this.fundingPlanIdField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public ExecutePaymentRequest(RequestEnvelope requestEnvelope, string payKey){
			this.requestEnvelope = requestEnvelope;
			this.payKey = payKey;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public ExecutePaymentRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.payKey != null)
			{
					sb.Append(prefix).Append("payKey").Append("=").Append(HttpUtility.UrlEncode(this.payKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.actionType != null)
			{
					sb.Append(prefix).Append("actionType").Append("=").Append(HttpUtility.UrlEncode(this.actionType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.fundingPlanId != null)
			{
					sb.Append(prefix).Append("fundingPlanId").Append("=").Append(HttpUtility.UrlEncode(this.fundingPlanId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *The result of a payment execution. 
      */
	public partial class ExecutePaymentResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string paymentExecStatusField;
		public string paymentExecStatus
		{
			get
			{
				return this.paymentExecStatusField;
			}
			set
			{
				this.paymentExecStatusField = value;
			}
		}
		

		/**
          *
		  */
		private PayErrorList payErrorListField;
		public PayErrorList payErrorList
		{
			get
			{
				return this.payErrorListField;
			}
			set
			{
				this.payErrorListField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public ExecutePaymentResponse(){
		}


		public ExecutePaymentResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			key = prefix + "paymentExecStatus";
			if(map.ContainsKey(key))
			{
				this.paymentExecStatus = map[key];
			}
			key = prefix + "payErrorList";
			if(map.ContainsKey(key + ".payError(0).receiver.amount"))
			{
				this.payErrorList = new PayErrorList(map, key + ".");
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".errorId"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request to get the allowed funding sources available for
      *a preapproval. 
      */
	public partial class GetAllowedFundingSourcesRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string keyField;
		public string key
		{
			get
			{
				return this.keyField;
			}
			set
			{
				this.keyField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetAllowedFundingSourcesRequest(RequestEnvelope requestEnvelope, string key){
			this.requestEnvelope = requestEnvelope;
			this.key = key;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetAllowedFundingSourcesRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.key != null)
			{
					sb.Append(prefix).Append("key").Append("=").Append(HttpUtility.UrlEncode(this.key, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *The response to get the backup funding sources available for
      *a preapproval. 
      */
	public partial class GetAllowedFundingSourcesResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private List<FundingSource> fundingSourceField = new List<FundingSource>();
		public List<FundingSource> fundingSource
		{
			get
			{
				return this.fundingSourceField;
			}
			set
			{
				this.fundingSourceField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetAllowedFundingSourcesResponse(){
		}


		public GetAllowedFundingSourcesResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			i = 0;
			while(true){
				key = prefix + "fundingSource" + "(" + i + ")";
				if(map.ContainsKey(key + ".type"))
				{
					this.fundingSource.Add(new FundingSource(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".errorId"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request to get the options of a payment request. 
      */
	public partial class GetPaymentOptionsRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string payKeyField;
		public string payKey
		{
			get
			{
				return this.payKeyField;
			}
			set
			{
				this.payKeyField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetPaymentOptionsRequest(RequestEnvelope requestEnvelope, string payKey){
			this.requestEnvelope = requestEnvelope;
			this.payKey = payKey;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetPaymentOptionsRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.payKey != null)
			{
					sb.Append(prefix).Append("payKey").Append("=").Append(HttpUtility.UrlEncode(this.payKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *The response message for the GetPaymentOption request 
      */
	public partial class GetPaymentOptionsResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private InitiatingEntity initiatingEntityField;
		public InitiatingEntity initiatingEntity
		{
			get
			{
				return this.initiatingEntityField;
			}
			set
			{
				this.initiatingEntityField = value;
			}
		}
		

		/**
          *
		  */
		private DisplayOptions displayOptionsField;
		public DisplayOptions displayOptions
		{
			get
			{
				return this.displayOptionsField;
			}
			set
			{
				this.displayOptionsField = value;
			}
		}
		

		/**
          *
		  */
		private string shippingAddressIdField;
		public string shippingAddressId
		{
			get
			{
				return this.shippingAddressIdField;
			}
			set
			{
				this.shippingAddressIdField = value;
			}
		}
		

		/**
          *
		  */
		private SenderOptions senderOptionsField;
		public SenderOptions senderOptions
		{
			get
			{
				return this.senderOptionsField;
			}
			set
			{
				this.senderOptionsField = value;
			}
		}
		

		/**
          *
		  */
		private List<ReceiverOptions> receiverOptionsField = new List<ReceiverOptions>();
		public List<ReceiverOptions> receiverOptions
		{
			get
			{
				return this.receiverOptionsField;
			}
			set
			{
				this.receiverOptionsField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetPaymentOptionsResponse(){
		}


		public GetPaymentOptionsResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			key = prefix + "initiatingEntity";
			if(map.ContainsKey(key + ".institutionCustomer.institutionId"))
			{
				this.initiatingEntity = new InitiatingEntity(map, key + ".");
			}
			key = prefix + "displayOptions";
            if (map.ContainsKey(key + ".emailHeaderImageUrl") || map.ContainsKey(key + ".emailMarketingImageUrl") || map.ContainsKey(key + ".headerImageUrl") || map.ContainsKey(key + ".businessName"))
			{
                this.displayOptions = new DisplayOptions(map, key + ".");
			}
			key = prefix + "shippingAddressId";
			if(map.ContainsKey(key))
			{
				this.shippingAddressId = map[key];
			}
			key = prefix + "senderOptions";
            if (map.ContainsKey(key + ".requireShippingAddressSelection") || map.ContainsKey(key + ".referrerCode"))
			{
                this.senderOptions = new SenderOptions(map, key + ".");
			}
			i = 0;
			while(true){
				key = prefix + "receiverOptions" + "(" + i + ")";
                if (map.ContainsKey(key + ".description"))
				{
					this.receiverOptions.Add(new ReceiverOptions(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".errorId"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request to look up the details of a PayRequest. The
      *PaymentDetailsRequest can be made with either a payKey,
      *trackingId, or a transactionId of the PayRequest. 
      */
	public partial class PaymentDetailsRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string payKeyField;
		public string payKey
		{
			get
			{
				return this.payKeyField;
			}
			set
			{
				this.payKeyField = value;
			}
		}
		

		/**
          *
		  */
		private string transactionIdField;
		public string transactionId
		{
			get
			{
				return this.transactionIdField;
			}
			set
			{
				this.transactionIdField = value;
			}
		}
		

		/**
          *
		  */
		private string trackingIdField;
		public string trackingId
		{
			get
			{
				return this.trackingIdField;
			}
			set
			{
				this.trackingIdField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public PaymentDetailsRequest(RequestEnvelope requestEnvelope){
			this.requestEnvelope = requestEnvelope;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public PaymentDetailsRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.payKey != null)
			{
					sb.Append(prefix).Append("payKey").Append("=").Append(HttpUtility.UrlEncode(this.payKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.transactionId != null)
			{
					sb.Append(prefix).Append("transactionId").Append("=").Append(HttpUtility.UrlEncode(this.transactionId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.trackingId != null)
			{
					sb.Append(prefix).Append("trackingId").Append("=").Append(HttpUtility.UrlEncode(this.trackingId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *The details of the PayRequest as specified in the Pay
      *operation. 
      */
	public partial class PaymentDetailsResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string cancelUrlField;
		public string cancelUrl
		{
			get
			{
				return this.cancelUrlField;
			}
			set
			{
				this.cancelUrlField = value;
			}
		}
		

		/**
          *
		  */
		private string currencyCodeField;
		public string currencyCode
		{
			get
			{
				return this.currencyCodeField;
			}
			set
			{
				this.currencyCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string ipnNotificationUrlField;
		public string ipnNotificationUrl
		{
			get
			{
				return this.ipnNotificationUrlField;
			}
			set
			{
				this.ipnNotificationUrlField = value;
			}
		}
		

		/**
          *
		  */
		private string memoField;
		public string memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
			}
		}
		

		/**
          *
		  */
		private PaymentInfoList paymentInfoListField;
		public PaymentInfoList paymentInfoList
		{
			get
			{
				return this.paymentInfoListField;
			}
			set
			{
				this.paymentInfoListField = value;
			}
		}
		

		/**
          *
		  */
		private string returnUrlField;
		public string returnUrl
		{
			get
			{
				return this.returnUrlField;
			}
			set
			{
				this.returnUrlField = value;
			}
		}
		

		/**
          *
		  */
		private string senderEmailField;
		public string senderEmail
		{
			get
			{
				return this.senderEmailField;
			}
			set
			{
				this.senderEmailField = value;
			}
		}
		

		/**
          *
		  */
		private string statusField;
		public string status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
		

		/**
          *
		  */
		private string trackingIdField;
		public string trackingId
		{
			get
			{
				return this.trackingIdField;
			}
			set
			{
				this.trackingIdField = value;
			}
		}
		

		/**
          *
		  */
		private string payKeyField;
		public string payKey
		{
			get
			{
				return this.payKeyField;
			}
			set
			{
				this.payKeyField = value;
			}
		}
		

		/**
          *
		  */
		private string actionTypeField;
		public string actionType
		{
			get
			{
				return this.actionTypeField;
			}
			set
			{
				this.actionTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string feesPayerField;
		public string feesPayer
		{
			get
			{
				return this.feesPayerField;
			}
			set
			{
				this.feesPayerField = value;
			}
		}
		

		/**
          *
		  */
		private bool? reverseAllParallelPaymentsOnErrorField;
		public bool? reverseAllParallelPaymentsOnError
		{
			get
			{
				return this.reverseAllParallelPaymentsOnErrorField;
			}
			set
			{
				this.reverseAllParallelPaymentsOnErrorField = value;
			}
		}
		

		/**
          *
		  */
		private string preapprovalKeyField;
		public string preapprovalKey
		{
			get
			{
				return this.preapprovalKeyField;
			}
			set
			{
				this.preapprovalKeyField = value;
			}
		}
		

		/**
          *
		  */
		private FundingConstraint fundingConstraintField;
		public FundingConstraint fundingConstraint
		{
			get
			{
				return this.fundingConstraintField;
			}
			set
			{
				this.fundingConstraintField = value;
			}
		}
		

		/**
          *
		  */
		private SenderIdentifier senderField;
		public SenderIdentifier sender
		{
			get
			{
				return this.senderField;
			}
			set
			{
				this.senderField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PaymentDetailsResponse(){
		}


		public PaymentDetailsResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			key = prefix + "cancelUrl";
			if(map.ContainsKey(key))
			{
				this.cancelUrl = map[key];
			}
			key = prefix + "currencyCode";
			if(map.ContainsKey(key))
			{
				this.currencyCode = map[key];
			}
			key = prefix + "ipnNotificationUrl";
			if(map.ContainsKey(key))
			{
				this.ipnNotificationUrl = map[key];
			}
			key = prefix + "memo";
			if(map.ContainsKey(key))
			{
				this.memo = map[key];
			}
			key = prefix + "paymentInfoList";
			if(map.ContainsKey(key + ".paymentInfo(0).receiver.amount"))
			{
				this.paymentInfoList = new PaymentInfoList(map, key + ".");
			}
			key = prefix + "returnUrl";
			if(map.ContainsKey(key))
			{
				this.returnUrl = map[key];
			}
			key = prefix + "senderEmail";
			if(map.ContainsKey(key))
			{
				this.senderEmail = map[key];
			}
			key = prefix + "status";
			if(map.ContainsKey(key))
			{
				this.status = map[key];
			}
			key = prefix + "trackingId";
			if(map.ContainsKey(key))
			{
				this.trackingId = map[key];
			}
			key = prefix + "payKey";
			if(map.ContainsKey(key))
			{
				this.payKey = map[key];
			}
			key = prefix + "actionType";
			if(map.ContainsKey(key))
			{
				this.actionType = map[key];
			}
			key = prefix + "feesPayer";
			if(map.ContainsKey(key))
			{
				this.feesPayer = map[key];
			}
			key = prefix + "reverseAllParallelPaymentsOnError";
			if(map.ContainsKey(key))
			{
				this.reverseAllParallelPaymentsOnError = System.Convert.ToBoolean(map[key]);
			}
			key = prefix + "preapprovalKey";
			if(map.ContainsKey(key))
			{
				this.preapprovalKey = map[key];
			}
			key = prefix + "fundingConstraint";
			if(map.ContainsKey(key + ".allowedFundingType.fundingTypeInfo(0).fundingType"))
			{
				this.fundingConstraint = new FundingConstraint(map, key + ".");
			}
			key = prefix + "sender";
            if (map.ContainsKey(key + ".useCredentials"))
			{
				this.sender = new SenderIdentifier(map, key + ".");
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".errorId"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The PayRequest contains the payment instructions to make
      *from sender to receivers. 
      */
	public partial class PayRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private ClientDetailsType clientDetailsField;
		public ClientDetailsType clientDetails
		{
			get
			{
				return this.clientDetailsField;
			}
			set
			{
				this.clientDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string actionTypeField;
		public string actionType
		{
			get
			{
				return this.actionTypeField;
			}
			set
			{
				this.actionTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string cancelUrlField;
		public string cancelUrl
		{
			get
			{
				return this.cancelUrlField;
			}
			set
			{
				this.cancelUrlField = value;
			}
		}
		

		/**
          *
		  */
		private string currencyCodeField;
		public string currencyCode
		{
			get
			{
				return this.currencyCodeField;
			}
			set
			{
				this.currencyCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string feesPayerField;
		public string feesPayer
		{
			get
			{
				return this.feesPayerField;
			}
			set
			{
				this.feesPayerField = value;
			}
		}
		

		/**
          *
		  */
		private string ipnNotificationUrlField;
		public string ipnNotificationUrl
		{
			get
			{
				return this.ipnNotificationUrlField;
			}
			set
			{
				this.ipnNotificationUrlField = value;
			}
		}
		

		/**
          *
		  */
		private string memoField;
		public string memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
			}
		}
		

		/**
          *
		  */
		private string pinField;
		public string pin
		{
			get
			{
				return this.pinField;
			}
			set
			{
				this.pinField = value;
			}
		}
		

		/**
          *
		  */
		private string preapprovalKeyField;
		public string preapprovalKey
		{
			get
			{
				return this.preapprovalKeyField;
			}
			set
			{
				this.preapprovalKeyField = value;
			}
		}
		

		/**
          *
		  */
		private ReceiverList receiverListField;
		public ReceiverList receiverList
		{
			get
			{
				return this.receiverListField;
			}
			set
			{
				this.receiverListField = value;
			}
		}
		

		/**
          *
		  */
		private bool? reverseAllParallelPaymentsOnErrorField;
		public bool? reverseAllParallelPaymentsOnError
		{
			get
			{
				return this.reverseAllParallelPaymentsOnErrorField;
			}
			set
			{
				this.reverseAllParallelPaymentsOnErrorField = value;
			}
		}
		

		/**
          *
		  */
		private string senderEmailField;
		public string senderEmail
		{
			get
			{
				return this.senderEmailField;
			}
			set
			{
				this.senderEmailField = value;
			}
		}
		

		/**
          *
		  */
		private string returnUrlField;
		public string returnUrl
		{
			get
			{
				return this.returnUrlField;
			}
			set
			{
				this.returnUrlField = value;
			}
		}
		

		/**
          *
		  */
		private string trackingIdField;
		public string trackingId
		{
			get
			{
				return this.trackingIdField;
			}
			set
			{
				this.trackingIdField = value;
			}
		}
		

		/**
          *
		  */
		private FundingConstraint fundingConstraintField;
		public FundingConstraint fundingConstraint
		{
			get
			{
				return this.fundingConstraintField;
			}
			set
			{
				this.fundingConstraintField = value;
			}
		}
		

		/**
          *
		  */
		private SenderIdentifier senderField;
		public SenderIdentifier sender
		{
			get
			{
				return this.senderField;
			}
			set
			{
				this.senderField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public PayRequest(RequestEnvelope requestEnvelope, string actionType, string cancelUrl, string currencyCode, ReceiverList receiverList, string returnUrl){
			this.requestEnvelope = requestEnvelope;
			this.actionType = actionType;
			this.cancelUrl = cancelUrl;
			this.currencyCode = currencyCode;
			this.receiverList = receiverList;
			this.returnUrl = returnUrl;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public PayRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.clientDetails != null)
			{
					string newPrefix = prefix + "clientDetails" + ".";
					sb.Append(this.clientDetailsField.toNVPString(newPrefix));
			}
			if (this.actionType != null)
			{
					sb.Append(prefix).Append("actionType").Append("=").Append(HttpUtility.UrlEncode(this.actionType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.cancelUrl != null)
			{
					sb.Append(prefix).Append("cancelUrl").Append("=").Append(HttpUtility.UrlEncode(this.cancelUrl, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.currencyCode != null)
			{
					sb.Append(prefix).Append("currencyCode").Append("=").Append(HttpUtility.UrlEncode(this.currencyCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.feesPayer != null)
			{
					sb.Append(prefix).Append("feesPayer").Append("=").Append(HttpUtility.UrlEncode(this.feesPayer, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.ipnNotificationUrl != null)
			{
					sb.Append(prefix).Append("ipnNotificationUrl").Append("=").Append(HttpUtility.UrlEncode(this.ipnNotificationUrl, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.memo != null)
			{
					sb.Append(prefix).Append("memo").Append("=").Append(HttpUtility.UrlEncode(this.memo, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.pin != null)
			{
					sb.Append(prefix).Append("pin").Append("=").Append(HttpUtility.UrlEncode(this.pin, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.preapprovalKey != null)
			{
					sb.Append(prefix).Append("preapprovalKey").Append("=").Append(HttpUtility.UrlEncode(this.preapprovalKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.receiverList != null)
			{
					string newPrefix = prefix + "receiverList" + ".";
					sb.Append(this.receiverListField.toNVPString(newPrefix));
			}
			if (this.reverseAllParallelPaymentsOnError != null)
			{
					sb.Append(prefix).Append("reverseAllParallelPaymentsOnError").Append("=").Append(this.reverseAllParallelPaymentsOnError).Append("&");
			}
			if (this.senderEmail != null)
			{
					sb.Append(prefix).Append("senderEmail").Append("=").Append(HttpUtility.UrlEncode(this.senderEmail, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.returnUrl != null)
			{
					sb.Append(prefix).Append("returnUrl").Append("=").Append(HttpUtility.UrlEncode(this.returnUrl, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.trackingId != null)
			{
					sb.Append(prefix).Append("trackingId").Append("=").Append(HttpUtility.UrlEncode(this.trackingId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.fundingConstraint != null)
			{
					string newPrefix = prefix + "fundingConstraint" + ".";
					sb.Append(this.fundingConstraintField.toNVPString(newPrefix));
			}
			if (this.sender != null)
			{
					string newPrefix = prefix + "sender" + ".";
					sb.Append(this.senderField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/**
      *The PayResponse contains the result of the Pay operation.
      *The payKey and execution status of the request should always
      *be provided. 
      */
	public partial class PayResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string payKeyField;
		public string payKey
		{
			get
			{
				return this.payKeyField;
			}
			set
			{
				this.payKeyField = value;
			}
		}
		

		/**
          *
		  */
		private string paymentExecStatusField;
		public string paymentExecStatus
		{
			get
			{
				return this.paymentExecStatusField;
			}
			set
			{
				this.paymentExecStatusField = value;
			}
		}
		

		/**
          *
		  */
		private PayErrorList payErrorListField;
		public PayErrorList payErrorList
		{
			get
			{
				return this.payErrorListField;
			}
			set
			{
				this.payErrorListField = value;
			}
		}
		

		/**
          *
		  */
		private FundingPlan defaultFundingPlanField;
		public FundingPlan defaultFundingPlan
		{
			get
			{
				return this.defaultFundingPlanField;
			}
			set
			{
				this.defaultFundingPlanField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PayResponse(){
		}


		public PayResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			key = prefix + "payKey";
			if(map.ContainsKey(key))
			{
				this.payKey = map[key];
			}
			key = prefix + "paymentExecStatus";
			if(map.ContainsKey(key))
			{
				this.paymentExecStatus = map[key];
			}
			key = prefix + "payErrorList";
			if(map.ContainsKey(key + ".payError(0).receiver.amount"))
			{
				this.payErrorList = new PayErrorList(map, key + ".");
			}
			key = prefix + "defaultFundingPlan";
			if(map.ContainsKey(key + ".fundingPlanId"))
			{
				this.defaultFundingPlan = new FundingPlan(map, key + ".");
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".errorId"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request to look up the details of a Preapproval. 
      */
	public partial class PreapprovalDetailsRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string preapprovalKeyField;
		public string preapprovalKey
		{
			get
			{
				return this.preapprovalKeyField;
			}
			set
			{
				this.preapprovalKeyField = value;
			}
		}
		

		/**
          *
		  */
		private bool? getBillingAddressField;
		public bool? getBillingAddress
		{
			get
			{
				return this.getBillingAddressField;
			}
			set
			{
				this.getBillingAddressField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public PreapprovalDetailsRequest(RequestEnvelope requestEnvelope, string preapprovalKey){
			this.requestEnvelope = requestEnvelope;
			this.preapprovalKey = preapprovalKey;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public PreapprovalDetailsRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.preapprovalKey != null)
			{
					sb.Append(prefix).Append("preapprovalKey").Append("=").Append(HttpUtility.UrlEncode(this.preapprovalKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.getBillingAddress != null)
			{
					sb.Append(prefix).Append("getBillingAddress").Append("=").Append(this.getBillingAddress).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *The details of the Preapproval as specified in the
      *Preapproval operation. 
      */
	public partial class PreapprovalDetailsResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private bool? approvedField;
		public bool? approved
		{
			get
			{
				return this.approvedField;
			}
			set
			{
				this.approvedField = value;
			}
		}
		

		/**
          *
		  */
		private string cancelUrlField;
		public string cancelUrl
		{
			get
			{
				return this.cancelUrlField;
			}
			set
			{
				this.cancelUrlField = value;
			}
		}
		

		/**
          *
		  */
		private int? curPaymentsField;
		public int? curPayments
		{
			get
			{
				return this.curPaymentsField;
			}
			set
			{
				this.curPaymentsField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? curPaymentsAmountField;
		public decimal? curPaymentsAmount
		{
			get
			{
				return this.curPaymentsAmountField;
			}
			set
			{
				this.curPaymentsAmountField = value;
			}
		}
		

		/**
          *
		  */
		private int? curPeriodAttemptsField;
		public int? curPeriodAttempts
		{
			get
			{
				return this.curPeriodAttemptsField;
			}
			set
			{
				this.curPeriodAttemptsField = value;
			}
		}
		

		/**
          *
		  */
		private string curPeriodEndingDateField;
		public string curPeriodEndingDate
		{
			get
			{
				return this.curPeriodEndingDateField;
			}
			set
			{
				this.curPeriodEndingDateField = value;
			}
		}
		

		/**
          *
		  */
		private string currencyCodeField;
		public string currencyCode
		{
			get
			{
				return this.currencyCodeField;
			}
			set
			{
				this.currencyCodeField = value;
			}
		}
		

		/**
          *
		  */
		private int? dateOfMonthField;
		public int? dateOfMonth
		{
			get
			{
				return this.dateOfMonthField;
			}
			set
			{
				this.dateOfMonthField = value;
			}
		}
		

		/**
          *
		  */
		private DayOfWeek? dayOfWeekField;
		public DayOfWeek? dayOfWeek
		{
			get
			{
				return this.dayOfWeekField;
			}
			set
			{
				this.dayOfWeekField = value;
			}
		}
		

		/**
          *
		  */
		private string endingDateField;
		public string endingDate
		{
			get
			{
				return this.endingDateField;
			}
			set
			{
				this.endingDateField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? maxAmountPerPaymentField;
		public decimal? maxAmountPerPayment
		{
			get
			{
				return this.maxAmountPerPaymentField;
			}
			set
			{
				this.maxAmountPerPaymentField = value;
			}
		}
		

		/**
          *
		  */
		private int? maxNumberOfPaymentsField;
		public int? maxNumberOfPayments
		{
			get
			{
				return this.maxNumberOfPaymentsField;
			}
			set
			{
				this.maxNumberOfPaymentsField = value;
			}
		}
		

		/**
          *
		  */
		private int? maxNumberOfPaymentsPerPeriodField;
		public int? maxNumberOfPaymentsPerPeriod
		{
			get
			{
				return this.maxNumberOfPaymentsPerPeriodField;
			}
			set
			{
				this.maxNumberOfPaymentsPerPeriodField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? maxTotalAmountOfAllPaymentsField;
		public decimal? maxTotalAmountOfAllPayments
		{
			get
			{
				return this.maxTotalAmountOfAllPaymentsField;
			}
			set
			{
				this.maxTotalAmountOfAllPaymentsField = value;
			}
		}
		

		/**
          *
		  */
		private string paymentPeriodField;
		public string paymentPeriod
		{
			get
			{
				return this.paymentPeriodField;
			}
			set
			{
				this.paymentPeriodField = value;
			}
		}
		

		/**
          *
		  */
		private string pinTypeField;
		public string pinType
		{
			get
			{
				return this.pinTypeField;
			}
			set
			{
				this.pinTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string returnUrlField;
		public string returnUrl
		{
			get
			{
				return this.returnUrlField;
			}
			set
			{
				this.returnUrlField = value;
			}
		}
		

		/**
          *
		  */
		private string senderEmailField;
		public string senderEmail
		{
			get
			{
				return this.senderEmailField;
			}
			set
			{
				this.senderEmailField = value;
			}
		}
		

		/**
          *
		  */
		private string memoField;
		public string memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
			}
		}
		

		/**
          *
		  */
		private string startingDateField;
		public string startingDate
		{
			get
			{
				return this.startingDateField;
			}
			set
			{
				this.startingDateField = value;
			}
		}
		

		/**
          *
		  */
		private string statusField;
		public string status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
		

		/**
          *
		  */
		private string ipnNotificationUrlField;
		public string ipnNotificationUrl
		{
			get
			{
				return this.ipnNotificationUrlField;
			}
			set
			{
				this.ipnNotificationUrlField = value;
			}
		}
		

		/**
          *
		  */
		private AddressList addressListField;
		public AddressList addressList
		{
			get
			{
				return this.addressListField;
			}
			set
			{
				this.addressListField = value;
			}
		}
		

		/**
          *
		  */
		private string feesPayerField;
		public string feesPayer
		{
			get
			{
				return this.feesPayerField;
			}
			set
			{
				this.feesPayerField = value;
			}
		}
		

		/**
          *
		  */
		private bool? displayMaxTotalAmountField;
		public bool? displayMaxTotalAmount
		{
			get
			{
				return this.displayMaxTotalAmountField;
			}
			set
			{
				this.displayMaxTotalAmountField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PreapprovalDetailsResponse(){
		}


		public PreapprovalDetailsResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			key = prefix + "approved";
			if(map.ContainsKey(key))
			{
				this.approved = System.Convert.ToBoolean(map[key]);
			}
			key = prefix + "cancelUrl";
			if(map.ContainsKey(key))
			{
				this.cancelUrl = map[key];
			}
			key = prefix + "curPayments";
			if(map.ContainsKey(key))
			{
				this.curPayments = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "curPaymentsAmount";
			if(map.ContainsKey(key))
			{
				this.curPaymentsAmount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "curPeriodAttempts";
			if(map.ContainsKey(key))
			{
				this.curPeriodAttempts = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "curPeriodEndingDate";
			if(map.ContainsKey(key))
			{
				this.curPeriodEndingDate = map[key];
			}
			key = prefix + "currencyCode";
			if(map.ContainsKey(key))
			{
				this.currencyCode = map[key];
			}
			key = prefix + "dateOfMonth";
			if(map.ContainsKey(key))
			{
				this.dateOfMonth = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "dayOfWeek";
			if(map.ContainsKey(key))
			{
				this.dayOfWeek = (DayOfWeek)EnumUtils.getValue(map[key],typeof(DayOfWeek));;
			}
			key = prefix + "endingDate";
			if(map.ContainsKey(key))
			{
				this.endingDate = map[key];
			}
			key = prefix + "maxAmountPerPayment";
			if(map.ContainsKey(key))
			{
				this.maxAmountPerPayment = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "maxNumberOfPayments";
			if(map.ContainsKey(key))
			{
				this.maxNumberOfPayments = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "maxNumberOfPaymentsPerPeriod";
			if(map.ContainsKey(key))
			{
				this.maxNumberOfPaymentsPerPeriod = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "maxTotalAmountOfAllPayments";
			if(map.ContainsKey(key))
			{
				this.maxTotalAmountOfAllPayments = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "paymentPeriod";
			if(map.ContainsKey(key))
			{
				this.paymentPeriod = map[key];
			}
			key = prefix + "pinType";
			if(map.ContainsKey(key))
			{
				this.pinType = map[key];
			}
			key = prefix + "returnUrl";
			if(map.ContainsKey(key))
			{
				this.returnUrl = map[key];
			}
			key = prefix + "senderEmail";
			if(map.ContainsKey(key))
			{
				this.senderEmail = map[key];
			}
			key = prefix + "memo";
			if(map.ContainsKey(key))
			{
				this.memo = map[key];
			}
			key = prefix + "startingDate";
			if(map.ContainsKey(key))
			{
				this.startingDate = map[key];
			}
			key = prefix + "status";
			if(map.ContainsKey(key))
			{
				this.status = map[key];
			}
			key = prefix + "ipnNotificationUrl";
			if(map.ContainsKey(key))
			{
				this.ipnNotificationUrl = map[key];
			}
			key = prefix + "addressList";
			if(map.ContainsKey(key + ".address(0).baseAddress.line1"))
			{
				this.addressList = new AddressList(map, key + ".");
			}
			key = prefix + "feesPayer";
			if(map.ContainsKey(key))
			{
				this.feesPayer = map[key];
			}
			key = prefix + "displayMaxTotalAmount";
			if(map.ContainsKey(key))
			{
				this.displayMaxTotalAmount = System.Convert.ToBoolean(map[key]);
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".errorId"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *A request to create a Preapproval. A Preapproval is an
      *agreement between a Paypal account holder (the sender) and
      *the API caller (the service invoker) to make payment(s) on
      *the the sender's behalf with various limitations defined. 
      */
	public partial class PreapprovalRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private ClientDetailsType clientDetailsField;
		public ClientDetailsType clientDetails
		{
			get
			{
				return this.clientDetailsField;
			}
			set
			{
				this.clientDetailsField = value;
			}
		}
		

		/**
          *
		  */
		private string cancelUrlField;
		public string cancelUrl
		{
			get
			{
				return this.cancelUrlField;
			}
			set
			{
				this.cancelUrlField = value;
			}
		}
		

		/**
          *
		  */
		private string currencyCodeField;
		public string currencyCode
		{
			get
			{
				return this.currencyCodeField;
			}
			set
			{
				this.currencyCodeField = value;
			}
		}
		

		/**
          *
		  */
		private int? dateOfMonthField;
		public int? dateOfMonth
		{
			get
			{
				return this.dateOfMonthField;
			}
			set
			{
				this.dateOfMonthField = value;
			}
		}
		

		/**
          *
		  */
		private DayOfWeek? dayOfWeekField;
		public DayOfWeek? dayOfWeek
		{
			get
			{
				return this.dayOfWeekField;
			}
			set
			{
				this.dayOfWeekField = value;
			}
		}
		

		/**
          *
		  */
		private string endingDateField;
		public string endingDate
		{
			get
			{
				return this.endingDateField;
			}
			set
			{
				this.endingDateField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? maxAmountPerPaymentField;
		public decimal? maxAmountPerPayment
		{
			get
			{
				return this.maxAmountPerPaymentField;
			}
			set
			{
				this.maxAmountPerPaymentField = value;
			}
		}
		

		/**
          *
		  */
		private int? maxNumberOfPaymentsField;
		public int? maxNumberOfPayments
		{
			get
			{
				return this.maxNumberOfPaymentsField;
			}
			set
			{
				this.maxNumberOfPaymentsField = value;
			}
		}
		

		/**
          *
		  */
		private int? maxNumberOfPaymentsPerPeriodField;
		public int? maxNumberOfPaymentsPerPeriod
		{
			get
			{
				return this.maxNumberOfPaymentsPerPeriodField;
			}
			set
			{
				this.maxNumberOfPaymentsPerPeriodField = value;
			}
		}
		

		/**
          *
		  */
		private decimal? maxTotalAmountOfAllPaymentsField;
		public decimal? maxTotalAmountOfAllPayments
		{
			get
			{
				return this.maxTotalAmountOfAllPaymentsField;
			}
			set
			{
				this.maxTotalAmountOfAllPaymentsField = value;
			}
		}
		

		/**
          *
		  */
		private string paymentPeriodField;
		public string paymentPeriod
		{
			get
			{
				return this.paymentPeriodField;
			}
			set
			{
				this.paymentPeriodField = value;
			}
		}
		

		/**
          *
		  */
		private string returnUrlField;
		public string returnUrl
		{
			get
			{
				return this.returnUrlField;
			}
			set
			{
				this.returnUrlField = value;
			}
		}
		

		/**
          *
		  */
		private string memoField;
		public string memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
			}
		}
		

		/**
          *
		  */
		private string ipnNotificationUrlField;
		public string ipnNotificationUrl
		{
			get
			{
				return this.ipnNotificationUrlField;
			}
			set
			{
				this.ipnNotificationUrlField = value;
			}
		}
		

		/**
          *
		  */
		private string senderEmailField;
		public string senderEmail
		{
			get
			{
				return this.senderEmailField;
			}
			set
			{
				this.senderEmailField = value;
			}
		}
		

		/**
          *
		  */
		private string startingDateField;
		public string startingDate
		{
			get
			{
				return this.startingDateField;
			}
			set
			{
				this.startingDateField = value;
			}
		}
		

		/**
          *
		  */
		private string pinTypeField;
		public string pinType
		{
			get
			{
				return this.pinTypeField;
			}
			set
			{
				this.pinTypeField = value;
			}
		}
		

		/**
          *
		  */
		private string feesPayerField;
		public string feesPayer
		{
			get
			{
				return this.feesPayerField;
			}
			set
			{
				this.feesPayerField = value;
			}
		}
		

		/**
          *
		  */
		private bool? displayMaxTotalAmountField;
		public bool? displayMaxTotalAmount
		{
			get
			{
				return this.displayMaxTotalAmountField;
			}
			set
			{
				this.displayMaxTotalAmountField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public PreapprovalRequest(RequestEnvelope requestEnvelope, string cancelUrl, string currencyCode, string returnUrl, string startingDate){
			this.requestEnvelope = requestEnvelope;
			this.cancelUrl = cancelUrl;
			this.currencyCode = currencyCode;
			this.returnUrl = returnUrl;
			this.startingDate = startingDate;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public PreapprovalRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.clientDetails != null)
			{
					string newPrefix = prefix + "clientDetails" + ".";
					sb.Append(this.clientDetailsField.toNVPString(newPrefix));
			}
			if (this.cancelUrl != null)
			{
					sb.Append(prefix).Append("cancelUrl").Append("=").Append(HttpUtility.UrlEncode(this.cancelUrl, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.currencyCode != null)
			{
					sb.Append(prefix).Append("currencyCode").Append("=").Append(HttpUtility.UrlEncode(this.currencyCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.dateOfMonth != null)
			{
					sb.Append(prefix).Append("dateOfMonth").Append("=").Append(this.dateOfMonth).Append("&");
			}
			if (this.dayOfWeek != null)
			{
					sb.Append(prefix).Append("dayOfWeek").Append("=").Append(EnumUtils.getDescription(dayOfWeek));
					sb.Append("&");
			}
			if (this.endingDate != null)
			{
					sb.Append(prefix).Append("endingDate").Append("=").Append(HttpUtility.UrlEncode(this.endingDate, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.maxAmountPerPayment != null)
			{
					sb.Append(prefix).Append("maxAmountPerPayment").Append("=").Append(this.maxAmountPerPayment).Append("&");
			}
			if (this.maxNumberOfPayments != null)
			{
					sb.Append(prefix).Append("maxNumberOfPayments").Append("=").Append(this.maxNumberOfPayments).Append("&");
			}
			if (this.maxNumberOfPaymentsPerPeriod != null)
			{
					sb.Append(prefix).Append("maxNumberOfPaymentsPerPeriod").Append("=").Append(this.maxNumberOfPaymentsPerPeriod).Append("&");
			}
			if (this.maxTotalAmountOfAllPayments != null)
			{
					sb.Append(prefix).Append("maxTotalAmountOfAllPayments").Append("=").Append(this.maxTotalAmountOfAllPayments).Append("&");
			}
			if (this.paymentPeriod != null)
			{
					sb.Append(prefix).Append("paymentPeriod").Append("=").Append(HttpUtility.UrlEncode(this.paymentPeriod, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.returnUrl != null)
			{
					sb.Append(prefix).Append("returnUrl").Append("=").Append(HttpUtility.UrlEncode(this.returnUrl, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.memo != null)
			{
					sb.Append(prefix).Append("memo").Append("=").Append(HttpUtility.UrlEncode(this.memo, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.ipnNotificationUrl != null)
			{
					sb.Append(prefix).Append("ipnNotificationUrl").Append("=").Append(HttpUtility.UrlEncode(this.ipnNotificationUrl, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.senderEmail != null)
			{
					sb.Append(prefix).Append("senderEmail").Append("=").Append(HttpUtility.UrlEncode(this.senderEmail, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.startingDate != null)
			{
					sb.Append(prefix).Append("startingDate").Append("=").Append(HttpUtility.UrlEncode(this.startingDate, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.pinType != null)
			{
					sb.Append(prefix).Append("pinType").Append("=").Append(HttpUtility.UrlEncode(this.pinType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.feesPayer != null)
			{
					sb.Append(prefix).Append("feesPayer").Append("=").Append(HttpUtility.UrlEncode(this.feesPayer, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.displayMaxTotalAmount != null)
			{
					sb.Append(prefix).Append("displayMaxTotalAmount").Append("=").Append(this.displayMaxTotalAmount).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *The result of the PreapprovalRequest is a preapprovalKey. 
      */
	public partial class PreapprovalResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string preapprovalKeyField;
		public string preapprovalKey
		{
			get
			{
				return this.preapprovalKeyField;
			}
			set
			{
				this.preapprovalKeyField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public PreapprovalResponse(){
		}


		public PreapprovalResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			key = prefix + "preapprovalKey";
			if(map.ContainsKey(key))
			{
				this.preapprovalKey = map[key];
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".errorId"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *A request to make a refund based on various criteria. A
      *refund can be made against the entire payKey, an individual
      *transaction belonging to a payKey, a tracking id, or a
      *specific receiver of a payKey. 
      */
	public partial class RefundRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string currencyCodeField;
		public string currencyCode
		{
			get
			{
				return this.currencyCodeField;
			}
			set
			{
				this.currencyCodeField = value;
			}
		}
		

		/**
          *
		  */
		private string payKeyField;
		public string payKey
		{
			get
			{
				return this.payKeyField;
			}
			set
			{
				this.payKeyField = value;
			}
		}
		

		/**
          *
		  */
		private string transactionIdField;
		public string transactionId
		{
			get
			{
				return this.transactionIdField;
			}
			set
			{
				this.transactionIdField = value;
			}
		}
		

		/**
          *
		  */
		private string trackingIdField;
		public string trackingId
		{
			get
			{
				return this.trackingIdField;
			}
			set
			{
				this.trackingIdField = value;
			}
		}
		

		/**
          *
		  */
		private ReceiverList receiverListField;
		public ReceiverList receiverList
		{
			get
			{
				return this.receiverListField;
			}
			set
			{
				this.receiverListField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public RefundRequest(RequestEnvelope requestEnvelope){
			this.requestEnvelope = requestEnvelope;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public RefundRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.currencyCode != null)
			{
					sb.Append(prefix).Append("currencyCode").Append("=").Append(HttpUtility.UrlEncode(this.currencyCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.payKey != null)
			{
					sb.Append(prefix).Append("payKey").Append("=").Append(HttpUtility.UrlEncode(this.payKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.transactionId != null)
			{
					sb.Append(prefix).Append("transactionId").Append("=").Append(HttpUtility.UrlEncode(this.transactionId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.trackingId != null)
			{
					sb.Append(prefix).Append("trackingId").Append("=").Append(HttpUtility.UrlEncode(this.trackingId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.receiverList != null)
			{
					string newPrefix = prefix + "receiverList" + ".";
					sb.Append(this.receiverListField.toNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/**
      *The result of a Refund request. 
      */
	public partial class RefundResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string currencyCodeField;
		public string currencyCode
		{
			get
			{
				return this.currencyCodeField;
			}
			set
			{
				this.currencyCodeField = value;
			}
		}
		

		/**
          *
		  */
		private RefundInfoList refundInfoListField;
		public RefundInfoList refundInfoList
		{
			get
			{
				return this.refundInfoListField;
			}
			set
			{
				this.refundInfoListField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public RefundResponse(){
		}


		public RefundResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			key = prefix + "currencyCode";
			if(map.ContainsKey(key))
			{
				this.currencyCode = map[key];
			}
			key = prefix + "refundInfoList";
			if(map.ContainsKey(key + ".refundInfo(0).receiver.amount"))
			{
				this.refundInfoList = new RefundInfoList(map, key + ".");
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".errorId"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request to set the options of a payment request. 
      */
	public partial class SetPaymentOptionsRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string payKeyField;
		public string payKey
		{
			get
			{
				return this.payKeyField;
			}
			set
			{
				this.payKeyField = value;
			}
		}
		

		/**
          *
		  */
		private InitiatingEntity initiatingEntityField;
		public InitiatingEntity initiatingEntity
		{
			get
			{
				return this.initiatingEntityField;
			}
			set
			{
				this.initiatingEntityField = value;
			}
		}
		

		/**
          *
		  */
		private DisplayOptions displayOptionsField;
		public DisplayOptions displayOptions
		{
			get
			{
				return this.displayOptionsField;
			}
			set
			{
				this.displayOptionsField = value;
			}
		}
		

		/**
          *
		  */
		private string shippingAddressIdField;
		public string shippingAddressId
		{
			get
			{
				return this.shippingAddressIdField;
			}
			set
			{
				this.shippingAddressIdField = value;
			}
		}
		

		/**
          *
		  */
		private SenderOptions senderOptionsField;
		public SenderOptions senderOptions
		{
			get
			{
				return this.senderOptionsField;
			}
			set
			{
				this.senderOptionsField = value;
			}
		}
		

		/**
          *
		  */
		private List<ReceiverOptions> receiverOptionsField = new List<ReceiverOptions>();
		public List<ReceiverOptions> receiverOptions
		{
			get
			{
				return this.receiverOptionsField;
			}
			set
			{
				this.receiverOptionsField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public SetPaymentOptionsRequest(RequestEnvelope requestEnvelope, string payKey){
			this.requestEnvelope = requestEnvelope;
			this.payKey = payKey;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public SetPaymentOptionsRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.payKey != null)
			{
					sb.Append(prefix).Append("payKey").Append("=").Append(HttpUtility.UrlEncode(this.payKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.initiatingEntity != null)
			{
					string newPrefix = prefix + "initiatingEntity" + ".";
					sb.Append(this.initiatingEntityField.toNVPString(newPrefix));
			}
			if (this.displayOptions != null)
			{
					string newPrefix = prefix + "displayOptions" + ".";
					sb.Append(this.displayOptionsField.toNVPString(newPrefix));
			}
			if (this.shippingAddressId != null)
			{
					sb.Append(prefix).Append("shippingAddressId").Append("=").Append(HttpUtility.UrlEncode(this.shippingAddressId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.senderOptions != null)
			{
					string newPrefix = prefix + "senderOptions" + ".";
					sb.Append(this.senderOptionsField.toNVPString(newPrefix));
			}
			for (int i = 0; i < this.receiverOptions.Count; i++)
			{
				if (this.receiverOptions[i] != null)
				{
					string newPrefix = prefix + "receiverOptions" + "(" + i + ").";
					sb.Append(this.receiverOptions[i].toNVPString(newPrefix));
				}
			}
			return sb.ToString();
		}
	}




	/**
      *The response message for the SetPaymentOption request 
      */
	public partial class SetPaymentOptionsResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SetPaymentOptionsResponse(){
		}


		public SetPaymentOptionsResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".errorId"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request to get the funding plans available for a
      *payment. 
      */
	public partial class GetFundingPlansRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string payKeyField;
		public string payKey
		{
			get
			{
				return this.payKeyField;
			}
			set
			{
				this.payKeyField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetFundingPlansRequest(RequestEnvelope requestEnvelope, string payKey){
			this.requestEnvelope = requestEnvelope;
			this.payKey = payKey;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetFundingPlansRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.payKey != null)
			{
					sb.Append(prefix).Append("payKey").Append("=").Append(HttpUtility.UrlEncode(this.payKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *The response to get the funding plans available for a
      *payment. 
      */
	public partial class GetFundingPlansResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private List<FundingPlan> fundingPlanField = new List<FundingPlan>();
		public List<FundingPlan> fundingPlan
		{
			get
			{
				return this.fundingPlanField;
			}
			set
			{
				this.fundingPlanField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetFundingPlansResponse(){
		}


		public GetFundingPlansResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			i = 0;
			while(true){
				key = prefix + "fundingPlan" + "(" + i + ")";
				if(map.ContainsKey(key + ".fundingPlanId"))
				{
					this.fundingPlan.Add(new FundingPlan(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".errorId"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request to get the addresses available for a payment. 
      */
	public partial class GetAvailableShippingAddressesRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string keyField;
		public string key
		{
			get
			{
				return this.keyField;
			}
			set
			{
				this.keyField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetAvailableShippingAddressesRequest(RequestEnvelope requestEnvelope, string key){
			this.requestEnvelope = requestEnvelope;
			this.key = key;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetAvailableShippingAddressesRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.key != null)
			{
					sb.Append(prefix).Append("key").Append("=").Append(HttpUtility.UrlEncode(this.key, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *The response to get the shipping addresses available for a
      *payment. 
      */
	public partial class GetAvailableShippingAddressesResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private List<Address> availableAddressField = new List<Address>();
		public List<Address> availableAddress
		{
			get
			{
				return this.availableAddressField;
			}
			set
			{
				this.availableAddressField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetAvailableShippingAddressesResponse(){
		}


		public GetAvailableShippingAddressesResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			i = 0;
			while(true){
				key = prefix + "availableAddress" + "(" + i + ")";
				if(map.ContainsKey(key + ".baseAddress.line1"))
				{
					this.availableAddress.Add(new Address(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".errorId"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request to get the addresses available for a payment. 
      */
	public partial class GetShippingAddressesRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private string keyField;
		public string key
		{
			get
			{
				return this.keyField;
			}
			set
			{
				this.keyField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetShippingAddressesRequest(RequestEnvelope requestEnvelope, string key){
			this.requestEnvelope = requestEnvelope;
			this.key = key;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetShippingAddressesRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.key != null)
			{
					sb.Append(prefix).Append("key").Append("=").Append(HttpUtility.UrlEncode(this.key, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/**
      *The response to get the shipping addresses available for a
      *payment. 
      */
	public partial class GetShippingAddressesResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private Address selectedAddressField;
		public Address selectedAddress
		{
			get
			{
				return this.selectedAddressField;
			}
			set
			{
				this.selectedAddressField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetShippingAddressesResponse(){
		}


		public GetShippingAddressesResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			key = prefix + "selectedAddress";
			if(map.ContainsKey(key + ".baseAddress.line1"))
			{
				this.selectedAddress = new Address(map, key + ".");
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".errorId"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}




	/**
      *The request to get the remaining limits for a user 
      */
	public partial class GetUserLimitsRequest	
	{

		/**
          *
		  */
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private AccountIdentifier userField;
		public AccountIdentifier user
		{
			get
			{
				return this.userField;
			}
			set
			{
				this.userField = value;
			}
		}
		

		/**
          *
		  */
		private string countryField;
		public string country
		{
			get
			{
				return this.countryField;
			}
			set
			{
				this.countryField = value;
			}
		}
		

		/**
          *
		  */
		private string currencyCodeField;
		public string currencyCode
		{
			get
			{
				return this.currencyCodeField;
			}
			set
			{
				this.currencyCodeField = value;
			}
		}
		

		/**
          *
		  */
		private List<string> limitTypeField = new List<string>();
		public List<string> limitType
		{
			get
			{
				return this.limitTypeField;
			}
			set
			{
				this.limitTypeField = value;
			}
		}
		

		/**
	 	  * Constructor with arguments
	 	  */
	 	public GetUserLimitsRequest(RequestEnvelope requestEnvelope, AccountIdentifier user, string country, string currencyCode, List<string> limitType){
			this.requestEnvelope = requestEnvelope;
			this.user = user;
			this.country = country;
			this.currencyCode = currencyCode;
			this.limitType = limitType;
		}

		/**
	 	  * Default Constructor
	 	  */
	 	public GetUserLimitsRequest(){
		}


		public string toNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.toNVPString(newPrefix));
			}
			if (this.user != null)
			{
					string newPrefix = prefix + "user" + ".";
					sb.Append(this.userField.toNVPString(newPrefix));
			}
			if (this.country != null)
			{
					sb.Append(prefix).Append("country").Append("=").Append(HttpUtility.UrlEncode(this.country, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.currencyCode != null)
			{
					sb.Append(prefix).Append("currencyCode").Append("=").Append(HttpUtility.UrlEncode(this.currencyCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			for (int i = 0; i < this.limitType.Count; i++)
			{
				if (this.limitType[i] != null)
				{
					sb.Append(prefix).Append("limitType").Append("(").Append(i).Append(")").Append("=").Append(HttpUtility.UrlEncode(this.limitType[i], BaseConstants.ENCODING_FORMAT)).Append("&");
				}
			}
			return sb.ToString();
		}
	}




	/**
      *A response that contains a list of remaining limits 
      */
	public partial class GetUserLimitsResponse	
	{

		/**
          *
		  */
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/**
          *
		  */
		private List<UserLimit> userLimitField = new List<UserLimit>();
		public List<UserLimit> userLimit
		{
			get
			{
				return this.userLimitField;
			}
			set
			{
				this.userLimitField = value;
			}
		}
		

		/**
          *
		  */
		private WarningDataList warningDataListField;
		public WarningDataList warningDataList
		{
			get
			{
				return this.warningDataListField;
			}
			set
			{
				this.warningDataListField = value;
			}
		}
		

		/**
          *
		  */
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public GetUserLimitsResponse(){
		}


		public GetUserLimitsResponse(Dictionary<string, string> map, string prefix)
		{
			string key = "";
			int i;
			key = prefix + "responseEnvelope";
			if(map.ContainsKey(key + ".timestamp"))
			{
				this.responseEnvelope = new ResponseEnvelope(map, key + ".");
			}
			i = 0;
			while(true){
				key = prefix + "userLimit" + "(" + i + ")";
				if(map.ContainsKey(key + ".limitType"))
				{
					this.userLimit.Add(new UserLimit(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
			key = prefix + "warningDataList";
            if (map.ContainsKey(key + ".warningData(0).warningId"))
			{
				this.warningDataList = new WarningDataList(map, key);
			}
			i = 0;
			while(true){
				key = prefix + "error" + "(" + i + ")";
				if(map.ContainsKey(key + ".errorId"))
				{
					this.error.Add(new ErrorData(map, key + "."));
				} else
				{
					break;
				}
				i++;
			}
		}
		
	}





}