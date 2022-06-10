namespace RobotProject.Services
{


    public class LocationService
    {
        //private readonly ILogger<LocationService> _logger;
        private readonly HttpClient _httpClient;

        // The constructor
        // httpclient is the dependency injection
        // to get info somewhere else
        // get it from the MAPS api
        //  public LocationService (IConfiguration config, HttpClient client, ILogger<LocationService>)
        public LocationService(HttpClient client)
        {
            _httpClient = client;
            //_logger = logger;
            //_logger.LogCritical("Message created: Log critical message");

            // needed for the 3rd party (related to headers)

            client.DefaultRequestHeaders.Add("User-Agent", "C# App");
        }

        public async Task<string> GetNearestBodyOfWater(Location location)
        {


            //HttpClient client = new HttpClient();

            string APIUrl = $"https://nominatim.openstreetmap.org/search.php?q=water%20near%20{location.LocationName}%20Australia&polygon_geojson=1&format=jsonv2";

            HttpResponseMessage x = await _httpClient.GetAsync(APIUrl);


            // return a string
            return await x.Content.ReadAsStringAsync();


            //HttpResponseMessage x = await _httpClient.GetAsync("https://nominatim.openstreetmap.org/reverse?format=json&lat=-32&lon=151.2082848");//
            //return await x.Content.ReadAsStringAsync();

            //// Adding in the client request for long and latitude:
            ////HttpResponseMessage ResponseFromApi = await _httpClient.GetAsync("https://nominatim.openstreetmap.org/reverse?format=json&lat=-32&lon=151.2082848");//





        }
    }
}