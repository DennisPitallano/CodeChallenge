using Microsoft.AspNetCore.Mvc.Rendering;

namespace EverywhereNews.Constants;

public class Languages
{
    public static SelectList LanguageSelectList(string? selected)
    {
        List<SelectListItem> languageList =
        [
            new SelectListItem {Value = "all", Text = "All"},
            new SelectListItem {Value = "en", Text = "English"},
            new SelectListItem {Value = "ar", Text = "Arabic"},
            new SelectListItem {Value = "de", Text = "German"},
            new SelectListItem {Value = "es", Text = "Spanish"},
            new SelectListItem {Value = "fr", Text = "French"},
            new SelectListItem {Value = "he", Text = "Hebrew"},
            new SelectListItem {Value = "it", Text = "Italian"},
            new SelectListItem {Value = "nl", Text = "Dutch"},
            new SelectListItem {Value = "no", Text = "Norwegian"},
            new SelectListItem {Value = "pt", Text = "Portuguese"},
            new SelectListItem {Value = "ru", Text = "Russian"},
            new SelectListItem {Value = "se", Text = "Northern Sami"},
            new SelectListItem {Value = "ud", Text = "Udmurt"},
            new SelectListItem {Value = "zh", Text = "Chinese"}
            // Add more languages as needed
        ];

        return new SelectList(languageList, "Value", "Text",selected);
    }
}