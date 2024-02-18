using EverywhereNews.Constants;

namespace EverywhereNews.Models;

public class ApiResponse
{
        public String Status { get; set; }
        public ErrorCodes? Code { get; set; }
        public string Message { get; set; }
        public List<Article>? Articles { get; set; }
        public int TotalResults { get; set; }
}