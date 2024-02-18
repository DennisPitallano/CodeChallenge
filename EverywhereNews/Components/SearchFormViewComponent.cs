using EverywhereNews.Constants;
using EverywhereNews.Models;
using Microsoft.AspNetCore.Mvc;

namespace EverywhereNews.Components;

public class SearchFormViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(string selectedCountry,string selectedCategory, string selectedLanguage)
    {
        var searchFormModel = new SearchFormModel
        {
            Countries = Countries.CountrySelectList(selectedCountry),
            Categories = Categories.CategorySelectList(selectedCategory),
            Languages = Languages.LanguageSelectList(selectedLanguage)
        };
        return await Task.FromResult(View(searchFormModel));
    }
}