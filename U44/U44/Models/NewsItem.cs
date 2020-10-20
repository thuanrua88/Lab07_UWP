using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U44.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
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
            var allItems = getNewsItems();
            var filteredNewsItems = allItems.Where(p => p.Category == category).ToList();

            newsItems.Clear();

            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }

        private static List<NewsItem> getNewsItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Lorem Ipsum", Subhead = "doro sit amet", DateLine = "Nune tristique nec", Image = "Assets/financial1.png" });
            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Lorem Ipsum", Subhead = "doro sit amet", DateLine = "Nune tristique nec", Image = "Assets/financial2.png" });
            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Lorem Ipsum", Subhead = "doro sit amet", DateLine = "Nune tristique nec", Image = "Assets/financial3.png" });
            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Lorem Ipsum", Subhead = "doro sit amet", DateLine = "Nune tristique nec", Image = "Assets/financial4.png" });

            items.Add(new NewsItem() { Id = 1, Category = "Food", Headline = "Lorem Ipsum", Subhead = "doro sit amet", DateLine = "Nune tristique nec", Image = "Assets/food1.png" });
            items.Add(new NewsItem() { Id = 1, Category = "Food", Headline = "Lorem Ipsum", Subhead = "doro sit amet", DateLine = "Nune tristique nec", Image = "Assets/food2.png" });
            items.Add(new NewsItem() { Id = 1, Category = "Food", Headline = "Lorem Ipsum", Subhead = "doro sit amet", DateLine = "Nune tristique nec", Image = "Assets/food3.png" });
            items.Add(new NewsItem() { Id = 1, Category = "Food", Headline = "Lorem Ipsum", Subhead = "doro sit amet", DateLine = "Nune tristique nec", Image = "Assets/food4.png" });

            return items;
        }
    }
}
