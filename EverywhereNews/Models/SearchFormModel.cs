using Microsoft.AspNetCore.Mvc.Rendering;

namespace EverywhereNews.Models;

public class SearchFormModel
{
    public required SelectList Countries { get; set; }
    public string? Search { get; set; }
    public string? Country { get; set; }
    public required SelectList Categories { get; set; }
    public string? Category { get; set; }
    public required SelectList Languages { get; set; }
    public string? Language { get; set; }
 
}