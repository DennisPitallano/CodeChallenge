using System.Text;
using EverywhereNews.Models;
using RestSharp;

namespace EverywhereNews.Services;

public class NewsClient : INewsClient, IDisposable
{
    private readonly RestClient _restClient;

    public NewsClient(string baseUrl,string apiKey)
    {
        var options = new RestClientOptions(baseUrl);
        _restClient  = new RestClient(options);
        _restClient.AddDefaultHeader("Authorization", apiKey);
    }

    public async Task<List<Article>?> GetTopHeadlines()
    {
        var response = await _restClient.GetJsonAsync<ApiResponse>("top-headlines?country=us");
        return response?.Articles;
    }

    public async Task<List<Article>?> GetEverything(string? search)
    {
         var response = await _restClient.GetJsonAsync<ApiResponse>("everything?q=" + search);
         return response?.Articles;
    }

    public async Task<List<Article>?> GetEverything(string? search,string? language)
    {
        var query = new StringBuilder();
        query.Append("everything?q=");
        query.Append(search);
        if (!string.IsNullOrEmpty(language) && !language!.Equals("all"))
        {
            query.Append("language=");
            query.Append(language);
        }
        var response = await _restClient.GetJsonAsync<ApiResponse>(query.ToString());
        return response?.Articles ?? [];
    }

    public async Task<List<Article>> GetTopHeadlines(string country, string? search, string? category)
    {
        var query = new StringBuilder();
        query.Append("top-headlines?country=");
        query.Append(country);
        if (!string.IsNullOrEmpty(category) && !category!.Equals("all"))
        {
            query.Append("&category=");
            query.Append(category);
        }
        if (!string.IsNullOrEmpty(search))
        {
            query.Append("&q=");
            query.Append(search);
        }
        var response = await _restClient.GetJsonAsync<ApiResponse>(query.ToString());
        return response?.Articles ?? [];
    }


    public void Dispose()
    {
       _restClient?.Dispose();
       GC.SuppressFinalize(this);
    }
}