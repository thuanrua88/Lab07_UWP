using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab007.Models
{
    public class NewsItem
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string DateLine { get; set; }
        public string Image { get; set; }
    }
    public class NewsManager
    {
        public static void GetNews(string category, ObservableCollection<NewsItem> newsItems)
        {
            var allitems = GetNewsItems();

            var filteredNewsItems = allitems
                .Where(p => p.Category == category)
                .ToList();

            newsItems.Clear();
            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }

        private static List<NewsItem> GetNewsItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem() { ID = 1, Category = "Financial", Headline = "Lorem", DateLine = "17/10/2020", Subhead = "Hello", Image = "Assets/1.jpg" });
            items.Add(new NewsItem() { ID = 2, Category = "Financial", Headline = "Lorem", DateLine = "17/10/2020", Subhead = "Hello", Image = "Assets/2.jpg" });
            items.Add(new NewsItem() { ID = 3, Category = "Financial", Headline = "Lorem", DateLine = "17/10/2020", Subhead = "Hello", Image = "Assets/3.jpg" });
            items.Add(new NewsItem() { ID = 4, Category = "Financial", Headline = "Lorem", DateLine = "17/10/2020", Subhead = "Hello", Image = "Assets/4.jpg" });

            items.Add(new NewsItem() { ID = 5, Category = "Food", Headline = "Lorem", DateLine = "17/10/2020", Subhead = "Hello", Image = "Assets/1.jpg" });
            items.Add(new NewsItem() { ID = 6, Category = "Food", Headline = "Lorem", DateLine = "17/10/2020", Subhead = "Hello", Image = "Assets/2.jpg" });
            items.Add(new NewsItem() { ID = 7, Category = "Food", Headline = "Lorem", DateLine = "17/10/2020", Subhead = "Hello", Image = "Assets/3.jpg" });
            items.Add(new NewsItem() { ID = 8, Category = "Food", Headline = "Lorem", DateLine = "17/10/2020", Subhead = "Hello", Image = "Assets/4.jpg" });

            return items;
        }
    }
}
