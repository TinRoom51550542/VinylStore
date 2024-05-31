using Store.view;
using System.Windows.Forms;
using Store.presenter;
using System.Collections.Generic;
using System.Web;
using System;
using System.Security.Principal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Store
{
    public partial class Form1 : Form, IView
    {
        private Presenter presenter;
        DebitCard card = new DebitCard();
        BonusAccount account = new BonusAccount();
        public Form1()
        {
            presenter = new Presenter(this);
            InitializeComponent();
        }
        ShoppingCart shoppingCart;
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnOpenCart_Click(object sender, EventArgs e)
        {
            shoppingCart = new ShoppingCart();
            shoppingCart.Show();
        }
        private int lastFoundIndex = -1;
        private void btnFind_Click(object sender, EventArgs e)
        {
            int i;
            for (i = lastFoundIndex + 1; i < listBoxProducts.Items.Count; i++)
            {
                var currVal = listBoxProducts.Items[i].ToString();
                if (currVal.IndexOf(textBoxSearch.Text, StringComparison.OrdinalIgnoreCase) > -1)
                {
                    listBoxProducts.SetSelected(i, true);
                    lastFoundIndex = i;
                    break;
                }
            }
            if (lastFoundIndex > -1 && i == listBoxProducts.Items.Count)
            {
                for (i = 0; i <= lastFoundIndex; i++)
                {
                    var currVal = listBoxProducts.Items[i].ToString();
                    if (currVal.IndexOf(textBoxSearch.Text, StringComparison.OrdinalIgnoreCase) > -1)
                    {
                        listBoxProducts.SetSelected(i, true);
                        lastFoundIndex = i;
                        break;//прерываем цикл
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var vinylrecords = presenter.GetVinylRecords();
            foreach (var record in vinylrecords)
            {
                listBoxProducts.Items.Add(record);
            }
            labelBonusesAmount.Text = account.GetBalance().ToString();
            labelMoneyAmount.Text = card.GetBalance().ToString();
        }
        private void listBoxProducts_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem != null)
            {
                VinylRecord selectedVinylRecord = (VinylRecord)listBoxProducts.SelectedItem;
                richTextBoxDescription.Text = presenter.GetDescriptionOfVinylRecord(selectedVinylRecord);
                pictureBoxCover.Image = Image.FromFile(presenter.GetImage(selectedVinylRecord));
                int price = presenter.GetPriceOfVinyl(selectedVinylRecord);
                labelPrice.Text = price.ToString() + " ₽";
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem != null)
            {
                string? text = textBoxAmount.Text;
                int amount;
                if (int.TryParse(text, out amount))
                {
                    VinylRecord selectedVinylRecord = (VinylRecord)listBoxProducts.SelectedItem;
                    presenter.AddToCart(selectedVinylRecord, amount);
                    MessageBox.Show("Товар успешно добавлен!");
                    listBoxShoppingCart.Items.Clear();
                    var cart = presenter.GetCart();
                    foreach (var record in cart)
                    {
                        listBoxShoppingCart.Items.Add(record);
                    }
                }
                else
                {
                    MessageBox.Show("Введите количество товара.");
                }
            }
            labelTotal.Text = presenter.GetTotalCart().ToString() + " ₽";
        }

        private void btnDeleteFromCart_Click(object sender, EventArgs e)
        {
            if (listBoxShoppingCart.SelectedItem != null)
            {
                VinylRecord selectedVinylRecord = (VinylRecord)listBoxShoppingCart.SelectedItem;
                presenter.DeleteFromCart(selectedVinylRecord);
                MessageBox.Show("Товар удален из корзины!");
                listBoxShoppingCart.Items.Clear();
                var cart = presenter.GetCart();
                foreach (var record in cart)
                {
                    listBoxShoppingCart.Items.Add(record);
                }
                labelTotal.Text = presenter.GetTotalCart().ToString() + " ₽";
            }
        }

        private void btnPayCash_Click(object sender, EventArgs e)
        {

        }

        private void btnPayCard_Click(object sender, EventArgs e)
        {
            int amount = presenter.GetTotalCart();
            CardPayment cardPayment = new CardPayment(card);
            presenter.PayingCard(cardPayment, amount);
            labelMoneyAmount.Text = presenter.GetBalanceFromCard(card).ToString();
        }

        private void bthPayBonuses_Click(object sender, EventArgs e)
        {
            string? text = textBoxInputBonuses.Text;
            int amount;
            BonusesPayment bonusesPayment = new BonusesPayment(account);
            if (int.TryParse(text, out amount))
            {
                presenter.PayingBonuses(bonusesPayment, amount);
            }
            else
            {
                MessageBox.Show("Введите количество бонусов для списания.");
            }
            labelBonusesAmount.Text = presenter.GetBalanceFromAccount(account).ToString();
            labelTotal.Text = presenter.GetTotalCart().ToString();
        }
    }
}
