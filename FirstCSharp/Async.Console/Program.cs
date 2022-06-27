
using Bing.Search;
using Google.Search;
using Interfaces;
using System.Diagnostics;
using Yahoo.Search;

List<IWebSearcher> searchers = new List<IWebSearcher>()
{ new GoogleSearcher(), new  YahooSearcher(), new BingSearcher()};

var timer = new Stopwatch();
timer.Start();

string word = "pencil";
await Task.WhenAll(searchers.Select(p=> p.DoSearchAsync(word)));

timer.Stop();
TimeSpan timeTaken = timer.Elapsed;
Console.WriteLine($"Time taken : {timeTaken.ToString(@"m\:ss\.fff")}");

PrintSearchResults(searchers);

void PrintSearchResults(List<IWebSearcher> searchers)
{
    foreach (var searcher in searchers)
    {
        Console.WriteLine($"{string.Join(",", searcher.Results)} taken {searcher.BusyTime}");
    }
}