using BlazorApp1.Shared;

namespace BlazorApp1.Client.Services.SuperHeroService
{
    public interface iSuperHeroService
    {
        List<SuperHero> Heroes { get; set; }
        List<Comic> Comics { get; set; }
        Task GetComics();
        Task GetSuperHeroes();
        Task<SuperHero> GetSingleHero(int id);
    }
}
