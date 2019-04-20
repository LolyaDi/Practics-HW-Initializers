using CitiesCatalog.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace CitiesCatalog.DataAccess
{
    public class DataInitializer: CreateDatabaseIfNotExists<DataContext>
    {
        private List<City> cities;

        public DataInitializer()
        {
            cities = new List<City>
            {
                new City { Code = 7172, Name = "Астана/Нур-султан" },
                new City { Code = 727, Name = "Алматы" },
                new City { Code = 7292, Name = "Актау" },
                new City { Code = 7122, Name = "Атырау" },
                new City { Code = 7142, Name = "Костанай" },
                new City { Code = 7162, Name = "Кокшетау/Кокчетав" },
                new City { Code = 7132, Name = "Актобе/Актюбинск" },
                new City { Code = 72822, Name = "Талдыкорган" },
                new City { Code = 7222, Name = "Семипалатинск" },
                new City { Code = 7182, Name = "Павлодар" },
                new City { Code = 7187, Name = "Экибастуз" },
                new City { Code = 7242, Name = "Кызылорда" },
                new City { Code = 72433, Name = "Арал/Аральск" },
                new City { Code = 7212, Name = "Караганда" },
                new City { Code = 7112, Name = "Уральск" },
                new City { Code = 7262, Name = "Тараз" },
                new City { Code = 7152, Name = "Петропавловск" },
                new City { Code = 7252, Name = "Шымкент" }
            };    
        }

        protected override void Seed(DataContext context)
        {
            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
