using Store.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Store.presenter
{
    internal class Presenter
    {
        private IView view;
        private Database db;
        public Presenter(IView view)
        {
            this.view = view;
            db = new Database(this);
        }
        public int GetPriceOfVinyl(VinylRecord vinylrecord)
        {
            return vinylrecord.GetPrice();
        }
        public Dictionary<string, VinylRecord> GetVinylRecords()
        {
            return db.GetRecords();
        }
        public string GetDescriptionOfVinylRecord(VinylRecord vinylRecord)
        {
            return vinylRecord.GetDescription();
        }
        public string GetImage(VinylRecord vinylRecord)
        {
            return vinylRecord.GetImage();
        }
        public Dictionary<string, VinylRecord> GetCart()
        {
            return db.GetCart(); 
        }
        public Dictionary<string, VinylRecord> AddToCart(VinylRecord vinylRecord)
        {
            return db.AddToCart(vinylRecord);
        }
    }
}
