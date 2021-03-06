namespace SearchSampleApp
{
    using System.Collections.Generic;

    public interface IWebSearchService
    {
        IEnumerable<SearchResult> Search(string query);
    }
}