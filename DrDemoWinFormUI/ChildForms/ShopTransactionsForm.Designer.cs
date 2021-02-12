
namespace DrWinFormUI.ChildForms
{
    partial class ShopTransactionsForm
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
            this.lvwShopList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxAuthorTransactions = new System.Windows.Forms.GroupBox();
            this.rtxtShopAddress = new System.Windows.Forms.RichTextBox();
            this.btnUpdateShop = new System.Windows.Forms.Button();
            this.btnDeleteShop = new System.Windows.Forms.Button();
            this.btnAddShop = new System.Windows.Forms.Button();
            this.txtShopPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtShopEmail = new System.Windows.Forms.TextBox();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxAuthorTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwShopList
            // 
            this.lvwShopList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwShopList.FullRowSelect = true;
            this.lvwShopList.GridLines = true;
            this.lvwShopList.HideSelection = false;
            this.lvwShopList.Location = new System.Drawing.Point(88, 59);
            this.lvwShopList.Name = "lvwShopList";
            this.lvwShopList.Size = new System.Drawing.Size(1078, 365);
            this.lvwShopList.TabIndex = 16;
            this.lvwShopList.UseCompatibleStateImageBehavior = false;
            this.lvwShopList.View = System.Windows.Forms.View.Details;
            this.lvwShopList.Click += new System.EventHandler(this.lvwShopList_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kitabevi Adı";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon No";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E-Mail";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adres";
            this.columnHeader5.Width = 450;
            // 
            // gbxAuthorTransactions
            // 
            this.gbxAuthorTransactions.Controls.Add(this.rtxtShopAddress);
            this.gbxAuthorTransactions.Controls.Add(this.btnUpdateShop);
            this.gbxAuthorTransactions.Controls.Add(this.btnDeleteShop);
            this.gbxAuthorTransactions.Controls.Add(this.btnAddShop);
            this.gbxAuthorTransactions.Controls.Add(this.txtShopPhoneNumber);
            this.gbxAuthorTransactions.Controls.Add(this.txtShopEmail);
            this.gbxAuthorTransactions.Controls.Add(this.txtShopName);
            this.gbxAuthorTransactions.Controls.Add(this.label5);
            this.gbxAuthorTransactions.Controls.Add(this.label3);
            this.gbxAuthorTransactions.Controls.Add(this.label2);
            this.gbxAuthorTransactions.Controls.Add(this.label1);
            this.gbxAuthorTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAuthorTransactions.Location = new System.Drawing.Point(426, 430);
            this.gbxAuthorTransactions.Name = "gbxAuthorTransactions";
            this.gbxAuthorTransactions.Size = new System.Drawing.Size(490, 336);
            this.gbxAuthorTransactions.TabIndex = 15;
            this.gbxAuthorTransactions.TabStop = false;
            this.gbxAuthorTransactions.Text = "Yazar İşlemleri";
            // 
            // rtxtShopAddress
            // 
            this.rtxtShopAddress.Location = new System.Drawing.Point(178, 171);
            this.rtxtShopAddress.Name = "rtxtShopAddress";
            this.rtxtShopAddress.Size = new System.Drawing.Size(275, 96);
            this.rtxtShopAddress.TabIndex = 8;
            this.rtxtShopAddress.Text = "";
            // 
            // btnUpdateShop
            // 
            this.btnUpdateShop.Location = new System.Drawing.Point(195, 278);
            this.btnUpdateShop.Name = "btnUpdateShop";
            this.btnUpdateShop.Size = new System.Drawing.Size(118, 38);
            this.btnUpdateShop.TabIndex = 7;
            this.btnUpdateShop.Text = "Güncelle";
            this.btnUpdateShop.UseVisualStyleBackColor = true;
            this.btnUpdateShop.Click += new System.EventHandler(this.btnUpdateShop_Click);
            // 
            // btnDeleteShop
            // 
            this.btnDeleteShop.Location = new System.Drawing.Point(335, 278);
            this.btnDeleteShop.Name = "btnDeleteShop";
            this.btnDeleteShop.Size = new System.Drawing.Size(118, 38);
            this.btnDeleteShop.TabIndex = 7;
            this.btnDeleteShop.Text = "Sil";
            this.btnDeleteShop.UseVisualStyleBackColor = true;
            this.btnDeleteShop.Click += new System.EventHandler(this.btnDeleteShop_Click);
            // 
            // btnAddShop
            // 
            this.btnAddShop.Location = new System.Drawing.Point(41, 278);
            this.btnAddShop.Name = "btnAddShop";
            this.btnAddShop.Size = new System.Drawing.Size(118, 38);
            this.btnAddShop.TabIndex = 7;
            this.btnAddShop.Text = "Ekle";
            this.btnAddShop.UseVisualStyleBackColor = true;
            this.btnAddShop.Click += new System.EventHandler(this.btnAddShop_Click);
            // 
            // txtShopPhoneNumber
            // 
            this.txtShopPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtShopPhoneNumber.Location = new System.Drawing.Point(178, 82);
            this.txtShopPhoneNumber.Name = "txtShopPhoneNumber";
            this.txtShopPhoneNumber.Size = new System.Drawing.Size(275, 27);
            this.txtShopPhoneNumber.TabIndex = 4;
            // 
            // txtShopEmail
            // 
            this.txtShopEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtShopEmail.Location = new System.Drawing.Point(178, 127);
            this.txtShopEmail.Name = "txtShopEmail";
            this.txtShopEmail.Size = new System.Drawing.Size(275, 27);
            this.txtShopEmail.TabIndex = 4;
            // 
            // txtShopName
            // 
            this.txtShopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtShopName.Location = new System.Drawing.Point(178, 40);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(275, 27);
            this.txtShopName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Adres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Mail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitabevi Adı :";
            // 
            // ShopTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 807);
            this.Controls.Add(this.lvwShopList);
            this.Controls.Add(this.gbxAuthorTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopTransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ShopTransactionsForm";
            this.Load += new System.EventHandler(this.ShopTransactionsForm_Load);
            this.gbxAuthorTransactions.ResumeLayout(false);
            this.gbxAuthorTransactions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwShopList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox gbxAuthorTransactions;
        private System.Windows.Forms.RichTextBox rtxtShopAddress;
        private System.Windows.Forms.Button btnUpdateShop;
        private System.Windows.Forms.Button btnDeleteShop;
        private System.Windows.Forms.Button btnAddShop;
        private System.Windows.Forms.TextBox txtShopPhoneNumber;
        private System.Windows.Forms.TextBox txtShopEmail;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}