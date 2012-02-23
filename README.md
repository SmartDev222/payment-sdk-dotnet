
PayPal C# Adaptive Payments SDK
===============================

Prerequisites
-------------

PayPal's C# Adaptive Payments SDK requires 

 * Visual Studio 2005
 * NUnit 2.5.10.11092 (only for running the test cases) 
  

Using the SDK
-------------

To use the SDK, 

 * Copy the SDK DLL file into your project and add a reference.
 * Create a service wrapper object
 * Create a request object as per your project's needs. All the API request and response classes are available in PermissionsModel.cs
 * Invoke the appropriate method on the request object.


For example,

	using PayPal.AdaptivePayments;
	using PayPal.AdaptivePayments.Model;

      PaymentDetailsRequest req = new PaymentDetailsRequest(new RequestEnvelope("en_US")); 
      // set optional parameters
      req.payKey = "AP-343434343";
      req.transactionId = "12435";
	......

	AdaptivePaymentsService service = new AdaptivePaymentsService();
	PaymentDetailsResponse resp = service.PaymentDetails(req);
 
	if(resp.responseEnvelope.ack == AckCode.SUCCESS) {
		// Success
	}
  
 

SDK Configuration
-----------------

The SDK DLL uses the App.Config/Web.Config files. You can use the configuration file to configure

 * (Multiple) API account credentials.
 * Service endpoint and other HTTP connection parameters 


A sample configuration file has been provided with the unit tests. Adding PayPal specific configuration items to the App.Config/Web.Config file involves two steps

 * Adding a configSection to your config file

    &lt;configSections&gt;

      &lt;section name="paypal" type="PayPal.Manager.SDKConfigHandler, PayPal_Permissions_SDK" /&gt;

    &lt;/configSections&gt;

 * Adding the actual configuration 

    &lt;paypal&gt;  

      &lt;settings&gt;...&lt;/settings&gt;

      &lt;accounts&gt;

      &lt;account .../&gt;

      &lt;/accounts&gt;

    &lt;/paypal&gt;


FAQ
---

  * Can the SDK be used in Medium trust applications?

     To use the SDK in an application that runs in the medium trust level, you will need to configure appropriate WebPermissions to allow outbound 
HTTP connection to PayPal's API servers

    <trust level="Medium" originUrl="https://svcs.sandbox.paypal.com/.*" />

  * Why does logging not work in my application ?

     
