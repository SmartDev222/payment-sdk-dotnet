using System.Collections.Generic;

namespace AdaptivePaymentsSampleApp
{
    public static class Configuration
    {
        // Creates a configuration map containing signature credentials and other required configuration parameters
        public static Dictionary<string, string> GetSignatureConfig()
        {
            Dictionary<string, string> configMap = new Dictionary<string, string>();

            // Endpoints are varied depending on whether sandbox OR live is chosen for mode
            configMap.Add("mode", "sandbox");

            // Account Credential
            configMap.Add("account1.apiUsername", "jb-us-seller_api1.paypal.com");
            configMap.Add("account1.apiPassword", "WX4WTU3S8MY44S7F");
            configMap.Add("account1.apiSignature", "AFcWxV21C7fd0v3bYYYRCpSSRl31A7yDhhsPUU2XhtMoZXsWHFxu-RWy");
            configMap.Add("account1.applicationId", "APP-80W284485P519543T");

            return configMap;
        }
	
        // Creates a configuration map containing certificate credentials and other required configuration parameters
        public static Dictionary<string, string> GetCertificateConfig()
        {
            Dictionary<string, string> configMap = new Dictionary<string, string>();

            // Endpoints are varied depending on whether sandbox OR live is chosen for mode
            configMap.Add("mode", "sandbox");

            // Account Credential
            configMap.Add("account2.apiUsername", "certuser_biz_api1.paypal.com");
            configMap.Add("account2.apiPassword", "D6JNKKULHN3G5B8A");            
            configMap.Add("account2.apiCertificate", "resource/sdk-cert.p12");
            configMap.Add("account2.privateKeyPassword", "password");
            configMap.Add("account2.applicationId", "APP-80W284485P519543T");

            return configMap;
        }

        // Creates a configuration map containing IPN Endpoint mode and other optional parameters
        public static Dictionary<string, string> GetConfig()
        {
            Dictionary<string, string> configMap = new Dictionary<string, string>();

            // Endpoints are varied depending on whether sandbox OR live is chosen for mode
            configMap.Add("mode", "sandbox");

            // These values are defaulted in SDK. If you want to override default values, uncomment it and add your value.
            //configMap.Add("connectionTimeout", "36000");
            //configMap.Add("requestRetries", "3");

            return configMap;
        }
    }
}
