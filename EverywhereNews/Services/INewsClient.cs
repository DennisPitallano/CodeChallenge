using EverywhereNews.Models;

namespace EverywhereNews.Services;

public interface INewsClient
{
    Task<List<Article>?> GetTopHeadlines();
    Task<List<Article>> GetTopHeadlines(string country, string? search, string? category);
    Task<List<Article>?> GetEverything(string? search);
    Task<List<Article>?> GetEverything(string search, string? language);
}