namespace Store.view
{
    partial class ShoppingCart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxCart = new ListBox();
            label1 = new Label();
            btnPayCash = new Button();
            btnPayBonuses = new Button();
            btnPayCard = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelBonusesAmount = new Label();
            btnDelete = new Button();
            label6 = new Label();
            labelMoneyAmount = new Label();
            label8 = new Label();
            labelTotal = new Label();
            SuspendLayout();
            // 
            // listBoxCart
            // 
            listBoxCart.FormattingEnabled = true;
            listBoxCart.Location = new Point(12, 12);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new Size(272, 224);
            listBoxCart.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(499, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Оплата";
            // 
            // btnPayCash
            // 
            btnPayCash.Location = new Point(450, 32);
            btnPayCash.Name = "btnPayCash";
            btnPayCash.Size = new Size(157, 29);
            btnPayCash.TabIndex = 2;
            btnPayCash.Text = "Наличными";
            btnPayCash.UseVisualStyleBackColor = true;
            // 
            // btnPayBonuses
            // 
            btnPayBonuses.Location = new Point(450, 67);
            btnPayBonuses.Name = "btnPayBonuses";
            btnPayBonuses.Size = new Size(157, 29);
            btnPayBonuses.TabIndex = 3;
            btnPayBonuses.Text = "Бонусами";
            btnPayBonuses.UseVisualStyleBackColor = true;
            btnPayBonuses.Click += btnPayBonuses_Click;
            // 
            // btnPayCard
            // 
            btnPayCard.Location = new Point(450, 102);
            btnPayCard.Name = "btnPayCard";
            btnPayCard.Size = new Size(157, 29);
            btnPayCard.TabIndex = 4;
            btnPayCard.Text = "Дебетовой картой";
            btnPayCard.UseVisualStyleBackColor = true;
            btnPayCard.Click += btnPayCard_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 243);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 5;
            label2.Text = "Итого";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(247, 243);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 6;
            label3.Text = "0 ₽";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(629, 32);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 7;
            label4.Text = "Бонусы:";
            // 
            // labelBonusesAmount
            // 
            labelBonusesAmount.AutoSize = true;
            labelBonusesAmount.Location = new Point(699, 32);
            labelBonusesAmount.Name = "labelBonusesAmount";
            labelBonusesAmount.Size = new Size(41, 20);
            labelBonusesAmount.TabIndex = 8;
            labelBonusesAmount.Text = "1000";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(304, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(633, 64);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 10;
            label6.Text = "Карта:";
            // 
            // labelMoneyAmount
            // 
            labelMoneyAmount.AutoSize = true;
            labelMoneyAmount.Location = new Point(699, 64);
            labelMoneyAmount.Name = "labelMoneyAmount";
            labelMoneyAmount.Size = new Size(41, 20);
            labelMoneyAmount.TabIndex = 11;
            labelMoneyAmount.Text = "1000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(492, 185);
            label8.Name = "label8";
            label8.Size = new Size(92, 28);
            label8.TabIndex = 12;
            label8.Text = "К оплате";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTotal.Location = new Point(629, 188);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(37, 25);
            labelTotal.TabIndex = 13;
            labelTotal.Text = "0 ₽";
            // 
            // ShoppingCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 282);
            Controls.Add(labelTotal);
            Controls.Add(label8);
            Controls.Add(labelMoneyAmount);
            Controls.Add(label6);
            Controls.Add(btnDelete);
            Controls.Add(labelBonusesAmount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnPayCard);
            Controls.Add(btnPayBonuses);
            Controls.Add(btnPayCash);
            Controls.Add(label1);
            Controls.Add(listBoxCart);
            Name = "ShoppingCart";
            Text = "ShoppingCart";
            Load += ShoppingCart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxCart;
        private Label label1;
        private Button btnPayCash;
        private Button btnPayBonuses;
        private Button btnPayCard;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelBonusesAmount;
        private Button btnDelete;
        private Label label6;
        private Label labelMoneyAmount;
        private Label label8;
        private Label labelTotal;
    }
}