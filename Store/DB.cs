using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store.presenter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Store
{
    internal class Database
    {
        public Presenter presenter;
        public Dictionary<string, VinylRecord> Cart;
        public Database(Presenter presenter)
        {
            this.presenter = presenter;
        }
        Dictionary<string, VinylRecord> records = new Dictionary<string, VinylRecord>();

        public Dictionary<string, VinylRecord> GetRecords()
        {

            var KiSHAA = new VinylRecord("Король и Шут", "Акустический альбом", 1998, 2023, "Панк", "Обложки/КИШАкустическийальбом.jpg", 5500);
            var ManeskinRush = new VinylRecord("Maneskin", "Rush", 2023, 2023, "Поп-Рок", "Обложки/maneskinrush.jpg", 4800);
            var ZveriGolod = new VinylRecord("Звери", "Голод", 2003, 2021, "Рок", "Обложки/ЗвериГолод.jpg", 6000);
            var Leps = new VinylRecord("Григорий Лепс", "Полный вперед!", 2012, 2012, "Поп", "Обложки/ГригорийЛепсПолныйВперед.jpg", 4500);
            var Kino = new VinylRecord("Кино", "Это не любовь...", 1985, 2022, "Рок", "Обложки/КиноЭтонелюбовь.jpg", 5500);
            var MBVL = new VinylRecord("My Bloody Valentine", "Loveless", 1991, 2021, "Инди Рок", "Обложки/mybloodyvalentine.jpg", 6500);
            var KOLW = new VinylRecord("Kings Of Leon", "WALLS", 2016, 2016, "Рок", "Обложки/kingsofleonwalls.jpg", 4800);
            var Blur = new VinylRecord("Blur", "The Great Escape", 1995, 2012, "Брит Поп", "Обложки/blurthegreatescape.jpg", 5500);
            var Oasis = new VinylRecord("Oasis", "(What's the Story) Morning Glory?", 1995, 2019, "Брит Поп", "Обложки/oasiswtsmg.jpeg", 5990);
            var rammros = new VinylRecord("Rammstein", "Rosenrot", 2005, 2017, "Рок", "Обложки/rammsteinrosenrot.jpg", 8000);
            var rammramm = new VinylRecord("Rammstein", "Rammstein", 2019, 2019, "Рок", "Обложки/rammstein.jpg", 6000);
            var queennotw = new VinylRecord("Queen", "News Of The World", 1977, 1977, "Рок", "Обложки/queennewsoftheworld.jpg", 7500);
            var soadtoxicity = new VinylRecord("System Of A Down", "Toxicity", 2001, 2018, "Альтернативный Рок", "Обложки/soadtoxicity.jpg", 3500);
            records.Add("Король и Шут - Акустический альбом", KiSHAA);
            records.Add("Maneskin - Rush", ManeskinRush);
            records.Add("Звери - Голод", ZveriGolod);
            records.Add("Григорий Лепс - Полный вперед!", Leps);
            records.Add("Кино - Это не любовь...", Kino);
            records.Add("My Bloody Valentine - Loveless", MBVL);
            records.Add("Kings Of Leon - WALLS", KOLW);
            records.Add("Blur - The Great Escape", Blur);
            records.Add("Oasis - (What's the Story) Morning Glory?", Oasis);
            records.Add("Rammstein - Rosenrot", rammros);
            records.Add("Rammstein - Rammstein", rammramm);
            records.Add("Queen - News Of The World", queennotw);
            records.Add("System Of A Down - Toxicity", soadtoxicity);
            return records;
        }
        public Dictionary<string, VinylRecord> GetCart()
        {
            return Cart;
        }
        public Dictionary<string, VinylRecord> AddToCart(VinylRecord selectedVinylRecord)
        {
            //Cart.Add(key, selectedVinylRecord);
            //Cart.Add(records.Values.FirstOrDefault(record => record.Equals(selectedVinylRecord)));
            return Cart;
        }
    }
}
