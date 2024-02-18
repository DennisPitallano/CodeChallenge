using Microsoft.AspNetCore.Mvc.Rendering;

namespace EverywhereNews.Constants;

public class Categories
{
    public static SelectList CategorySelectList(string? selected)
    {
        List<SelectListItem> categoryList =
        [
            new SelectListItem {Value = "all", Text = "All"},
            new SelectListItem {Value = "business", Text = "Business"},
            new SelectListItem {Value = "entertainment", Text = "Entertainment"},
            new SelectListItem {Value = "general", Text = "General"},
            new SelectListItem {Value = "health", Text = "Health"},
            new SelectListItem {Value = "science", Text = "Science"},
            new SelectListItem {Value = "sports", Text = "Sports"},
            new SelectListItem {Value = "technology", Text = "Technology"}
            // Add more categories as needed
        ];

        return new SelectList(categoryList, "Value", "Text",selected);
    }
}