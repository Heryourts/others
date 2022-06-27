// See https://aka.ms/new-console-template for more information
using Bing.Search;
using Google.Search;
using Interfaces;
using Yahoo.Search;


List<IWebSearcher> searchers = new List<IWebSearcher>() 
{ new GoogleSearcher(), new  YahooSearcher(), new BingSearcher()};

foreach (var searcher in searchers)
{
    searcher.DoSearch("pencil");
    PrintResults(searcher.Results, searcher.BusyTime);
}

//IWebSearcher googleSearcher = new GoogleSearcher();
//googleSearcher.DoSearch("pencil");
//PrintResults(googleSearcher.Results, googleSearcher.BusyTime);

//IWebSearcher yahooSearcher = new YahooSearcher();
//yahooSearcher.DoSearch("pencil");
//PrintResults(yahooSearcher.Results, yahooSearcher.BusyTime);

//IWebSearcher bingSearcher = new BingSearcher();
//bingSearcher.DoSearch("pencil");
//PrintResults(bingSearcher.Results, bingSearcher.BusyTime);



void PrintResults(List<string> results, int busyTime)
{
    foreach (var result in results)
    {
        Console.WriteLine($"{result} take {busyTime} milliseconds");
    }
}



