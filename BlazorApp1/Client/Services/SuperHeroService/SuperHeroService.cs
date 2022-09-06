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
        public Task GetComics()
        {
            throw new NotImplementedException();
        }

        public async Task GetSuperHeroes()
        {
            var result = await _http.GetFromJsonAsync<List<SuperHero>>("api/superhero");
            if (result != null)
                Heroes = result;
        }

        public Task<SuperHero> GetSingleHero(int id)
        {
            throw new NotImplementedException();
        }
    }
}
