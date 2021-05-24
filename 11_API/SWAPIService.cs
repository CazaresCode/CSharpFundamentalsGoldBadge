using _11_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _11_API
{
    public class SWAPIService
    {
        // basically this is a method so we can access it in one method in one place instead of having to rewrite the code again and again and again and again and again....
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<Person> GetPersonAsync(int id)
        {
            // Ask our api for a response, wait for it here.
            HttpResponseMessage response = await _httpClient.GetAsync($"https://swapi.dev/api/people/{id}");

            // If 200 (ok), carry on. 
            if (response.IsSuccessStatusCode)
            {
                // Read the content of the response as a Person Object.
                Person person = await response.Content.ReadAsAsync<Person>();
                // Give person back.
                return person;
            }
            // If the response if anything other than 200 (ok) give a null;
            // Below is also an "Else{ }" but it is implied.
            return null;
        }
        public async Task<Vehicle> GetVehicleAsync(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<Vehicle>();
            }
            return null;
        }

        public async Task<T> GetAsync<T>(string url) 
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<T>();
            }
            return default; // default is a null type.
        }


        public async Task<SearchResult<Person>> GetPersonSearchAsync(string query)
        {
            HttpResponseMessage response = await _httpClient.GetAsync("http://swapi.dev/api/people/?search=" + query);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SearchResult<Person>>();
            }
            return null;
        }

        public async Task<SearchResult<T>> GetSearchAsync<T>(string category, string query)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"http://swapi.dev/api/{category}/?search={query}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SearchResult<T>>();
            }
            return null;
        }

        //Combo of what is GetPersonSearchAysnc(string query);
        public async Task<SearchResult<Vehicle>> GetVehicleSearchAsync( string query)
        {
            return await GetSearchAsync<Vehicle>("vehicles", query);
        }

    }
}
