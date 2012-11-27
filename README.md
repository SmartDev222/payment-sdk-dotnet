This repository contains .NET SDK and samples for Adaptive Payments API.

Prerequisites:
--------------
*	Visual Studio 2005 or higher

SDK Integration:
----------------
*	Create a new ASP.NET Web Application with appropriate web application and solution name

*	Add reference to 'PayPal_AdaptivePayments_SDK.dll'

*	Add reference to 'PayPal_Core_SDK.dll'

*	Namespaces to be used
	•	PayPal
	•	PayPal.AdaptivePayments
	•	PayPal.AdaptivePayments.Model
	•	PayPal.Util
	•	PayPal.Exception
 
Web.config:
-----------
Please refer to the sample web.config file in 'AdaptivePaymentsSampleApp' sample application to configure the following
 
*	Configuration Sections
	•	paypal
	•	log4net

*	PayPal Settings
	•	endpoint
	•	connectionTimeout
	•	requestRetries
	•	IPAddress
	•	sandboxEmailAddress

*	PayPal (Multiple) Accounts API credentials
	•	apiUsername
	•	apiPassword
	•	applicationId
	•	apiSignature
	•	apiCertificate
	•	privateKeyPassword

Tools:
------
*	log4net.dll - included in 'lib' folder in 'PayPal_AdaptiveAccounts_SDK' project
	log4net is a tool to help output log statements to a variety of output targets.
	
*	jQuery JavaScript Library - included in 'Content' folder in 'AdaptiveAccountsSampleApp' sample application
	This is a fast and concise JavaScript Library that simplifies HTML document traversing, event handling, animating, and Ajax interactions for rapid web development.