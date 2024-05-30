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
            btnOpenCart = new Button();
            btnAddToCart = new Button();
            btnFind = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).BeginInit();
            SuspendLayout();
            // 
            // labelShoppingCart
            // 
            labelShoppingCart.AutoSize = true;
            labelShoppingCart.Font = new Font("IBM Plex Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelShoppingCart.Location = new Point(928, 35);
            labelShoppingCart.Name = "labelShoppingCart";
            labelShoppingCart.Size = new Size(70, 19);
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
            label3.Location = new Point(161, 19);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 2;
            label3.Text = "label3";
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
            richTextBoxDescription.Location = new Point(381, 339);
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
            listBoxShoppingCart.Location = new Point(865, 57);
            listBoxShoppingCart.Name = "listBoxShoppingCart";
            listBoxShoppingCart.Size = new Size(211, 327);
            listBoxShoppingCart.TabIndex = 9;
            // 
            // btnOpenCart
            // 
            btnOpenCart.Location = new Point(681, 35);
            btnOpenCart.Name = "btnOpenCart";
            btnOpenCart.Size = new Size(157, 33);
            btnOpenCart.TabIndex = 10;
            btnOpenCart.Text = "Открыть корзину";
            btnOpenCart.UseVisualStyleBackColor = true;
            btnOpenCart.Click += btnOpenCart_Click;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(88, 365);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1257, 563);
            Controls.Add(btnFind);
            Controls.Add(btnAddToCart);
            Controls.Add(btnOpenCart);
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
        private Button btnOpenCart;
        private Button btnAddToCart;
        private Button btnFind;
    }
}
