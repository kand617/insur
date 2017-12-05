using APIMATICCalculator.PCL.Models;
namespace APIMATICCalculator.PCL
{
    public partial class Configuration
    {
        public delegate void OAuthTokenUpdateDelegate(OAuthToken token);

        public static OAuthToken OAuthToken;

        public static OAuthTokenUpdateDelegate OAuthTokenUpdateCallback;

        //The base Uri for API calls
        public static string BaseUri = "http://examples.apimatic.io/apps/calculator";

        //sd
        //TODO: Replace the Gfdsfkl with an appropriate value
        public static string Gfdsfkl = "";

        //TODO: Replace the Dsfsdf with an appropriate value
        public static string Dsfsdf = "ds";

        //OAuth 2 Client ID
        //TODO: Replace the OAuthClientId with an appropriate value
        public static string OAuthClientId = "TODO: Replace";

        //OAuth 2 Client Secret
        //TODO: Replace the OAuthClientSecret with an appropriate value
        public static string OAuthClientSecret = "TODO: Replace";

        //OAuth 2 Resource Owner Username
        //TODO: Replace the OAuthUsername with an appropriate value
        public static string OAuthUsername = "TODO: Replace";

        //OAuth 2 Resource Owner Password
        //TODO: Replace the OAuthPassword with an appropriate value
        public static string OAuthPassword = "TODO: Replace";

    }
}