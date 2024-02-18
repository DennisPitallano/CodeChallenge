using Microsoft.AspNetCore.Mvc.Rendering;

namespace EverywhereNews.Constants;

public class Countries
{
    public static SelectList CountrySelectList(string? selected)
    {
        List<SelectListItem> countryList =
        [
            new SelectListItem {Value = "us", Text = "United States"},
            new SelectListItem {Value = "ca", Text = "Canada"},
            new SelectListItem {Value = "gb", Text = "United Kingdom"},
            new SelectListItem {Value = "au", Text = "Australia"},
            new SelectListItem {Value = "fr", Text = "France"},
            new SelectListItem {Value = "de", Text = "Germany"},
            new SelectListItem {Value = "it", Text = "Italy"},
            new SelectListItem {Value = "jp", Text = "Japan"},
            new SelectListItem {Value = "kr", Text = "South Korea"},
            new SelectListItem {Value = "ru", Text = "Russia"},
            new SelectListItem {Value = "sa", Text = "Saudi Arabia"},
            new SelectListItem {Value = "za", Text = "South Africa"},
            new SelectListItem {Value = "ph", Text = "Philippines"},
            new SelectListItem {Value = "in", Text = "India"}
            // Add more countries as needed
        ];

        return new SelectList(countryList, "Value", "Text",selected);
    }
}