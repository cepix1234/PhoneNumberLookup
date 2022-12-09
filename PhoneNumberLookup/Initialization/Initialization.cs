using PhoneNumberLookup.controllers;
namespace PhoneNumberLookup.Initialization
{
    public class Initialization
    { 
        public static void _Initialize()
        {
            //TODO get api key from config file provided by user
            //if no config file found init file with input for api key
            NumberLookupControler._ApiEndpoint = "https://ipqualityscore.com/api/json";
            NumberLookupControler._ApiKey = "YrmOmwQ0njdMWNGNtXCunBsGKlL6sevB";
        }

    }
}
