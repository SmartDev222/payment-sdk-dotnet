call "C:\Program Files (x86)\Microsoft Visual Studio 8\Common7\IDE\devenv.com" PayPal_AdaptivePayments_SDK\PayPal_AdaptivePayments_SDK.sln /build Release %1

copy /Y PayPal_AdaptivePayments_SDK\bin\Release\PayPal_AdaptivePayments_SDK.dll Samples\AdaptivePaymentsSampleApp\lib\. 
