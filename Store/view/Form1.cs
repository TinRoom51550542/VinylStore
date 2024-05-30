using Store.view;
using System.Windows.Forms;
using Store.presenter;
using System.Collections.Generic;
using System.Web;
using System;

namespace Store
{
    public partial class Form1 : Form, IView
    {
        private Presenter presenter;
        public Form1()
        {
            presenter = new Presenter(this);
            InitializeComponent();
        }
        ShoppingCart shoppingCart;

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
                    break;//прерываем цикл
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
            foreach (var pair in vinylrecords)
            {
                listBoxProducts.Items.Add(pair.Value);
            }
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
                VinylRecord selectedVinylRecord = (VinylRecord)listBoxProducts.SelectedItem;
                presenter.AddToCart(selectedVinylRecord);
            }
        }
    }
}
