using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store.presenter;

namespace Store.view
{
    public partial class ShoppingCart : Form, IView
    {
        private Presenter presenter;

        public ShoppingCart()
        {
            presenter = new Presenter(this);
            InitializeComponent();
        }
        EnterBonuses EnterBonuses = new EnterBonuses();
        private void ShoppingCart_Load(object sender, EventArgs e)
        {
            var vinylrecords = presenter.GetCart();
            foreach (var pair in vinylrecords)
            {
                listBoxCart.Items.Add(pair.Value);
            }
        }

        private void btnPayBonuses_Click(object sender, EventArgs e)
        {
            EnterBonuses.Show();
        }
    }
}
