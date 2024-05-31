using System.Windows.Forms;

namespace Store
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelShoppingCart = new Label();
            labelPrice = new Label();
            label3 = new Label();
            pictureBoxCover = new PictureBox();
            labelDescription = new Label();
            richTextBoxDescription = new RichTextBox();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            listBoxProducts = new ListBox();
            listBoxShoppingCart = new ListBox();
            btnAddToCart = new Button();
            btnFind = new Button();
            btnDeleteFromCart = new Button();
            label1 = new Label();
            btnPayCash = new Button();
            btnPayCard = new Button();
            bthPayBonuses = new Button();
            labelTotal = new Label();
            label8 = new Label();
            labelMoneyAmount = new Label();
            label6 = new Label();
            labelBonusesAmount = new Label();
            label4 = new Label();
            textBoxAmount = new TextBox();
            label2 = new Label();
            textBoxInputBonuses = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).BeginInit();
            SuspendLayout();
            // 
            // labelShoppingCart
            // 
            labelShoppingCart.AutoSize = true;
            labelShoppingCart.Font = new Font("IBM Plex Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelShoppingCart.Location = new Point(830, 7);
            labelShoppingCart.Name = "labelShoppingCart";
            labelShoppingCart.Size = new Size(93, 27);
            labelShoppingCart.TabIndex = 0;
            labelShoppingCart.Text = "Корзина";
            // 
            // labelPrice
            // 
            labelPrice.Font = new Font("IBM Plex Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPrice.Location = new Point(473, 266);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(105, 30);
            labelPrice.TabIndex = 1;
            labelPrice.Text = "0 ₽";
            labelPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("IBM Plex Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(153, 11);
            label3.Name = "label3";
            label3.Size = new Size(87, 27);
            label3.TabIndex = 2;
            label3.Text = "Каталог";
            // 
            // pictureBoxCover
            // 
            pictureBoxCover.Location = new Point(421, 35);
            pictureBoxCover.Name = "pictureBoxCover";
            pictureBoxCover.Size = new Size(200, 200);
            pictureBoxCover.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCover.TabIndex = 3;
            pictureBoxCover.TabStop = false;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(482, 316);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(80, 19);
            labelDescription.TabIndex = 4;
            labelDescription.Text = "Описание";
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(379, 338);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(284, 120);
            richTextBoxDescription.TabIndex = 5;
            richTextBoxDescription.Text = "";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(115, 41);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(125, 27);
            textBoxSearch.TabIndex = 6;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(40, 44);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(52, 19);
            labelSearch.TabIndex = 7;
            labelSearch.Text = "Поиск";
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 19;
            listBoxProducts.Location = new Point(40, 84);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(311, 251);
            listBoxProducts.TabIndex = 8;
            listBoxProducts.Click += listBoxProducts_Click;
            // 
            // listBoxShoppingCart
            // 
            listBoxShoppingCart.FormattingEnabled = true;
            listBoxShoppingCart.ItemHeight = 19;
            listBoxShoppingCart.Location = new Point(699, 55);
            listBoxShoppingCart.Name = "listBoxShoppingCart";
            listBoxShoppingCart.Size = new Size(224, 327);
            listBoxShoppingCart.TabIndex = 9;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(76, 374);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(202, 29);
            btnAddToCart.TabIndex = 11;
            btnAddToCart.Text = "Добавить в корзину";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(257, 39);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 12;
            btnFind.Text = "Найти";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnDeleteFromCart
            // 
            btnDeleteFromCart.Location = new Point(721, 388);
            btnDeleteFromCart.Name = "btnDeleteFromCart";
            btnDeleteFromCart.Size = new Size(170, 29);
            btnDeleteFromCart.TabIndex = 13;
            btnDeleteFromCart.Text = "Удалить из корзины";
            btnDeleteFromCart.UseVisualStyleBackColor = true;
            btnDeleteFromCart.Click += btnDeleteFromCart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(978, 39);
            label1.Name = "label1";
            label1.Size = new Size(60, 19);
            label1.TabIndex = 14;
            label1.Text = "Оплата";
            // 
            // btnPayCash
            // 
            btnPayCash.Location = new Point(956, 64);
            btnPayCash.Name = "btnPayCash";
            btnPayCash.Size = new Size(106, 29);
            btnPayCash.TabIndex = 15;
            btnPayCash.Text = "Наличными";
            btnPayCash.UseVisualStyleBackColor = true;
            btnPayCash.Click += btnPayCash_Click;
            // 
            // btnPayCard
            // 
            btnPayCard.Location = new Point(956, 112);
            btnPayCard.Name = "btnPayCard";
            btnPayCard.Size = new Size(106, 29);
            btnPayCard.TabIndex = 16;
            btnPayCard.Text = "Картой";
            btnPayCard.UseVisualStyleBackColor = true;
            btnPayCard.Click += btnPayCard_Click;
            // 
            // bthPayBonuses
            // 
            bthPayBonuses.Location = new Point(956, 161);
            bthPayBonuses.Name = "bthPayBonuses";
            bthPayBonuses.Size = new Size(106, 29);
            bthPayBonuses.TabIndex = 17;
            bthPayBonuses.Text = "Бонусами";
            bthPayBonuses.UseVisualStyleBackColor = true;
            bthPayBonuses.Click += bthPayBonuses_Click;
            // 
            // labelTotal
            // 
            labelTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTotal.Location = new Point(951, 442);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(139, 25);
            labelTotal.TabIndex = 19;
            labelTotal.Text = "0 ₽";
            labelTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(862, 439);
            label8.Name = "label8";
            label8.Size = new Size(92, 28);
            label8.TabIndex = 18;
            label8.Text = "К оплате";
            // 
            // labelMoneyAmount
            // 
            labelMoneyAmount.AutoSize = true;
            labelMoneyAmount.Location = new Point(1017, 256);
            labelMoneyAmount.Name = "labelMoneyAmount";
            labelMoneyAmount.Size = new Size(45, 19);
            labelMoneyAmount.TabIndex = 23;
            labelMoneyAmount.Text = "1000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(951, 256);
            label6.Name = "label6";
            label6.Size = new Size(55, 19);
            label6.TabIndex = 22;
            label6.Text = "Карта:";
            // 
            // labelBonusesAmount
            // 
            labelBonusesAmount.AutoSize = true;
            labelBonusesAmount.Location = new Point(1017, 224);
            labelBonusesAmount.Name = "labelBonusesAmount";
            labelBonusesAmount.Size = new Size(45, 19);
            labelBonusesAmount.TabIndex = 21;
            labelBonusesAmount.Text = "1000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(947, 224);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 20;
            label4.Text = "Бонусы:";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(188, 341);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(90, 27);
            textBoxAmount.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 344);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 25;
            label2.Text = "Количество";
            // 
            // textBoxInputBonuses
            // 
            textBoxInputBonuses.Location = new Point(1087, 161);
            textBoxInputBonuses.Name = "textBoxInputBonuses";
            textBoxInputBonuses.Size = new Size(125, 27);
            textBoxInputBonuses.TabIndex = 26;
            // 
            // label5
            // 
            label5.Location = new Point(1068, 112);
            label5.Name = "label5";
            label5.Size = new Size(160, 39);
            label5.TabIndex = 27;
            label5.Text = "Количество бонусов для списания";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1257, 501);
            Controls.Add(label5);
            Controls.Add(textBoxInputBonuses);
            Controls.Add(label2);
            Controls.Add(textBoxAmount);
            Controls.Add(labelMoneyAmount);
            Controls.Add(label6);
            Controls.Add(labelBonusesAmount);
            Controls.Add(label4);
            Controls.Add(labelTotal);
            Controls.Add(label8);
            Controls.Add(bthPayBonuses);
            Controls.Add(btnPayCard);
            Controls.Add(btnPayCash);
            Controls.Add(label1);
            Controls.Add(btnDeleteFromCart);
            Controls.Add(btnFind);
            Controls.Add(btnAddToCart);
            Controls.Add(listBoxShoppingCart);
            Controls.Add(listBoxProducts);
            Controls.Add(labelSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(richTextBoxDescription);
            Controls.Add(labelDescription);
            Controls.Add(pictureBoxCover);
            Controls.Add(label3);
            Controls.Add(labelPrice);
            Controls.Add(labelShoppingCart);
            Font = new Font("IBM Plex Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelShoppingCart;
        private Label labelPrice;
        private Label label3;
        private PictureBox pictureBoxCover;
        private Label labelDescription;
        private RichTextBox richTextBoxDescription;
        private TextBox textBoxSearch;
        private Label labelSearch;
        private ListBox listBoxProducts;
        private ListBox listBoxShoppingCart;
        private Button btnAddToCart;
        private Button btnFind;
        private Button btnDeleteFromCart;
        private Label label1;
        private Button btnPayCash;
        private Button btnPayCard;
        private Button bthPayBonuses;
        private Label labelTotal;
        private Label label8;
        private Label labelMoneyAmount;
        private Label label6;
        private Label labelBonusesAmount;
        private Label label4;
        private TextBox textBoxAmount;
        private Label label2;
        private TextBox textBoxInputBonuses;
        private Label label5;
    }
}
