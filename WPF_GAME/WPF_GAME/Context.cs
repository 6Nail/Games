using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_GAME
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.EnsureCreated();
        }

        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NICK-PC\\SQLEXPRESS;Database=GameDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(new Game
            {
                Name = "Osu!",
                Genre = "Rhythm-game, Arcade",
                Description = "Бесплатная музыкальная игра с открытым исходным кодом, разработанная и опубликованная Дином Гербертом.",
                ReleaseDate = new DateTime(2007, 9, 16),
                Price = 0,
                Image = "https://upload.wikimedia.org/wikipedia/commons/d/d3/Osu%21Logo_%282015%29.png",
                DescImageFirst = "https://i.ppy.sh/b780aef2902af09784b18dc57ac5838a32f32097/687474703a2f2f7075752e73682f6e6b52437a2e6a7067",
                DescImageSecond = "https://i.ppy.sh/53985ce093447325d4a02c86098bc072a010eaf0/68747470733a2f2f6f73752e7070792e73682f68656c702f77696b692f496e746572666163652f696d672f496e74726f5f7374617469632e6a7067"
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                Name = "Royal Quest",
                Genre = "Fantasy, MMO",
                Description = "Массовая многопользовательская онлайн-игра, разрабатываемая компанией Katauri Interactive и выпускаемая компанией 1C.",
                ReleaseDate = new DateTime(2010, 10, 22),
                Price = 1200,
                Image = "http://logomogo.ru/uploads/Royal_Quest.png",
                DescImageFirst = "https://joborgame.ru/cdn/img/i/screen/royal-quest/royal_quest2.jpg",
                DescImageSecond = "https://joborgame.ru/cdn/img/i/screen/royal-quest/royal_quest1.jpg"
            });
        }
    }
}
