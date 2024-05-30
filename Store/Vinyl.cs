using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Store
{
    public class VinylRecord
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int YearOfRecord { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }

        public int GetPrice()
        {
            return Price;
        }

        public VinylRecord(string artist, string album, int year, int yearofrecord, string genre, string image, int price)
        {
            Artist = artist;
            Album = album;
            Year = year;
            Genre = genre;
            YearOfRecord = yearofrecord;
            Image = image;
            Price = price;
        }

        public string GetDescription()
        {
            return $"Исполнитель: {Artist} \nАльбом: {Album}\nГод релиза альбома: {Year}\nГод выпуска пластинки: {YearOfRecord} \nЖанр: {Genre}";
        }
        public override string ToString()
        {
            return $"{Artist} - {Album}";
        }
        public string GetImage()
        {
            return Image;
        }
    }
}
