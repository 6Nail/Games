using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WPF_GAME
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (var context = new Context())
            {
                var games = context.Games.Select(game => game.Name).ToList();
                listBoxGame.ItemsSource = games;

                var game = context.Games.First();
                gameImage.Source = new BitmapImage(new Uri(game.Image, UriKind.Absolute));
                gameName.Content = game.Name;
                gameDescription.Text = game.Description;
                gameImageFirst.Source = new BitmapImage(new Uri(game.DescImageFirst, UriKind.Absolute));
                gameImageSecond.Source = new BitmapImage(new Uri(game.DescImageSecond, UriKind.Absolute));
                gameDate.Content = game.ReleaseDate.ToShortDateString();
                gameGenre.Content = game.Genre;
                gamePrice.Content = game.Price == 0 ? "Бесплатная" : game.Price.ToString();
            }
        }

        private void ListBoxGameShow(object sender, MouseButtonEventArgs e)
        {
            var item = ItemsControl.ContainerFromElement(sender as ListBox, e.OriginalSource as DependencyObject) as ListBoxItem;
            if (item != null)
            {
                using (var context = new Context())
                {
                    var game = context.Games.SingleOrDefault(game => game.Name == item.Content.ToString());
                    gameImage.Source = new BitmapImage(new Uri(game.Image, UriKind.Absolute));
                    gameName.Content = game.Name;
                    gameDescription.Text = game.Description;
                    gameImageFirst.Source = new BitmapImage(new Uri(game.DescImageFirst, UriKind.Absolute));
                    gameImageSecond.Source = new BitmapImage(new Uri(game.DescImageSecond, UriKind.Absolute));
                    gameDate.Content = game.ReleaseDate.ToShortDateString();
                    gameGenre.Content = game.Genre;
                    gamePrice.Content = game.Price == 0 ? "Бесплатная" : game.Price.ToString();
                }
            }
        }
    }
}
