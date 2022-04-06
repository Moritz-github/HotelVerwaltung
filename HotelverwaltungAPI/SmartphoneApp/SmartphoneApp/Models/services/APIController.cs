using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneApp.Models.services
{
    class APIController
    {
        private static APIController _instance;
        public static APIController getInstance()
        {
            if (_instance == null)
            {
                _instance = new APIController();
            }
            return _instance;
        }

        String serverURL = "http://localhost:5000";

        HttpClient _client = new HttpClient(new HttpClientHandler()
        {
            ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
            {
                return true;
            },
        }, false);

        private APIController()
        {
            
        //_client.DefaultRequestHeaders.ConnectionClose = true;
        }

        public async Task<ObservableCollection<Room>> getFreeRoomsByDate(DateTime start, DateTime end)
        {
            String url = serverURL + "/api/Rooms/getFreeRooms" + "?startDateTime=" + start.ToString() + "&endDateTime="+end.ToString();
            var resp = await _client.GetAsync(url);
            if (resp.IsSuccessStatusCode)
            {
                List<Room> rooms = JsonConvert.DeserializeObject<List<Room>>(await resp.Content.ReadAsStringAsync());
                ObservableCollection<Room> r = new ObservableCollection<Room>();
                for (int i = 0; i < rooms.Count; i++)
                {
                    r.Add(rooms[i]);
                }
                return r;
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> addGuest(Guest g)
        {
            try
            {
                String url = serverURL + "/api/Guests/add";
                String body = JsonConvert.SerializeObject(g);
                StringContent content = new StringContent(body, Encoding.UTF8, "application/json");
                Debug.WriteLine(body);
                var resp = await _client.PostAsync(url, content);
                Debug.WriteLine(resp.StatusCode);
                if (resp.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            } catch
            {
                return false;
            }
            return false;


        }

        public async Task<ObservableCollection<Room>> getAllRooms()
        {
            String url = serverURL + "/api/Rooms";
            var resp = await _client.GetAsync(url);
            if (resp.IsSuccessStatusCode)
            {
                List<Room> rooms = JsonConvert.DeserializeObject<List<Room>>(await resp.Content.ReadAsStringAsync());
                ObservableCollection<Room> r = new ObservableCollection<Room>();
                for (int i = 0; i < rooms.Count; i++)
                {
                    r.Add(rooms[i]);
                }
                return r;
            }
            else
            {
                return null;
            }
        }
        public async Task<ObservableCollection<Guest>> getAllGuests()
        {
            String url = serverURL + "/api/Guests";
            var resp = await _client.GetAsync(url);
            if (resp.IsSuccessStatusCode)
            {
                List<Guest> guests = JsonConvert.DeserializeObject<List<Guest>>(await resp.Content.ReadAsStringAsync());
                ObservableCollection<Guest> g = new ObservableCollection<Guest>();
                for (int i = 0; i < guests.Count; i++)
                {
                    g.Add(guests[i]);
                }
                return g;
            }
            else
            {
                return null;
            }
        }

    }
}
