/**
  * Stub objects for AdaptivePayments 
  * AUTO_GENERATED_CODE 
  */
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using PayPal.Util;

namespace PayPal.AdaptivePayments.Model
{

	public static class EnumUtils
	{
		public static string GetDescription(Enum value)
		{
			string description = "";
			DescriptionAttribute[] attributes = (DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
			{
				description= attributes[0].Description;
			}
			return description;
		}
		
		public static object GetValue(string value,Type enumType)
		{
			string[] names = Enum.GetNames(enumType);
			foreach(string name in names)
            {
            	if (GetDescription((Enum)Enum.Parse(enumType, name)).Equals(value))
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
	public partial class AccountIdentifier	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.email != null)
			{
					sb.Append(prefix).Append("email").Append("=").Append(HttpUtility.UrlEncode(this.email, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.phone != null)
			{
					string newPrefix = prefix + "phone" + ".";
					sb.Append(this.phoneField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}

		public static AccountIdentifier CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			AccountIdentifier accountIdentifier = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "email";
			if (map.ContainsKey(key))
			{
				accountIdentifier = (accountIdentifier == null) ? new AccountIdentifier() : accountIdentifier;
				accountIdentifier.email = map[key];
			}
			PhoneNumberType phone =  PhoneNumberType.CreateInstance(map, prefix + "phone", -1);
			if (phone != null)
			{
				accountIdentifier = (accountIdentifier == null) ? new AccountIdentifier() : accountIdentifier;
				accountIdentifier.phone = phone;
			}
			return accountIdentifier;
		}
	}




	/**
      *
      */
	public partial class BaseAddress	{

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



		public static BaseAddress CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			BaseAddress baseAddress = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "line1";
			if (map.ContainsKey(key))
			{
				baseAddress = (baseAddress == null) ? new BaseAddress() : baseAddress;
				baseAddress.line1 = map[key];
			}
			key = prefix + "line2";
			if (map.ContainsKey(key))
			{
				baseAddress = (baseAddress == null) ? new BaseAddress() : baseAddress;
				baseAddress.line2 = map[key];
			}
			key = prefix + "city";
			if (map.ContainsKey(key))
			{
				baseAddress = (baseAddress == null) ? new BaseAddress() : baseAddress;
				baseAddress.city = map[key];
			}
			key = prefix + "state";
			if (map.ContainsKey(key))
			{
				baseAddress = (baseAddress == null) ? new BaseAddress() : baseAddress;
				baseAddress.state = map[key];
			}
			key = prefix + "postalCode";
			if (map.ContainsKey(key))
			{
				baseAddress = (baseAddress == null) ? new BaseAddress() : baseAddress;
				baseAddress.postalCode = map[key];
			}
			key = prefix + "countryCode";
			if (map.ContainsKey(key))
			{
				baseAddress = (baseAddress == null) ? new BaseAddress() : baseAddress;
				baseAddress.countryCode = map[key];
			}
			key = prefix + "type";
			if (map.ContainsKey(key))
			{
				baseAddress = (baseAddress == null) ? new BaseAddress() : baseAddress;
				baseAddress.type = map[key];
			}
			return baseAddress;
		}
	}




	/**
      *Details about the end user of the application invoking this
      *service. 
      */
	public partial class ClientDetailsType	{

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


		public string ToNVPString(string prefix)
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
	public partial class CurrencyType	{

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


		public string ToNVPString(string prefix)
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

		public static CurrencyType CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			CurrencyType currencyType = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "code";
			if (map.ContainsKey(key))
			{
				currencyType = (currencyType == null) ? new CurrencyType() : currencyType;
				currencyType.code = map[key];
			}
			key = prefix + "amount";
			if (map.ContainsKey(key))
			{
				currencyType = (currencyType == null) ? new CurrencyType() : currencyType;
				currencyType.amount = System.Convert.ToDecimal(map[key]);
			}
			return currencyType;
		}
	}




	/**
      *This type contains the detailed error information resulting
      *from the service operation. 
      */
	public partial class ErrorData	{

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



		public static ErrorData CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			ErrorData errorData = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "errorId";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.errorId = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "domain";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.domain = map[key];
			}
			key = prefix + "subdomain";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.subdomain = map[key];
			}
			key = prefix + "severity";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.severity = (ErrorSeverity)EnumUtils.GetValue(map[key],typeof(ErrorSeverity));
			}
			key = prefix + "category";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.category = (ErrorCategory)EnumUtils.GetValue(map[key],typeof(ErrorCategory));
			}
			key = prefix + "message";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.message = map[key];
			}
			key = prefix + "exceptionId";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.exceptionId = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorParameter parameter =  ErrorParameter.CreateInstance(map, prefix + "parameter", i);
				if (parameter != null)
				{
					errorData = (errorData == null) ? new ErrorData() : errorData;
					errorData.parameter.Add(parameter);
					i++;
				} 
				else
				{
					break;
				}
			}
			return errorData;
		}
	}




	/**
      *
      */
	public partial class ErrorParameter	{

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



		public static ErrorParameter CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			ErrorParameter errorParameter = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "name";
			if (map.ContainsKey(key))
			{
				errorParameter = (errorParameter == null) ? new ErrorParameter() : errorParameter;
				errorParameter.name = map[key];
			}
			key = prefix.Substring(0, prefix.Length - 1);
			if (map.ContainsKey(key))
			{
				errorParameter = (errorParameter == null) ? new ErrorParameter() : errorParameter;
				errorParameter.value = map[key];
			}
			return errorParameter;
		}
	}




	/**
      *This specifies a fault, encapsulating error data, with
      *specific error codes. 
      */
	public partial class FaultMessage	{

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



		public static FaultMessage CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			FaultMessage faultMessage = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				faultMessage = (faultMessage == null) ? new FaultMessage() : faultMessage;
				faultMessage.responseEnvelope = responseEnvelope;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					faultMessage = (faultMessage == null) ? new FaultMessage() : faultMessage;
					faultMessage.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return faultMessage;
		}
	}




	/**
      *
      */
	public partial class PhoneNumberType	{

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


		public string ToNVPString(string prefix)
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

		public static PhoneNumberType CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			PhoneNumberType phoneNumberType = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "countryCode";
			if (map.ContainsKey(key))
			{
				phoneNumberType = (phoneNumberType == null) ? new PhoneNumberType() : phoneNumberType;
				phoneNumberType.countryCode = map[key];
			}
			key = prefix + "phoneNumber";
			if (map.ContainsKey(key))
			{
				phoneNumberType = (phoneNumberType == null) ? new PhoneNumberType() : phoneNumberType;
				phoneNumberType.phoneNumber = map[key];
			}
			key = prefix + "extension";
			if (map.ContainsKey(key))
			{
				phoneNumberType = (phoneNumberType == null) ? new PhoneNumberType() : phoneNumberType;
				phoneNumberType.extension = map[key];
			}
			return phoneNumberType;
		}
	}




	/**
      *This specifies the list of parameters with every request to
      *the service. 
      */
	public partial class RequestEnvelope	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.detailLevel != null)
			{
					sb.Append(prefix).Append("detailLevel").Append("=").Append(EnumUtils.GetDescription(detailLevel));
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
	public partial class ResponseEnvelope	{

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



		public static ResponseEnvelope CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			ResponseEnvelope responseEnvelope = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "timestamp";
			if (map.ContainsKey(key))
			{
				responseEnvelope = (responseEnvelope == null) ? new ResponseEnvelope() : responseEnvelope;
				responseEnvelope.timestamp = map[key];
			}
			key = prefix + "ack";
			if (map.ContainsKey(key))
			{
				responseEnvelope = (responseEnvelope == null) ? new ResponseEnvelope() : responseEnvelope;
				responseEnvelope.ack = (AckCode)EnumUtils.GetValue(map[key],typeof(AckCode));
			}
			key = prefix + "correlationId";
			if (map.ContainsKey(key))
			{
				responseEnvelope = (responseEnvelope == null) ? new ResponseEnvelope() : responseEnvelope;
				responseEnvelope.correlationId = map[key];
			}
			key = prefix + "build";
			if (map.ContainsKey(key))
			{
				responseEnvelope = (responseEnvelope == null) ? new ResponseEnvelope() : responseEnvelope;
				responseEnvelope.build = map[key];
			}
			return responseEnvelope;
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
    [Serializable]
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
    [Serializable]
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
    [Serializable]
	public enum DetailLevelCode {
		[Description("ReturnAll")]RETURNALL	
	}




	/**
      *
      */
    [Serializable]
	public enum ErrorCategory {
		[Description("System")]SYSTEM,	
		[Description("Application")]APPLICATION,	
		[Description("Request")]REQUEST	
	}




	/**
      *
      */
    [Serializable]
	public enum ErrorSeverity {
		[Description("Error")]ERROR,	
		[Description("Warning")]WARNING	
	}




	/**
      *
      */
	public partial class Address	{

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



		public static Address CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			Address address = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "addresseeName";
			if (map.ContainsKey(key))
			{
				address = (address == null) ? new Address() : address;
				address.addresseeName = map[key];
			}
			BaseAddress baseAddress =  BaseAddress.CreateInstance(map, prefix + "baseAddress", -1);
			if (baseAddress != null)
			{
				address = (address == null) ? new Address() : address;
				address.baseAddress = baseAddress;
			}
			key = prefix + "addressId";
			if (map.ContainsKey(key))
			{
				address = (address == null) ? new Address() : address;
				address.addressId = map[key];
			}
			return address;
		}
	}




	/**
      *
      */
	public partial class AddressList	{

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



		public static AddressList CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			AddressList addressList = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			i = 0;
			while(true)
			{
				Address address =  Address.CreateInstance(map, prefix + "address", i);
				if (address != null)
				{
					addressList = (addressList == null) ? new AddressList() : addressList;
					addressList.address.Add(address);
					i++;
				} 
				else
				{
					break;
				}
			}
			return addressList;
		}
	}




	/**
      *A list of ISO currency codes. 
      */
	public partial class CurrencyCodeList	{

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


		public string ToNVPString(string prefix)
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
	public partial class CurrencyConversionList	{

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



		public static CurrencyConversionList CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			CurrencyConversionList currencyConversionList = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			CurrencyType baseAmount =  CurrencyType.CreateInstance(map, prefix + "baseAmount", -1);
			if (baseAmount != null)
			{
				currencyConversionList = (currencyConversionList == null) ? new CurrencyConversionList() : currencyConversionList;
				currencyConversionList.baseAmount = baseAmount;
			}
			CurrencyList currencyList =  CurrencyList.CreateInstance(map, prefix + "currencyList", -1);
			if (currencyList != null)
			{
				currencyConversionList = (currencyConversionList == null) ? new CurrencyConversionList() : currencyConversionList;
				currencyConversionList.currencyList = currencyList;
			}
			return currencyConversionList;
		}
	}




	/**
      *A table that contains a list of estimated currency
      *conversions for a base currency in each row. 
      */
	public partial class CurrencyConversionTable	{

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



		public static CurrencyConversionTable CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			CurrencyConversionTable currencyConversionTable = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			i = 0;
			while(true)
			{
				CurrencyConversionList currencyConversionList =  CurrencyConversionList.CreateInstance(map, prefix + "currencyConversionList", i);
				if (currencyConversionList != null)
				{
					currencyConversionTable = (currencyConversionTable == null) ? new CurrencyConversionTable() : currencyConversionTable;
					currencyConversionTable.currencyConversionList.Add(currencyConversionList);
					i++;
				} 
				else
				{
					break;
				}
			}
			return currencyConversionTable;
		}
	}




	/**
      *A list of ISO currencies. 
      */
	public partial class CurrencyList	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < this.currency.Count; i++)
			{
				if (this.currency[i] != null)
				{
					string newPrefix = prefix + "currency" + "(" + i + ").";
					sb.Append(this.currency[i].ToNVPString(newPrefix));
				}
			}
			return sb.ToString();
		}

		public static CurrencyList CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			CurrencyList currencyList = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			i = 0;
			while(true)
			{
				CurrencyType currency =  CurrencyType.CreateInstance(map, prefix + "currency", i);
				if (currency != null)
				{
					currencyList = (currencyList == null) ? new CurrencyList() : currencyList;
					currencyList.currency.Add(currency);
					i++;
				} 
				else
				{
					break;
				}
			}
			return currencyList;
		}
	}




	/**
      *Customizable options that a client application can specify
      *for display purposes. 
      */
	public partial class DisplayOptions	{

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


		public string ToNVPString(string prefix)
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

		public static DisplayOptions CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			DisplayOptions displayOptions = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "emailHeaderImageUrl";
			if (map.ContainsKey(key))
			{
				displayOptions = (displayOptions == null) ? new DisplayOptions() : displayOptions;
				displayOptions.emailHeaderImageUrl = map[key];
			}
			key = prefix + "emailMarketingImageUrl";
			if (map.ContainsKey(key))
			{
				displayOptions = (displayOptions == null) ? new DisplayOptions() : displayOptions;
				displayOptions.emailMarketingImageUrl = map[key];
			}
			key = prefix + "headerImageUrl";
			if (map.ContainsKey(key))
			{
				displayOptions = (displayOptions == null) ? new DisplayOptions() : displayOptions;
				displayOptions.headerImageUrl = map[key];
			}
			key = prefix + "businessName";
			if (map.ContainsKey(key))
			{
				displayOptions = (displayOptions == null) ? new DisplayOptions() : displayOptions;
				displayOptions.businessName = map[key];
			}
			return displayOptions;
		}
	}




	/**
      *
      */
	public partial class ErrorList	{

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



		public static ErrorList CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			ErrorList errorList = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					errorList = (errorList == null) ? new ErrorList() : errorList;
					errorList.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return errorList;
		}
	}




	/**
      *
      */
	public partial class FundingConstraint	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.allowedFundingType != null)
			{
					string newPrefix = prefix + "allowedFundingType" + ".";
					sb.Append(this.allowedFundingTypeField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}

		public static FundingConstraint CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			FundingConstraint fundingConstraint = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			FundingTypeList allowedFundingType =  FundingTypeList.CreateInstance(map, prefix + "allowedFundingType", -1);
			if (allowedFundingType != null)
			{
				fundingConstraint = (fundingConstraint == null) ? new FundingConstraint() : fundingConstraint;
				fundingConstraint.allowedFundingType = allowedFundingType;
			}
			return fundingConstraint;
		}
	}




	/**
      *FundingTypeInfo represents one allowed funding type. 
      */
	public partial class FundingTypeInfo	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.fundingType != null)
			{
					sb.Append(prefix).Append("fundingType").Append("=").Append(HttpUtility.UrlEncode(this.fundingType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}

		public static FundingTypeInfo CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			FundingTypeInfo fundingTypeInfo = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "fundingType";
			if (map.ContainsKey(key))
			{
				fundingTypeInfo = (fundingTypeInfo == null) ? new FundingTypeInfo() : fundingTypeInfo;
				fundingTypeInfo.fundingType = map[key];
			}
			return fundingTypeInfo;
		}
	}




	/**
      *
      */
	public partial class FundingTypeList	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < this.fundingTypeInfo.Count; i++)
			{
				if (this.fundingTypeInfo[i] != null)
				{
					string newPrefix = prefix + "fundingTypeInfo" + "(" + i + ").";
					sb.Append(this.fundingTypeInfo[i].ToNVPString(newPrefix));
				}
			}
			return sb.ToString();
		}

		public static FundingTypeList CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			FundingTypeList fundingTypeList = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			i = 0;
			while(true)
			{
				FundingTypeInfo fundingTypeInfo =  FundingTypeInfo.CreateInstance(map, prefix + "fundingTypeInfo", i);
				if (fundingTypeInfo != null)
				{
					fundingTypeList = (fundingTypeList == null) ? new FundingTypeList() : fundingTypeList;
					fundingTypeList.fundingTypeInfo.Add(fundingTypeInfo);
					i++;
				} 
				else
				{
					break;
				}
			}
			return fundingTypeList;
		}
	}




	/**
      *Describes the conversion between 2 currencies. 
      */
	public partial class CurrencyConversion	{

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



		public static CurrencyConversion CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			CurrencyConversion currencyConversion = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			CurrencyType from =  CurrencyType.CreateInstance(map, prefix + "from", -1);
			if (from != null)
			{
				currencyConversion = (currencyConversion == null) ? new CurrencyConversion() : currencyConversion;
				currencyConversion.from = from;
			}
			CurrencyType to =  CurrencyType.CreateInstance(map, prefix + "to", -1);
			if (to != null)
			{
				currencyConversion = (currencyConversion == null) ? new CurrencyConversion() : currencyConversion;
				currencyConversion.to = to;
			}
			key = prefix + "exchangeRate";
			if (map.ContainsKey(key))
			{
				currencyConversion = (currencyConversion == null) ? new CurrencyConversion() : currencyConversion;
				currencyConversion.exchangeRate = System.Convert.ToDecimal(map[key]);
			}
			return currencyConversion;
		}
	}




	/**
      *Funding source information. 
      */
	public partial class FundingSource	{

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



		public static FundingSource CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			FundingSource fundingSource = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "lastFourOfAccountNumber";
			if (map.ContainsKey(key))
			{
				fundingSource = (fundingSource == null) ? new FundingSource() : fundingSource;
				fundingSource.lastFourOfAccountNumber = map[key];
			}
			key = prefix + "type";
			if (map.ContainsKey(key))
			{
				fundingSource = (fundingSource == null) ? new FundingSource() : fundingSource;
				fundingSource.type = map[key];
			}
			key = prefix + "displayName";
			if (map.ContainsKey(key))
			{
				fundingSource = (fundingSource == null) ? new FundingSource() : fundingSource;
				fundingSource.displayName = map[key];
			}
			key = prefix + "fundingSourceId";
			if (map.ContainsKey(key))
			{
				fundingSource = (fundingSource == null) ? new FundingSource() : fundingSource;
				fundingSource.fundingSourceId = map[key];
			}
			key = prefix + "allowed";
			if (map.ContainsKey(key))
			{
				fundingSource = (fundingSource == null) ? new FundingSource() : fundingSource;
				fundingSource.allowed = System.Convert.ToBoolean(map[key]);
			}
			return fundingSource;
		}
	}




	/**
      *Amount to be charged to a particular funding source. 
      */
	public partial class FundingPlanCharge	{

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



		public static FundingPlanCharge CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			FundingPlanCharge fundingPlanCharge = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			CurrencyType charge =  CurrencyType.CreateInstance(map, prefix + "charge", -1);
			if (charge != null)
			{
				fundingPlanCharge = (fundingPlanCharge == null) ? new FundingPlanCharge() : fundingPlanCharge;
				fundingPlanCharge.charge = charge;
			}
			FundingSource fundingSource =  FundingSource.CreateInstance(map, prefix + "fundingSource", -1);
			if (fundingSource != null)
			{
				fundingPlanCharge = (fundingPlanCharge == null) ? new FundingPlanCharge() : fundingPlanCharge;
				fundingPlanCharge.fundingSource = fundingSource;
			}
			return fundingPlanCharge;
		}
	}




	/**
      *FundingPlan describes the funding sources to be used for a
      *specific payment. 
      */
	public partial class FundingPlan	{

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



		public static FundingPlan CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			FundingPlan fundingPlan = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "fundingPlanId";
			if (map.ContainsKey(key))
			{
				fundingPlan = (fundingPlan == null) ? new FundingPlan() : fundingPlan;
				fundingPlan.fundingPlanId = map[key];
			}
			CurrencyType fundingAmount =  CurrencyType.CreateInstance(map, prefix + "fundingAmount", -1);
			if (fundingAmount != null)
			{
				fundingPlan = (fundingPlan == null) ? new FundingPlan() : fundingPlan;
				fundingPlan.fundingAmount = fundingAmount;
			}
			FundingSource backupFundingSource =  FundingSource.CreateInstance(map, prefix + "backupFundingSource", -1);
			if (backupFundingSource != null)
			{
				fundingPlan = (fundingPlan == null) ? new FundingPlan() : fundingPlan;
				fundingPlan.backupFundingSource = backupFundingSource;
			}
			CurrencyType senderFees =  CurrencyType.CreateInstance(map, prefix + "senderFees", -1);
			if (senderFees != null)
			{
				fundingPlan = (fundingPlan == null) ? new FundingPlan() : fundingPlan;
				fundingPlan.senderFees = senderFees;
			}
			CurrencyConversion currencyConversion =  CurrencyConversion.CreateInstance(map, prefix + "currencyConversion", -1);
			if (currencyConversion != null)
			{
				fundingPlan = (fundingPlan == null) ? new FundingPlan() : fundingPlan;
				fundingPlan.currencyConversion = currencyConversion;
			}
			i = 0;
			while(true)
			{
				FundingPlanCharge charge =  FundingPlanCharge.CreateInstance(map, prefix + "charge", i);
				if (charge != null)
				{
					fundingPlan = (fundingPlan == null) ? new FundingPlan() : fundingPlan;
					fundingPlan.charge.Add(charge);
					i++;
				} 
				else
				{
					break;
				}
			}
			return fundingPlan;
		}
	}




	/**
      *Details about the party that initiated this payment. The API
      *user is making this payment on behalf of the initiator. The
      *initiator can simply be an institution or a customer of the
      *institution. 
      */
	public partial class InitiatingEntity	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.institutionCustomer != null)
			{
					string newPrefix = prefix + "institutionCustomer" + ".";
					sb.Append(this.institutionCustomerField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}

		public static InitiatingEntity CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			InitiatingEntity initiatingEntity = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			InstitutionCustomer institutionCustomer =  InstitutionCustomer.CreateInstance(map, prefix + "institutionCustomer", -1);
			if (institutionCustomer != null)
			{
				initiatingEntity = (initiatingEntity == null) ? new InitiatingEntity() : initiatingEntity;
				initiatingEntity.institutionCustomer = institutionCustomer;
			}
			return initiatingEntity;
		}
	}




	/**
      *The customer of the initiating institution 
      */
	public partial class InstitutionCustomer	{

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


		public string ToNVPString(string prefix)
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

		public static InstitutionCustomer CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			InstitutionCustomer institutionCustomer = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "institutionId";
			if (map.ContainsKey(key))
			{
				institutionCustomer = (institutionCustomer == null) ? new InstitutionCustomer() : institutionCustomer;
				institutionCustomer.institutionId = map[key];
			}
			key = prefix + "firstName";
			if (map.ContainsKey(key))
			{
				institutionCustomer = (institutionCustomer == null) ? new InstitutionCustomer() : institutionCustomer;
				institutionCustomer.firstName = map[key];
			}
			key = prefix + "lastName";
			if (map.ContainsKey(key))
			{
				institutionCustomer = (institutionCustomer == null) ? new InstitutionCustomer() : institutionCustomer;
				institutionCustomer.lastName = map[key];
			}
			key = prefix + "displayName";
			if (map.ContainsKey(key))
			{
				institutionCustomer = (institutionCustomer == null) ? new InstitutionCustomer() : institutionCustomer;
				institutionCustomer.displayName = map[key];
			}
			key = prefix + "institutionCustomerId";
			if (map.ContainsKey(key))
			{
				institutionCustomer = (institutionCustomer == null) ? new InstitutionCustomer() : institutionCustomer;
				institutionCustomer.institutionCustomerId = map[key];
			}
			key = prefix + "countryCode";
			if (map.ContainsKey(key))
			{
				institutionCustomer = (institutionCustomer == null) ? new InstitutionCustomer() : institutionCustomer;
				institutionCustomer.countryCode = map[key];
			}
			key = prefix + "email";
			if (map.ContainsKey(key))
			{
				institutionCustomer = (institutionCustomer == null) ? new InstitutionCustomer() : institutionCustomer;
				institutionCustomer.email = map[key];
			}
			return institutionCustomer;
		}
	}




	/**
      *Describes an individual item for an invoice. 
      */
	public partial class InvoiceItem	{

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


		public string ToNVPString(string prefix)
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

		public static InvoiceItem CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			InvoiceItem invoiceItem = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "name";
			if (map.ContainsKey(key))
			{
				invoiceItem = (invoiceItem == null) ? new InvoiceItem() : invoiceItem;
				invoiceItem.name = map[key];
			}
			key = prefix + "identifier";
			if (map.ContainsKey(key))
			{
				invoiceItem = (invoiceItem == null) ? new InvoiceItem() : invoiceItem;
				invoiceItem.identifier = map[key];
			}
			key = prefix + "price";
			if (map.ContainsKey(key))
			{
				invoiceItem = (invoiceItem == null) ? new InvoiceItem() : invoiceItem;
				invoiceItem.price = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "itemPrice";
			if (map.ContainsKey(key))
			{
				invoiceItem = (invoiceItem == null) ? new InvoiceItem() : invoiceItem;
				invoiceItem.itemPrice = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "itemCount";
			if (map.ContainsKey(key))
			{
				invoiceItem = (invoiceItem == null) ? new InvoiceItem() : invoiceItem;
				invoiceItem.itemCount = System.Convert.ToInt32(map[key]);
			}
			return invoiceItem;
		}
	}




	/**
      *Describes a payment for a particular receiver (merchant),
      *contains list of additional per item details. 
      */
	public partial class InvoiceData	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < this.item.Count; i++)
			{
				if (this.item[i] != null)
				{
					string newPrefix = prefix + "item" + "(" + i + ").";
					sb.Append(this.item[i].ToNVPString(newPrefix));
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

		public static InvoiceData CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			InvoiceData invoiceData = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			i = 0;
			while(true)
			{
				InvoiceItem item =  InvoiceItem.CreateInstance(map, prefix + "item", i);
				if (item != null)
				{
					invoiceData = (invoiceData == null) ? new InvoiceData() : invoiceData;
					invoiceData.item.Add(item);
					i++;
				} 
				else
				{
					break;
				}
			}
			key = prefix + "totalTax";
			if (map.ContainsKey(key))
			{
				invoiceData = (invoiceData == null) ? new InvoiceData() : invoiceData;
				invoiceData.totalTax = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "totalShipping";
			if (map.ContainsKey(key))
			{
				invoiceData = (invoiceData == null) ? new InvoiceData() : invoiceData;
				invoiceData.totalShipping = System.Convert.ToDecimal(map[key]);
			}
			return invoiceData;
		}
	}




	/**
      *The error that resulted from an attempt to make a payment to
      *a receiver. 
      */
	public partial class PayError	{

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



		public static PayError CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			PayError payError = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			Receiver receiver =  Receiver.CreateInstance(map, prefix + "receiver", -1);
			if (receiver != null)
			{
				payError = (payError == null) ? new PayError() : payError;
				payError.receiver = receiver;
			}
			ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", -1);
			if (error != null)
			{
				payError = (payError == null) ? new PayError() : payError;
				payError.error = error;
			}
			return payError;
		}
	}




	/**
      *
      */
	public partial class PayErrorList	{

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



		public static PayErrorList CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			PayErrorList payErrorList = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			i = 0;
			while(true)
			{
				PayError payError =  PayError.CreateInstance(map, prefix + "payError", i);
				if (payError != null)
				{
					payErrorList = (payErrorList == null) ? new PayErrorList() : payErrorList;
					payErrorList.payError.Add(payError);
					i++;
				} 
				else
				{
					break;
				}
			}
			return payErrorList;
		}
	}




	/**
      *PaymentInfo represents the payment attempt made to a
      *Receiver of a PayRequest. If the execution of the payment
      *has not yet completed, there will not be any transaction
      *details. 
      */
	public partial class PaymentInfo	{

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



		public static PaymentInfo CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			PaymentInfo paymentInfo = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "transactionId";
			if (map.ContainsKey(key))
			{
				paymentInfo = (paymentInfo == null) ? new PaymentInfo() : paymentInfo;
				paymentInfo.transactionId = map[key];
			}
			key = prefix + "transactionStatus";
			if (map.ContainsKey(key))
			{
				paymentInfo = (paymentInfo == null) ? new PaymentInfo() : paymentInfo;
				paymentInfo.transactionStatus = map[key];
			}
			Receiver receiver =  Receiver.CreateInstance(map, prefix + "receiver", -1);
			if (receiver != null)
			{
				paymentInfo = (paymentInfo == null) ? new PaymentInfo() : paymentInfo;
				paymentInfo.receiver = receiver;
			}
			key = prefix + "refundedAmount";
			if (map.ContainsKey(key))
			{
				paymentInfo = (paymentInfo == null) ? new PaymentInfo() : paymentInfo;
				paymentInfo.refundedAmount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "pendingRefund";
			if (map.ContainsKey(key))
			{
				paymentInfo = (paymentInfo == null) ? new PaymentInfo() : paymentInfo;
				paymentInfo.pendingRefund = System.Convert.ToBoolean(map[key]);
			}
			key = prefix + "senderTransactionId";
			if (map.ContainsKey(key))
			{
				paymentInfo = (paymentInfo == null) ? new PaymentInfo() : paymentInfo;
				paymentInfo.senderTransactionId = map[key];
			}
			key = prefix + "senderTransactionStatus";
			if (map.ContainsKey(key))
			{
				paymentInfo = (paymentInfo == null) ? new PaymentInfo() : paymentInfo;
				paymentInfo.senderTransactionStatus = map[key];
			}
			key = prefix + "pendingReason";
			if (map.ContainsKey(key))
			{
				paymentInfo = (paymentInfo == null) ? new PaymentInfo() : paymentInfo;
				paymentInfo.pendingReason = map[key];
			}
			return paymentInfo;
		}
	}




	/**
      *
      */
	public partial class PaymentInfoList	{

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



		public static PaymentInfoList CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			PaymentInfoList paymentInfoList = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			i = 0;
			while(true)
			{
				PaymentInfo paymentInfo =  PaymentInfo.CreateInstance(map, prefix + "paymentInfo", i);
				if (paymentInfo != null)
				{
					paymentInfoList = (paymentInfoList == null) ? new PaymentInfoList() : paymentInfoList;
					paymentInfoList.paymentInfo.Add(paymentInfo);
					i++;
				} 
				else
				{
					break;
				}
			}
			return paymentInfoList;
		}
	}




	/**
      *Receiver is the party where funds are transferred to. A
      *primary receiver receives a payment directly from the sender
      *in a chained split payment. A primary receiver should not be
      *specified when making a single or parallel split payment. 
      */
	public partial class Receiver	{

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


		public string ToNVPString(string prefix)
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
					sb.Append(this.phoneField.ToNVPString(newPrefix));
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

		public static Receiver CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			Receiver receiver = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "amount";
			if (map.ContainsKey(key))
			{
				receiver = (receiver == null) ? new Receiver() : receiver;
				receiver.amount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "email";
			if (map.ContainsKey(key))
			{
				receiver = (receiver == null) ? new Receiver() : receiver;
				receiver.email = map[key];
			}
			PhoneNumberType phone =  PhoneNumberType.CreateInstance(map, prefix + "phone", -1);
			if (phone != null)
			{
				receiver = (receiver == null) ? new Receiver() : receiver;
				receiver.phone = phone;
			}
			key = prefix + "primary";
			if (map.ContainsKey(key))
			{
				receiver = (receiver == null) ? new Receiver() : receiver;
				receiver.primary = System.Convert.ToBoolean(map[key]);
			}
			key = prefix + "invoiceId";
			if (map.ContainsKey(key))
			{
				receiver = (receiver == null) ? new Receiver() : receiver;
				receiver.invoiceId = map[key];
			}
			key = prefix + "paymentType";
			if (map.ContainsKey(key))
			{
				receiver = (receiver == null) ? new Receiver() : receiver;
				receiver.paymentType = map[key];
			}
			key = prefix + "paymentSubType";
			if (map.ContainsKey(key))
			{
				receiver = (receiver == null) ? new Receiver() : receiver;
				receiver.paymentSubType = map[key];
			}
			return receiver;
		}
	}




	/**
      *
      */
	public partial class ReceiverList	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < this.receiver.Count; i++)
			{
				if (this.receiver[i] != null)
				{
					string newPrefix = prefix + "receiver" + "(" + i + ").";
					sb.Append(this.receiver[i].ToNVPString(newPrefix));
				}
			}
			return sb.ToString();
		}
	}




	/**
      *The sender identifier type contains information to identify
      *a PayPal account. 
      */
	public partial class ReceiverIdentifier : AccountIdentifier	{

		/**
	 	  * Default Constructor
	 	  */
	 	public ReceiverIdentifier(){
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(base.ToNVPString(prefix));
			return sb.ToString();
		}

		public static ReceiverIdentifier CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			ReceiverIdentifier receiverIdentifier = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			AccountIdentifier accountIdentifier = AccountIdentifier.CreateInstance(map, prefix, index);
			if (accountIdentifier != null)
			{
				receiverIdentifier = (receiverIdentifier == null) ? new ReceiverIdentifier() : receiverIdentifier;
				receiverIdentifier.email = accountIdentifier.email;
				receiverIdentifier.phone = accountIdentifier.phone;
			}
			return receiverIdentifier;
		}
	}




	/**
      *Options that apply to the receiver of a payment, allows
      *setting additional details for payment using invoice. 
      */
	public partial class ReceiverOptions	{

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


		public string ToNVPString(string prefix)
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
					sb.Append(this.invoiceDataField.ToNVPString(newPrefix));
			}
			if (this.receiver != null)
			{
					string newPrefix = prefix + "receiver" + ".";
					sb.Append(this.receiverField.ToNVPString(newPrefix));
			}
			if (this.referrerCode != null)
			{
					sb.Append(prefix).Append("referrerCode").Append("=").Append(HttpUtility.UrlEncode(this.referrerCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}

		public static ReceiverOptions CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			ReceiverOptions receiverOptions = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "description";
			if (map.ContainsKey(key))
			{
				receiverOptions = (receiverOptions == null) ? new ReceiverOptions() : receiverOptions;
				receiverOptions.description = map[key];
			}
			key = prefix + "customId";
			if (map.ContainsKey(key))
			{
				receiverOptions = (receiverOptions == null) ? new ReceiverOptions() : receiverOptions;
				receiverOptions.customId = map[key];
			}
			InvoiceData invoiceData =  InvoiceData.CreateInstance(map, prefix + "invoiceData", -1);
			if (invoiceData != null)
			{
				receiverOptions = (receiverOptions == null) ? new ReceiverOptions() : receiverOptions;
				receiverOptions.invoiceData = invoiceData;
			}
			ReceiverIdentifier receiver =  ReceiverIdentifier.CreateInstance(map, prefix + "receiver", -1);
			if (receiver != null)
			{
				receiverOptions = (receiverOptions == null) ? new ReceiverOptions() : receiverOptions;
				receiverOptions.receiver = receiver;
			}
			key = prefix + "referrerCode";
			if (map.ContainsKey(key))
			{
				receiverOptions = (receiverOptions == null) ? new ReceiverOptions() : receiverOptions;
				receiverOptions.referrerCode = map[key];
			}
			return receiverOptions;
		}
	}




	/**
      *RefundInfo represents the refund attempt made to a Receiver
      *of a PayRequest. 
      */
	public partial class RefundInfo	{

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



		public static RefundInfo CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			RefundInfo refundInfo = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			Receiver receiver =  Receiver.CreateInstance(map, prefix + "receiver", -1);
			if (receiver != null)
			{
				refundInfo = (refundInfo == null) ? new RefundInfo() : refundInfo;
				refundInfo.receiver = receiver;
			}
			key = prefix + "refundStatus";
			if (map.ContainsKey(key))
			{
				refundInfo = (refundInfo == null) ? new RefundInfo() : refundInfo;
				refundInfo.refundStatus = map[key];
			}
			key = prefix + "refundNetAmount";
			if (map.ContainsKey(key))
			{
				refundInfo = (refundInfo == null) ? new RefundInfo() : refundInfo;
				refundInfo.refundNetAmount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "refundFeeAmount";
			if (map.ContainsKey(key))
			{
				refundInfo = (refundInfo == null) ? new RefundInfo() : refundInfo;
				refundInfo.refundFeeAmount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "refundGrossAmount";
			if (map.ContainsKey(key))
			{
				refundInfo = (refundInfo == null) ? new RefundInfo() : refundInfo;
				refundInfo.refundGrossAmount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "totalOfAllRefunds";
			if (map.ContainsKey(key))
			{
				refundInfo = (refundInfo == null) ? new RefundInfo() : refundInfo;
				refundInfo.totalOfAllRefunds = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "refundHasBecomeFull";
			if (map.ContainsKey(key))
			{
				refundInfo = (refundInfo == null) ? new RefundInfo() : refundInfo;
				refundInfo.refundHasBecomeFull = System.Convert.ToBoolean(map[key]);
			}
			key = prefix + "encryptedRefundTransactionId";
			if (map.ContainsKey(key))
			{
				refundInfo = (refundInfo == null) ? new RefundInfo() : refundInfo;
				refundInfo.encryptedRefundTransactionId = map[key];
			}
			key = prefix + "refundTransactionStatus";
			if (map.ContainsKey(key))
			{
				refundInfo = (refundInfo == null) ? new RefundInfo() : refundInfo;
				refundInfo.refundTransactionStatus = map[key];
			}
			ErrorList errorList =  ErrorList.CreateInstance(map, prefix + "errorList", -1);
			if (errorList != null)
			{
				refundInfo = (refundInfo == null) ? new RefundInfo() : refundInfo;
				refundInfo.errorList = errorList;
			}
			return refundInfo;
		}
	}




	/**
      *
      */
	public partial class RefundInfoList	{

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



		public static RefundInfoList CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			RefundInfoList refundInfoList = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			i = 0;
			while(true)
			{
				RefundInfo refundInfo =  RefundInfo.CreateInstance(map, prefix + "refundInfo", i);
				if (refundInfo != null)
				{
					refundInfoList = (refundInfoList == null) ? new RefundInfoList() : refundInfoList;
					refundInfoList.refundInfo.Add(refundInfo);
					i++;
				} 
				else
				{
					break;
				}
			}
			return refundInfoList;
		}
	}




	/**
      *Options that apply to the sender of a payment. 
      */
	public partial class SenderOptions	{

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


		public string ToNVPString(string prefix)
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

		public static SenderOptions CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			SenderOptions senderOptions = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "requireShippingAddressSelection";
			if (map.ContainsKey(key))
			{
				senderOptions = (senderOptions == null) ? new SenderOptions() : senderOptions;
				senderOptions.requireShippingAddressSelection = System.Convert.ToBoolean(map[key]);
			}
			key = prefix + "referrerCode";
			if (map.ContainsKey(key))
			{
				senderOptions = (senderOptions == null) ? new SenderOptions() : senderOptions;
				senderOptions.referrerCode = map[key];
			}
			return senderOptions;
		}
	}




	/**
      *Details about the payer's tax info passed in by the merchant
      *or partner. 
      */
	public partial class TaxIdDetails	{

		/**
          *
		  */
		private string taxIdField;
		public string taxId
		{
			get
			{
				return this.taxIdField;
			}
			set
			{
				this.taxIdField = value;
			}
		}
		

		/**
          *
		  */
		private string taxIdTypeField;
		public string taxIdType
		{
			get
			{
				return this.taxIdTypeField;
			}
			set
			{
				this.taxIdTypeField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public TaxIdDetails(){
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.taxId != null)
			{
					sb.Append(prefix).Append("taxId").Append("=").Append(HttpUtility.UrlEncode(this.taxId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.taxIdType != null)
			{
					sb.Append(prefix).Append("taxIdType").Append("=").Append(HttpUtility.UrlEncode(this.taxIdType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}

		public static TaxIdDetails CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			TaxIdDetails taxIdDetails = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "taxId";
			if (map.ContainsKey(key))
			{
				taxIdDetails = (taxIdDetails == null) ? new TaxIdDetails() : taxIdDetails;
				taxIdDetails.taxId = map[key];
			}
			key = prefix + "taxIdType";
			if (map.ContainsKey(key))
			{
				taxIdDetails = (taxIdDetails == null) ? new TaxIdDetails() : taxIdDetails;
				taxIdDetails.taxIdType = map[key];
			}
			return taxIdDetails;
		}
	}




	/**
      *The sender identifier type contains information to identify
      *a PayPal account. 
      */
	public partial class SenderIdentifier : AccountIdentifier	{

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
          *
		  */
		private TaxIdDetails taxIdDetailsField;
		public TaxIdDetails taxIdDetails
		{
			get
			{
				return this.taxIdDetailsField;
			}
			set
			{
				this.taxIdDetailsField = value;
			}
		}
		

		/**
	 	  * Default Constructor
	 	  */
	 	public SenderIdentifier(){
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(base.ToNVPString(prefix));
			if (this.useCredentials != null)
			{
					sb.Append(prefix).Append("useCredentials").Append("=").Append(this.useCredentials).Append("&");
			}
			if (this.taxIdDetails != null)
			{
					string newPrefix = prefix + "taxIdDetails" + ".";
					sb.Append(this.taxIdDetailsField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}

		public static SenderIdentifier CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			SenderIdentifier senderIdentifier = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			AccountIdentifier accountIdentifier = AccountIdentifier.CreateInstance(map, prefix, index);
			if (accountIdentifier != null)
			{
				senderIdentifier = (senderIdentifier == null) ? new SenderIdentifier() : senderIdentifier;
				senderIdentifier.email = accountIdentifier.email;
				senderIdentifier.phone = accountIdentifier.phone;
			}
			key = prefix + "useCredentials";
			if (map.ContainsKey(key))
			{
				senderIdentifier = (senderIdentifier == null) ? new SenderIdentifier() : senderIdentifier;
				senderIdentifier.useCredentials = System.Convert.ToBoolean(map[key]);
			}
			TaxIdDetails taxIdDetails =  TaxIdDetails.CreateInstance(map, prefix + "taxIdDetails", -1);
			if (taxIdDetails != null)
			{
				senderIdentifier = (senderIdentifier == null) ? new SenderIdentifier() : senderIdentifier;
				senderIdentifier.taxIdDetails = taxIdDetails;
			}
			return senderIdentifier;
		}
	}




	/**
      *
      */
	public partial class UserLimit	{

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



		public static UserLimit CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			UserLimit userLimit = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "limitType";
			if (map.ContainsKey(key))
			{
				userLimit = (userLimit == null) ? new UserLimit() : userLimit;
				userLimit.limitType = map[key];
			}
			CurrencyType limitAmount =  CurrencyType.CreateInstance(map, prefix + "limitAmount", -1);
			if (limitAmount != null)
			{
				userLimit = (userLimit == null) ? new UserLimit() : userLimit;
				userLimit.limitAmount = limitAmount;
			}
			return userLimit;
		}
	}




	/**
      *This type contains the detailed warning information
      *resulting from the service operation. 
      */
	public partial class WarningData	{

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



		public static WarningData CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			WarningData warningData = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "warningId";
			if (map.ContainsKey(key))
			{
				warningData = (warningData == null) ? new WarningData() : warningData;
				warningData.warningId = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "message";
			if (map.ContainsKey(key))
			{
				warningData = (warningData == null) ? new WarningData() : warningData;
				warningData.message = map[key];
			}
			return warningData;
		}
	}




	/**
      *
      */
	public partial class WarningDataList	{

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



		public static WarningDataList CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			WarningDataList warningDataList = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			i = 0;
			while(true)
			{
				WarningData warningData =  WarningData.CreateInstance(map, prefix + "warningData", i);
				if (warningData != null)
				{
					warningDataList = (warningDataList == null) ? new WarningDataList() : warningDataList;
					warningDataList.warningData.Add(warningData);
					i++;
				} 
				else
				{
					break;
				}
			}
			return warningDataList;
		}
	}




	/**
      *The request to cancel a Preapproval. 
      */
	public partial class CancelPreapprovalRequest	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
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
	public partial class CancelPreapprovalResponse	{

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



		public static CancelPreapprovalResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			CancelPreapprovalResponse cancelPreapprovalResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				cancelPreapprovalResponse = (cancelPreapprovalResponse == null) ? new CancelPreapprovalResponse() : cancelPreapprovalResponse;
				cancelPreapprovalResponse.responseEnvelope = responseEnvelope;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					cancelPreapprovalResponse = (cancelPreapprovalResponse == null) ? new CancelPreapprovalResponse() : cancelPreapprovalResponse;
					cancelPreapprovalResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return cancelPreapprovalResponse;
		}
	}




	/**
      *The request to confirm a Preapproval. 
      */
	public partial class ConfirmPreapprovalRequest	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
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
	public partial class ConfirmPreapprovalResponse	{

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



		public static ConfirmPreapprovalResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			ConfirmPreapprovalResponse confirmPreapprovalResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				confirmPreapprovalResponse = (confirmPreapprovalResponse == null) ? new ConfirmPreapprovalResponse() : confirmPreapprovalResponse;
				confirmPreapprovalResponse.responseEnvelope = responseEnvelope;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					confirmPreapprovalResponse = (confirmPreapprovalResponse == null) ? new ConfirmPreapprovalResponse() : confirmPreapprovalResponse;
					confirmPreapprovalResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return confirmPreapprovalResponse;
		}
	}




	/**
      *A request to convert one or more currencies into their
      *estimated values in other currencies. 
      */
	public partial class ConvertCurrencyRequest	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.baseAmountList != null)
			{
					string newPrefix = prefix + "baseAmountList" + ".";
					sb.Append(this.baseAmountListField.ToNVPString(newPrefix));
			}
			if (this.convertToCurrencyList != null)
			{
					string newPrefix = prefix + "convertToCurrencyList" + ".";
					sb.Append(this.convertToCurrencyListField.ToNVPString(newPrefix));
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
	public partial class ConvertCurrencyResponse	{

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



		public static ConvertCurrencyResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			ConvertCurrencyResponse convertCurrencyResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				convertCurrencyResponse = (convertCurrencyResponse == null) ? new ConvertCurrencyResponse() : convertCurrencyResponse;
				convertCurrencyResponse.responseEnvelope = responseEnvelope;
			}
			CurrencyConversionTable estimatedAmountTable =  CurrencyConversionTable.CreateInstance(map, prefix + "estimatedAmountTable", -1);
			if (estimatedAmountTable != null)
			{
				convertCurrencyResponse = (convertCurrencyResponse == null) ? new ConvertCurrencyResponse() : convertCurrencyResponse;
				convertCurrencyResponse.estimatedAmountTable = estimatedAmountTable;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					convertCurrencyResponse = (convertCurrencyResponse == null) ? new ConvertCurrencyResponse() : convertCurrencyResponse;
					convertCurrencyResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return convertCurrencyResponse;
		}
	}




	/**
      *The request to execute the payment request. 
      */
	public partial class ExecutePaymentRequest	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
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
	public partial class ExecutePaymentResponse	{

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



		public static ExecutePaymentResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			ExecutePaymentResponse executePaymentResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				executePaymentResponse = (executePaymentResponse == null) ? new ExecutePaymentResponse() : executePaymentResponse;
				executePaymentResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "paymentExecStatus";
			if (map.ContainsKey(key))
			{
				executePaymentResponse = (executePaymentResponse == null) ? new ExecutePaymentResponse() : executePaymentResponse;
				executePaymentResponse.paymentExecStatus = map[key];
			}
			PayErrorList payErrorList =  PayErrorList.CreateInstance(map, prefix + "payErrorList", -1);
			if (payErrorList != null)
			{
				executePaymentResponse = (executePaymentResponse == null) ? new ExecutePaymentResponse() : executePaymentResponse;
				executePaymentResponse.payErrorList = payErrorList;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					executePaymentResponse = (executePaymentResponse == null) ? new ExecutePaymentResponse() : executePaymentResponse;
					executePaymentResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return executePaymentResponse;
		}
	}




	/**
      *The request to get the allowed funding sources available for
      *a preapproval. 
      */
	public partial class GetAllowedFundingSourcesRequest	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
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
	public partial class GetAllowedFundingSourcesResponse	{

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



		public static GetAllowedFundingSourcesResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			GetAllowedFundingSourcesResponse getAllowedFundingSourcesResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				getAllowedFundingSourcesResponse = (getAllowedFundingSourcesResponse == null) ? new GetAllowedFundingSourcesResponse() : getAllowedFundingSourcesResponse;
				getAllowedFundingSourcesResponse.responseEnvelope = responseEnvelope;
			}
			i = 0;
			while(true)
			{
				FundingSource fundingSource =  FundingSource.CreateInstance(map, prefix + "fundingSource", i);
				if (fundingSource != null)
				{
					getAllowedFundingSourcesResponse = (getAllowedFundingSourcesResponse == null) ? new GetAllowedFundingSourcesResponse() : getAllowedFundingSourcesResponse;
					getAllowedFundingSourcesResponse.fundingSource.Add(fundingSource);
					i++;
				} 
				else
				{
					break;
				}
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					getAllowedFundingSourcesResponse = (getAllowedFundingSourcesResponse == null) ? new GetAllowedFundingSourcesResponse() : getAllowedFundingSourcesResponse;
					getAllowedFundingSourcesResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return getAllowedFundingSourcesResponse;
		}
	}




	/**
      *The request to get the options of a payment request. 
      */
	public partial class GetPaymentOptionsRequest	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
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
	public partial class GetPaymentOptionsResponse	{

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



		public static GetPaymentOptionsResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			GetPaymentOptionsResponse getPaymentOptionsResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				getPaymentOptionsResponse = (getPaymentOptionsResponse == null) ? new GetPaymentOptionsResponse() : getPaymentOptionsResponse;
				getPaymentOptionsResponse.responseEnvelope = responseEnvelope;
			}
			InitiatingEntity initiatingEntity =  InitiatingEntity.CreateInstance(map, prefix + "initiatingEntity", -1);
			if (initiatingEntity != null)
			{
				getPaymentOptionsResponse = (getPaymentOptionsResponse == null) ? new GetPaymentOptionsResponse() : getPaymentOptionsResponse;
				getPaymentOptionsResponse.initiatingEntity = initiatingEntity;
			}
			DisplayOptions displayOptions =  DisplayOptions.CreateInstance(map, prefix + "displayOptions", -1);
			if (displayOptions != null)
			{
				getPaymentOptionsResponse = (getPaymentOptionsResponse == null) ? new GetPaymentOptionsResponse() : getPaymentOptionsResponse;
				getPaymentOptionsResponse.displayOptions = displayOptions;
			}
			key = prefix + "shippingAddressId";
			if (map.ContainsKey(key))
			{
				getPaymentOptionsResponse = (getPaymentOptionsResponse == null) ? new GetPaymentOptionsResponse() : getPaymentOptionsResponse;
				getPaymentOptionsResponse.shippingAddressId = map[key];
			}
			SenderOptions senderOptions =  SenderOptions.CreateInstance(map, prefix + "senderOptions", -1);
			if (senderOptions != null)
			{
				getPaymentOptionsResponse = (getPaymentOptionsResponse == null) ? new GetPaymentOptionsResponse() : getPaymentOptionsResponse;
				getPaymentOptionsResponse.senderOptions = senderOptions;
			}
			i = 0;
			while(true)
			{
				ReceiverOptions receiverOptions =  ReceiverOptions.CreateInstance(map, prefix + "receiverOptions", i);
				if (receiverOptions != null)
				{
					getPaymentOptionsResponse = (getPaymentOptionsResponse == null) ? new GetPaymentOptionsResponse() : getPaymentOptionsResponse;
					getPaymentOptionsResponse.receiverOptions.Add(receiverOptions);
					i++;
				} 
				else
				{
					break;
				}
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					getPaymentOptionsResponse = (getPaymentOptionsResponse == null) ? new GetPaymentOptionsResponse() : getPaymentOptionsResponse;
					getPaymentOptionsResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return getPaymentOptionsResponse;
		}
	}




	/**
      *The request to look up the details of a PayRequest. The
      *PaymentDetailsRequest can be made with either a payKey,
      *trackingId, or a transactionId of the PayRequest. 
      */
	public partial class PaymentDetailsRequest	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
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
	public partial class PaymentDetailsResponse	{

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



		public static PaymentDetailsResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			PaymentDetailsResponse paymentDetailsResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				paymentDetailsResponse = (paymentDetailsResponse == null) ? new PaymentDetailsResponse() : paymentDetailsResponse;
				paymentDetailsResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "cancelUrl";
			if (map.ContainsKey(key))
			{
				paymentDetailsResponse = (paymentDetailsResponse == null) ? new PaymentDetailsResponse() : paymentDetailsResponse;
				paymentDetailsResponse.cancelUrl = map[key];
			}
			key = prefix + "currencyCode";
			if (map.ContainsKey(key))
			{
				paymentDetailsResponse = (paymentDetailsResponse == null) ? new PaymentDetailsResponse() : paymentDetailsResponse;
				paymentDetailsResponse.currencyCode = map[key];
			}
			key = prefix + "ipnNotificationUrl";
			if (map.ContainsKey(key))
			{
				paymentDetailsResponse = (paymentDetailsResponse == null) ? new PaymentDetailsResponse() : paymentDetailsResponse;
				paymentDetailsResponse.ipnNotificationUrl = map[key];
			}
			key = prefix + "memo";
			if (map.ContainsKey(key))
			{
				paymentDetailsResponse = (paymentDetailsResponse == null) ? new PaymentDetailsResponse() : paymentDetailsResponse;
				paymentDetailsResponse.memo = map[key];
			}
			PaymentInfoList paymentInfoList =  PaymentInfoList.CreateInstance(map, prefix + "paymentInfoList", -1);
			if (paymentInfoList != null)
			{
				paymentDetailsResponse = (paymentDetailsResponse == null) ? new PaymentDetailsResponse() : paymentDetailsResponse;
				paymentDetailsResponse.paymentInfoList = paymentInfoList;
			}
			key = prefix + "returnUrl";
			if (map.ContainsKey(key))
			{
				paymentDetailsResponse = (paymentDetailsResponse == null) ? new PaymentDetailsResponse() : paymentDetailsResponse;
				paymentDetailsResponse.returnUrl = map[key];
			}
			key = prefix + "senderEmail";
			if (map.ContainsKey(key))
			{
				paymentDetailsResponse = (paymentDetailsResponse == null) ? new PaymentDetailsResponse() : paymentDetailsResponse;
				paymentDetailsResponse.senderEmail = map[key];
			}
			key = prefix + "status";
			if (map.ContainsKey(key))
			{
				paymentDetailsResponse = (paymentDetailsResponse == null) ? new PaymentDetailsResponse() : paymentDetailsResponse;
				paymentDetailsResponse.status = map[key];
			}
			key = prefix + "trackingId";
			if (map.ContainsKey(key))
			{
				paymentDetailsResponse = (paymentDetailsResponse == null) ? new PaymentDetailsResponse() : paymentDetailsResponse;
				paymentDetailsResponse.trackingId = map[key];
			}
			key = prefix + "payKey";
			if (map.ContainsKey(key))
			{
				paymentDetailsResponse = (paymentDetailsResponse == null) ? new PaymentDetailsResponse() : paymentDetailsResponse;
				paymentDetailsResponse.payKey = map[key];
			}
			key = prefix + "actionType";
			if (map.ContainsKey(key))
			{
				paymentDetailsResponse = (paymentDetailsResponse == null) ? new PaymentDetailsResponse() : paymentDetailsResponse;
				paymentDetailsResponse.actionType = map[key];
			}
			key = prefix + "feesPayer";
			if (map.ContainsKey(key))
			{
				paymentDetailsResponse = (paymentDetailsResponse == null) ? new PaymentDetailsResponse() : paymentDetailsResponse;
				paymentDetailsResponse.feesPayer = map[key];
			}
			key = prefix + "reverseAllParallelPaymentsOnError";
			if (map.ContainsKey(key))
			{
				paymentDetailsResponse = (paymentDetailsResponse == null) ? new PaymentDetailsResponse() : paymentDetailsResponse;
				paymentDetailsResponse.reverseAllParallelPaymentsOnError = System.Convert.ToBoolean(map[key]);
			}
			key = prefix + "preapprovalKey";
			if (map.ContainsKey(key))
			{
				paymentDetailsResponse = (paymentDetailsResponse == null) ? new PaymentDetailsResponse() : paymentDetailsResponse;
				paymentDetailsResponse.preapprovalKey = map[key];
			}
			FundingConstraint fundingConstraint =  FundingConstraint.CreateInstance(map, prefix + "fundingConstraint", -1);
			if (fundingConstraint != null)
			{
				paymentDetailsResponse = (paymentDetailsResponse == null) ? new PaymentDetailsResponse() : paymentDetailsResponse;
				paymentDetailsResponse.fundingConstraint = fundingConstraint;
			}
			SenderIdentifier sender =  SenderIdentifier.CreateInstance(map, prefix + "sender", -1);
			if (sender != null)
			{
				paymentDetailsResponse = (paymentDetailsResponse == null) ? new PaymentDetailsResponse() : paymentDetailsResponse;
				paymentDetailsResponse.sender = sender;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					paymentDetailsResponse = (paymentDetailsResponse == null) ? new PaymentDetailsResponse() : paymentDetailsResponse;
					paymentDetailsResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return paymentDetailsResponse;
		}
	}




	/**
      *The PayRequest contains the payment instructions to make
      *from sender to receivers. 
      */
	public partial class PayRequest	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.clientDetails != null)
			{
					string newPrefix = prefix + "clientDetails" + ".";
					sb.Append(this.clientDetailsField.ToNVPString(newPrefix));
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
					sb.Append(this.receiverListField.ToNVPString(newPrefix));
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
					sb.Append(this.fundingConstraintField.ToNVPString(newPrefix));
			}
			if (this.sender != null)
			{
					string newPrefix = prefix + "sender" + ".";
					sb.Append(this.senderField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/**
      *The PayResponse contains the result of the Pay operation.
      *The payKey and execution status of the request should always
      *be provided. 
      */
	public partial class PayResponse	{

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



		public static PayResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			PayResponse payResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				payResponse = (payResponse == null) ? new PayResponse() : payResponse;
				payResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "payKey";
			if (map.ContainsKey(key))
			{
				payResponse = (payResponse == null) ? new PayResponse() : payResponse;
				payResponse.payKey = map[key];
			}
			key = prefix + "paymentExecStatus";
			if (map.ContainsKey(key))
			{
				payResponse = (payResponse == null) ? new PayResponse() : payResponse;
				payResponse.paymentExecStatus = map[key];
			}
			PayErrorList payErrorList =  PayErrorList.CreateInstance(map, prefix + "payErrorList", -1);
			if (payErrorList != null)
			{
				payResponse = (payResponse == null) ? new PayResponse() : payResponse;
				payResponse.payErrorList = payErrorList;
			}
			FundingPlan defaultFundingPlan =  FundingPlan.CreateInstance(map, prefix + "defaultFundingPlan", -1);
			if (defaultFundingPlan != null)
			{
				payResponse = (payResponse == null) ? new PayResponse() : payResponse;
				payResponse.defaultFundingPlan = defaultFundingPlan;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					payResponse = (payResponse == null) ? new PayResponse() : payResponse;
					payResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return payResponse;
		}
	}




	/**
      *The request to look up the details of a Preapproval. 
      */
	public partial class PreapprovalDetailsRequest	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
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
	public partial class PreapprovalDetailsResponse	{

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



		public static PreapprovalDetailsResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			PreapprovalDetailsResponse preapprovalDetailsResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "approved";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.approved = System.Convert.ToBoolean(map[key]);
			}
			key = prefix + "cancelUrl";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.cancelUrl = map[key];
			}
			key = prefix + "curPayments";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.curPayments = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "curPaymentsAmount";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.curPaymentsAmount = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "curPeriodAttempts";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.curPeriodAttempts = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "curPeriodEndingDate";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.curPeriodEndingDate = map[key];
			}
			key = prefix + "currencyCode";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.currencyCode = map[key];
			}
			key = prefix + "dateOfMonth";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.dateOfMonth = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "dayOfWeek";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.dayOfWeek = (DayOfWeek)EnumUtils.GetValue(map[key],typeof(DayOfWeek));
			}
			key = prefix + "endingDate";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.endingDate = map[key];
			}
			key = prefix + "maxAmountPerPayment";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.maxAmountPerPayment = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "maxNumberOfPayments";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.maxNumberOfPayments = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "maxNumberOfPaymentsPerPeriod";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.maxNumberOfPaymentsPerPeriod = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "maxTotalAmountOfAllPayments";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.maxTotalAmountOfAllPayments = System.Convert.ToDecimal(map[key]);
			}
			key = prefix + "paymentPeriod";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.paymentPeriod = map[key];
			}
			key = prefix + "pinType";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.pinType = map[key];
			}
			key = prefix + "returnUrl";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.returnUrl = map[key];
			}
			key = prefix + "senderEmail";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.senderEmail = map[key];
			}
			key = prefix + "memo";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.memo = map[key];
			}
			key = prefix + "startingDate";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.startingDate = map[key];
			}
			key = prefix + "status";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.status = map[key];
			}
			key = prefix + "ipnNotificationUrl";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.ipnNotificationUrl = map[key];
			}
			AddressList addressList =  AddressList.CreateInstance(map, prefix + "addressList", -1);
			if (addressList != null)
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.addressList = addressList;
			}
			key = prefix + "feesPayer";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.feesPayer = map[key];
			}
			key = prefix + "displayMaxTotalAmount";
			if (map.ContainsKey(key))
			{
				preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
				preapprovalDetailsResponse.displayMaxTotalAmount = System.Convert.ToBoolean(map[key]);
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					preapprovalDetailsResponse = (preapprovalDetailsResponse == null) ? new PreapprovalDetailsResponse() : preapprovalDetailsResponse;
					preapprovalDetailsResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return preapprovalDetailsResponse;
		}
	}




	/**
      *A request to create a Preapproval. A Preapproval is an
      *agreement between a Paypal account holder (the sender) and
      *the API caller (the service invoker) to make payment(s) on
      *the the sender's behalf with various limitations defined. 
      */
	public partial class PreapprovalRequest	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.clientDetails != null)
			{
					string newPrefix = prefix + "clientDetails" + ".";
					sb.Append(this.clientDetailsField.ToNVPString(newPrefix));
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
					sb.Append(prefix).Append("dayOfWeek").Append("=").Append(EnumUtils.GetDescription(dayOfWeek));
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
	public partial class PreapprovalResponse	{

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



		public static PreapprovalResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			PreapprovalResponse preapprovalResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				preapprovalResponse = (preapprovalResponse == null) ? new PreapprovalResponse() : preapprovalResponse;
				preapprovalResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "preapprovalKey";
			if (map.ContainsKey(key))
			{
				preapprovalResponse = (preapprovalResponse == null) ? new PreapprovalResponse() : preapprovalResponse;
				preapprovalResponse.preapprovalKey = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					preapprovalResponse = (preapprovalResponse == null) ? new PreapprovalResponse() : preapprovalResponse;
					preapprovalResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return preapprovalResponse;
		}
	}




	/**
      *A request to make a refund based on various criteria. A
      *refund can be made against the entire payKey, an individual
      *transaction belonging to a payKey, a tracking id, or a
      *specific receiver of a payKey. 
      */
	public partial class RefundRequest	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
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
					sb.Append(this.receiverListField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/**
      *The result of a Refund request. 
      */
	public partial class RefundResponse	{

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



		public static RefundResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			RefundResponse refundResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				refundResponse = (refundResponse == null) ? new RefundResponse() : refundResponse;
				refundResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "currencyCode";
			if (map.ContainsKey(key))
			{
				refundResponse = (refundResponse == null) ? new RefundResponse() : refundResponse;
				refundResponse.currencyCode = map[key];
			}
			RefundInfoList refundInfoList =  RefundInfoList.CreateInstance(map, prefix + "refundInfoList", -1);
			if (refundInfoList != null)
			{
				refundResponse = (refundResponse == null) ? new RefundResponse() : refundResponse;
				refundResponse.refundInfoList = refundInfoList;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					refundResponse = (refundResponse == null) ? new RefundResponse() : refundResponse;
					refundResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return refundResponse;
		}
	}




	/**
      *The request to set the options of a payment request. 
      */
	public partial class SetPaymentOptionsRequest	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.payKey != null)
			{
					sb.Append(prefix).Append("payKey").Append("=").Append(HttpUtility.UrlEncode(this.payKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.initiatingEntity != null)
			{
					string newPrefix = prefix + "initiatingEntity" + ".";
					sb.Append(this.initiatingEntityField.ToNVPString(newPrefix));
			}
			if (this.displayOptions != null)
			{
					string newPrefix = prefix + "displayOptions" + ".";
					sb.Append(this.displayOptionsField.ToNVPString(newPrefix));
			}
			if (this.shippingAddressId != null)
			{
					sb.Append(prefix).Append("shippingAddressId").Append("=").Append(HttpUtility.UrlEncode(this.shippingAddressId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.senderOptions != null)
			{
					string newPrefix = prefix + "senderOptions" + ".";
					sb.Append(this.senderOptionsField.ToNVPString(newPrefix));
			}
			for (int i = 0; i < this.receiverOptions.Count; i++)
			{
				if (this.receiverOptions[i] != null)
				{
					string newPrefix = prefix + "receiverOptions" + "(" + i + ").";
					sb.Append(this.receiverOptions[i].ToNVPString(newPrefix));
				}
			}
			return sb.ToString();
		}
	}




	/**
      *The response message for the SetPaymentOption request 
      */
	public partial class SetPaymentOptionsResponse	{

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



		public static SetPaymentOptionsResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			SetPaymentOptionsResponse setPaymentOptionsResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				setPaymentOptionsResponse = (setPaymentOptionsResponse == null) ? new SetPaymentOptionsResponse() : setPaymentOptionsResponse;
				setPaymentOptionsResponse.responseEnvelope = responseEnvelope;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					setPaymentOptionsResponse = (setPaymentOptionsResponse == null) ? new SetPaymentOptionsResponse() : setPaymentOptionsResponse;
					setPaymentOptionsResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return setPaymentOptionsResponse;
		}
	}




	/**
      *The request to get the funding plans available for a
      *payment. 
      */
	public partial class GetFundingPlansRequest	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
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
	public partial class GetFundingPlansResponse	{

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



		public static GetFundingPlansResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			GetFundingPlansResponse getFundingPlansResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				getFundingPlansResponse = (getFundingPlansResponse == null) ? new GetFundingPlansResponse() : getFundingPlansResponse;
				getFundingPlansResponse.responseEnvelope = responseEnvelope;
			}
			i = 0;
			while(true)
			{
				FundingPlan fundingPlan =  FundingPlan.CreateInstance(map, prefix + "fundingPlan", i);
				if (fundingPlan != null)
				{
					getFundingPlansResponse = (getFundingPlansResponse == null) ? new GetFundingPlansResponse() : getFundingPlansResponse;
					getFundingPlansResponse.fundingPlan.Add(fundingPlan);
					i++;
				} 
				else
				{
					break;
				}
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					getFundingPlansResponse = (getFundingPlansResponse == null) ? new GetFundingPlansResponse() : getFundingPlansResponse;
					getFundingPlansResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return getFundingPlansResponse;
		}
	}




	/**
      *The request to get the addresses available for a payment. 
      */
	public partial class GetAvailableShippingAddressesRequest	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
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
	public partial class GetAvailableShippingAddressesResponse	{

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



		public static GetAvailableShippingAddressesResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			GetAvailableShippingAddressesResponse getAvailableShippingAddressesResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				getAvailableShippingAddressesResponse = (getAvailableShippingAddressesResponse == null) ? new GetAvailableShippingAddressesResponse() : getAvailableShippingAddressesResponse;
				getAvailableShippingAddressesResponse.responseEnvelope = responseEnvelope;
			}
			i = 0;
			while(true)
			{
				Address availableAddress =  Address.CreateInstance(map, prefix + "availableAddress", i);
				if (availableAddress != null)
				{
					getAvailableShippingAddressesResponse = (getAvailableShippingAddressesResponse == null) ? new GetAvailableShippingAddressesResponse() : getAvailableShippingAddressesResponse;
					getAvailableShippingAddressesResponse.availableAddress.Add(availableAddress);
					i++;
				} 
				else
				{
					break;
				}
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					getAvailableShippingAddressesResponse = (getAvailableShippingAddressesResponse == null) ? new GetAvailableShippingAddressesResponse() : getAvailableShippingAddressesResponse;
					getAvailableShippingAddressesResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return getAvailableShippingAddressesResponse;
		}
	}




	/**
      *The request to get the addresses available for a payment. 
      */
	public partial class GetShippingAddressesRequest	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
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
	public partial class GetShippingAddressesResponse	{

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



		public static GetShippingAddressesResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			GetShippingAddressesResponse getShippingAddressesResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				getShippingAddressesResponse = (getShippingAddressesResponse == null) ? new GetShippingAddressesResponse() : getShippingAddressesResponse;
				getShippingAddressesResponse.responseEnvelope = responseEnvelope;
			}
			Address selectedAddress =  Address.CreateInstance(map, prefix + "selectedAddress", -1);
			if (selectedAddress != null)
			{
				getShippingAddressesResponse = (getShippingAddressesResponse == null) ? new GetShippingAddressesResponse() : getShippingAddressesResponse;
				getShippingAddressesResponse.selectedAddress = selectedAddress;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					getShippingAddressesResponse = (getShippingAddressesResponse == null) ? new GetShippingAddressesResponse() : getShippingAddressesResponse;
					getShippingAddressesResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return getShippingAddressesResponse;
		}
	}




	/**
      *The request to get the remaining limits for a user 
      */
	public partial class GetUserLimitsRequest	{

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


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.user != null)
			{
					string newPrefix = prefix + "user" + ".";
					sb.Append(this.userField.ToNVPString(newPrefix));
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
	public partial class GetUserLimitsResponse	{

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



		public static GetUserLimitsResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			GetUserLimitsResponse getUserLimitsResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				getUserLimitsResponse = (getUserLimitsResponse == null) ? new GetUserLimitsResponse() : getUserLimitsResponse;
				getUserLimitsResponse.responseEnvelope = responseEnvelope;
			}
			i = 0;
			while(true)
			{
				UserLimit userLimit =  UserLimit.CreateInstance(map, prefix + "userLimit", i);
				if (userLimit != null)
				{
					getUserLimitsResponse = (getUserLimitsResponse == null) ? new GetUserLimitsResponse() : getUserLimitsResponse;
					getUserLimitsResponse.userLimit.Add(userLimit);
					i++;
				} 
				else
				{
					break;
				}
			}
			WarningDataList warningDataList =  WarningDataList.CreateInstance(map, prefix + "warningDataList", -1);
			if (warningDataList != null)
			{
				getUserLimitsResponse = (getUserLimitsResponse == null) ? new GetUserLimitsResponse() : getUserLimitsResponse;
				getUserLimitsResponse.warningDataList = warningDataList;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					getUserLimitsResponse = (getUserLimitsResponse == null) ? new GetUserLimitsResponse() : getUserLimitsResponse;
					getUserLimitsResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return getUserLimitsResponse;
		}
	}





}