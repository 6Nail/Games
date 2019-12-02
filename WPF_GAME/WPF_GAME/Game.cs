using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_GAME
{
    public class Game
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public string DescImageFirst { get; set; }
        public string DescImageSecond { get; set; }
    }
}
