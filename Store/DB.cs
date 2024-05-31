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
        List<VinylRecord> Cart = new List<VinylRecord>();
        public Database(Presenter presenter)
        {
            this.presenter = presenter;
        }
        List<VinylRecord> records = new List<VinylRecord>();

        public List<VinylRecord> GetRecords()
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
            records.Add(KiSHAA);
            records.Add(ManeskinRush);
            records.Add(ZveriGolod);
            records.Add(Leps);
            records.Add(Kino);
            records.Add(MBVL);
            records.Add(KOLW);
            records.Add(Blur);
            records.Add(Oasis);
            records.Add(rammros);
            records.Add(rammramm);
            records.Add(queennotw);
            records.Add(soadtoxicity);
            return records;
        }
        public List<VinylRecord> GetCart()
        {
            return Cart;
        }
        public void AddToCart(VinylRecord selectedVinylRecord, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Cart.Add(selectedVinylRecord);
            }
        }
        public void DeleteFromCart(VinylRecord selectedVinylRecord)
        {
            Cart.Remove(selectedVinylRecord);
        }
        public int TotalCart()
        {
            int summ = 0;
            foreach (VinylRecord vr in Cart)
            {
                summ += vr.Price;
            }
            return summ;
        }
        public int RecalculateCart(int amount)
        {
            return TotalCart() - amount;
        }
    }
}
