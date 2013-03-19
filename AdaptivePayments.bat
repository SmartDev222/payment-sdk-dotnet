call "C:\Program Files (x86)\Microsoft Visual Studio 8\Common7\IDE\devenv.com" PayPalAdaptivePaymentsSDK\PayPalAdaptivePaymentsSDK.sln /build Release

copy /Y PayPalAdaptivePaymentsSDK\bin\Release\PayPalAdaptivePaymentsSDK.dll Samples\AdaptivePaymentsSampleApp\lib\. 
copy /Y PayPalAdaptivePaymentsSDK\bin\Release\PayPalAdaptivePaymentsSDK.XML Samples\AdaptivePaymentsSampleApp\lib\. 
