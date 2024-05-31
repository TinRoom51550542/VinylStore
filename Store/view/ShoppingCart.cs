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
        DebitCard card = new DebitCard();
        BonusAccount account = new BonusAccount();
        public ShoppingCart()
        {
            presenter = new Presenter(this);
            InitializeComponent();
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void ShoppingCart_Load(object sender, EventArgs e)
        {
            var vinylrecords = presenter.GetCart();
            foreach (var record in vinylrecords)
            {
                listBoxCart.Items.Add(record);
            }
            labelBonusesAmount.Text = account.GetBalance().ToString();
            labelMoneyAmount.Text = card.GetBalance().ToString();

        }

        private void btnPayBonuses_Click(object sender, EventArgs e)
        {
        }

        private void btnPayCard_Click(object sender, EventArgs e)
        {
            CardPayment cardPayment = new CardPayment(card);

        }
    }
}
