using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneApp.Models.services
{
    class APIController
    {
        private static APIController _instance;
        public APIController getInstance()
        {
            if (_instance == null)
            {
                _instance = new APIController();
            }
            return _instance;
        }

        String serverURL = "https://localhost:44305";

        HttpClient _client;
        private APIController()
        {
            _client = new HttpClient();
        }

        public async Task<List<Room>> getAllRooms()
        {
            String url = serverURL + "/api/Rooms";
            var resp = await _client.GetAsync(serverURL);
            return JsonConvert.DeserializeObject<List<Room>>(await resp.Content.ReadAsStringAsync());
        }

    }
}
