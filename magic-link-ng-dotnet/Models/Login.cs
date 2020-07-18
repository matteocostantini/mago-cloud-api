namespace magic_link_ng_dotnet.Models
{
    public class ConnectionRequest {
        public string rootURL {get; set;}
        public bool isDebugEnv {get; set;}

        public string accountName {get; set;}
        public string password {get; set;}
        public string subscriptionKey {get; set;}
    }

    public class LoginResponse {
        public string JwtToken {get; set;}
        public string Language {get; set;}
        public string Message {get; set;}
        public string RegionalSettings {get; set;}
        public string Result {get; set;}
        public int ResultCode {get; set;}
        public string AccountName {get; set;}
        public string SubscriptionKey {get; set;}
        public string SubscriptionDesc {get; set;}
        public string SubscriptionCountry {get; set;}
    }
}
