using System;
using System.Net;
using System.Web.Configuration;
using System.Diagnostics;
using System.IO;
using SmartyStreets;
using SmartyStreets.USStreetApi;
using truevalueauction.App_Code;
namespace truevalueauction.App_Code.Utilities
{
    public class AddressAPI
    {
        public static bool IsAddressValid(Address address)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var authId = WebConfigurationManager.AppSettings["SMARTY_AUTH_ID"];
            var authToken = WebConfigurationManager.AppSettings["SMARTY_AUTH_TOKEN"];

            var client = new ClientBuilder(authId, authToken)
                //.WithCustomBaseUrl("https://us-street.api.smartystreets.com")
                //.ViaProxy("http://localhost:8080", "username", "password") // uncomment this line to point to the specified proxy.
                .BuildUsStreetApiClient();

            var lookup = new Lookup
            {
                InputId = "", // Optional ID from you system
                Addressee = "",
                Street = address.GetAddress1(),
                Street2 = address.GetAddress2(),
                Secondary = "",
                Urbanization = "", // Only applies to Puerto Rico addresses
                City = address.GetCity(),
                State = address.GetState(),
                ZipCode = address.getZipCode(),
                MaxCandidates = 3,
                MatchStrategy = Lookup.INVALID // "invalid" is the most permissive match,
                                               // this will always return at least one result even if the address is invalid.
                                               // Refer to the documentation for additional MatchStrategy options.
            };

            try
            {
                client.Send(lookup);
            }
            catch (SmartyException ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }

            var candidates = lookup.Result;

            if (candidates.Count == 0)
            {
                Debug.WriteLine("No candidates. This means the address is not valid.");
                return false;
            }

            var firstCandidate = candidates[0];

            Debug.WriteLine("Input ID: " + firstCandidate.InputId);
            Debug.WriteLine("Address is valid. (There is at least one candidate)\n");
            Debug.WriteLine("ZIP Code: " + firstCandidate.Components.ZipCode);
            Debug.WriteLine("County: " + firstCandidate.Metadata.CountyName);
            Debug.WriteLine("Latitude: " + firstCandidate.Metadata.Latitude);
            Debug.WriteLine("Longitude: " + firstCandidate.Metadata.Longitude);
            return true;
        }

        public static bool IsAddressValid(User user)
        {
            return IsAddressValid(user.GetAddress());
        }
    }
}
