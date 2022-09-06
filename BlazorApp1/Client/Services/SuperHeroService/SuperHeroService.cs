using System.Net.Http.Json;
using BlazorApp1.Shared;

namespace BlazorApp1.Client.Services.SuperHeroService
{
    public class SuperHeroService : iSuperHeroService
    {
        private readonly HttpClient _http;

        public SuperHeroService(HttpClient http)
        {
            _http = http;
        }
        public List<SuperHero> Heroes { get; set; } =new List<SuperHero>();
        public List<Comic> Comics { get; set; } = new List<Comic>();
        public async Task GetComics()
        {
            var result = await _http.GetFromJsonAsync<List<Comic>>("api/superhero/comics");
            if (result != null)
                Comics = result;
        }

        public async Task GetSuperHeroes()
        {
            var result = await _http.GetFromJsonAsync<List<SuperHero>>("api/superhero");
            if (result != null)
                Heroes = result;
        }

        public async Task<SuperHero> GetSingleHero(int id)
        {
            var result = await _http.GetFromJsonAsync<SuperHero>($"api/superhero/{id}");
            if (result != null) 
                return result;
            throw new Exception("hero not found!");
        }
    }
}
