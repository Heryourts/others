using Bing.Search;
using Google.Search;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Yahoo.Search;

namespace Async.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnSearch.Click += BtnSearch_Click;

        }

        private async void BtnSearch_Click(object sender, RoutedEventArgs e)
        {

            List<IWebSearcher> searchers = new List<IWebSearcher>()
            { new GoogleSearcher(), new  YahooSearcher(), new BingSearcher()};

            var timer = new Stopwatch();
            timer.Start();

            string word = txtWords.Text;
            await Task.WhenAll(searchers.Select(p => p.DoSearchAsync(word)));

            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;
            tbLog.Text += $"Time taken : {timeTaken.ToString(@"m\:ss\.fff")}"+Environment.NewLine;

            PrintSearchResults(searchers);
           
        }

        private void PrintSearchResults(List<IWebSearcher> searchers)
        {
            foreach (var searcher in searchers)
            {
                tbLog.Text += $"{string.Join(",", searcher.Results)} taken {searcher.BusyTime}"+Environment.NewLine;
            }
        }
    }
}
