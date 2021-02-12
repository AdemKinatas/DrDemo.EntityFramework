
namespace DrWinFormUI.ChildForms
{
    partial class BookTransactionsForm
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
            this.lvwBooksList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxBookTransaction = new System.Windows.Forms.GroupBox();
            this.btnBookUpdate = new System.Windows.Forms.Button();
            this.nudAmountSold = new System.Windows.Forms.NumericUpDown();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.dpPublishedDate = new System.Windows.Forms.DateTimePicker();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.rtxtSummary = new System.Windows.Forms.RichTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.cmbBookPublisher = new System.Windows.Forms.ComboBox();
            this.cmbBookCategory = new System.Windows.Forms.ComboBox();
            this.cmbBookAuthor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxBookTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwBooksList
            // 
            this.lvwBooksList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader3,
            this.columnHeader1});
            this.lvwBooksList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvwBooksList.FullRowSelect = true;
            this.lvwBooksList.GridLines = true;
            this.lvwBooksList.HideSelection = false;
            this.lvwBooksList.Location = new System.Drawing.Point(53, 43);
            this.lvwBooksList.Name = "lvwBooksList";
            this.lvwBooksList.Size = new System.Drawing.Size(1167, 386);
            this.lvwBooksList.TabIndex = 0;
            this.lvwBooksList.UseCompatibleStateImageBehavior = false;
            this.lvwBooksList.View = System.Windows.Forms.View.Details;
            this.lvwBooksList.Click += new System.EventHandler(this.lvwBooksList_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kitap Adı";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yazarı";
            this.columnHeader4.Width = 123;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yayınevi ";
            this.columnHeader5.Width = 139;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kategori";
            this.columnHeader7.Width = 158;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fiyatı";
            this.columnHeader3.Width = 102;
            // 
            // gbxBookTransaction
            // 
            this.gbxBookTransaction.Controls.Add(this.btnBookUpdate);
            this.gbxBookTransaction.Controls.Add(this.nudUnitPrice);
            this.gbxBookTransaction.Controls.Add(this.nudAmountSold);
            this.gbxBookTransaction.Controls.Add(this.btnBookDelete);
            this.gbxBookTransaction.Controls.Add(this.dpPublishedDate);
            this.gbxBookTransaction.Controls.Add(this.btnBookAdd);
            this.gbxBookTransaction.Controls.Add(this.label22);
            this.gbxBookTransaction.Controls.Add(this.label24);
            this.gbxBookTransaction.Controls.Add(this.label1);
            this.gbxBookTransaction.Controls.Add(this.label23);
            this.gbxBookTransaction.Controls.Add(this.label18);
            this.gbxBookTransaction.Controls.Add(this.label19);
            this.gbxBookTransaction.Controls.Add(this.label20);
            this.gbxBookTransaction.Controls.Add(this.rtxtSummary);
            this.gbxBookTransaction.Controls.Add(this.label21);
            this.gbxBookTransaction.Controls.Add(this.txtBookName);
            this.gbxBookTransaction.Controls.Add(this.cmbBookPublisher);
            this.gbxBookTransaction.Controls.Add(this.cmbBookCategory);
            this.gbxBookTransaction.Controls.Add(this.cmbBookAuthor);
            this.gbxBookTransaction.Location = new System.Drawing.Point(221, 435);
            this.gbxBookTransaction.Name = "gbxBookTransaction";
            this.gbxBookTransaction.Size = new System.Drawing.Size(914, 333);
            this.gbxBookTransaction.TabIndex = 5;
            this.gbxBookTransaction.TabStop = false;
            this.gbxBookTransaction.Text = "Kitap İşlemleri";
            // 
            // btnBookUpdate
            // 
            this.btnBookUpdate.Location = new System.Drawing.Point(613, 186);
            this.btnBookUpdate.Name = "btnBookUpdate";
            this.btnBookUpdate.Size = new System.Drawing.Size(118, 38);
            this.btnBookUpdate.TabIndex = 8;
            this.btnBookUpdate.Text = "Güncelle";
            this.btnBookUpdate.UseVisualStyleBackColor = true;
            this.btnBookUpdate.Click += new System.EventHandler(this.btnBookUpdate_Click);
            // 
            // nudAmountSold
            // 
            this.nudAmountSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudAmountSold.Location = new System.Drawing.Point(614, 80);
            this.nudAmountSold.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudAmountSold.Name = "nudAmountSold";
            this.nudAmountSold.Size = new System.Drawing.Size(248, 27);
            this.nudAmountSold.TabIndex = 8;
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.Location = new System.Drawing.Point(748, 186);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(118, 38);
            this.btnBookDelete.TabIndex = 9;
            this.btnBookDelete.Text = "Sil";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            this.btnBookDelete.Click += new System.EventHandler(this.btnBookDelete_Click);
            // 
            // dpPublishedDate
            // 
            this.dpPublishedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dpPublishedDate.Location = new System.Drawing.Point(613, 35);
            this.dpPublishedDate.Name = "dpPublishedDate";
            this.dpPublishedDate.Size = new System.Drawing.Size(248, 27);
            this.dpPublishedDate.TabIndex = 7;
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(476, 186);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(118, 38);
            this.btnBookAdd.TabIndex = 10;
            this.btnBookAdd.Text = "Ekle";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(20, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 20);
            this.label22.TabIndex = 0;
            this.label22.Text = "Kitap Adı :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(473, 44);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(119, 20);
            this.label24.TabIndex = 3;
            this.label24.Text = "Basım Tarihi  :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(473, 125);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 20);
            this.label23.TabIndex = 3;
            this.label23.Text = "Fiyatı  :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(20, 167);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 20);
            this.label18.TabIndex = 3;
            this.label18.Text = "Yayınevi  :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(20, 214);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 20);
            this.label19.TabIndex = 3;
            this.label19.Text = "Özeti  :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(20, 123);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 20);
            this.label20.TabIndex = 2;
            this.label20.Text = "Kategorisi :";
            // 
            // rtxtSummary
            // 
            this.rtxtSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxtSummary.Location = new System.Drawing.Point(134, 218);
            this.rtxtSummary.Name = "rtxtSummary";
            this.rtxtSummary.Size = new System.Drawing.Size(275, 86);
            this.rtxtSummary.TabIndex = 6;
            this.rtxtSummary.Text = "";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(20, 84);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 20);
            this.label21.TabIndex = 1;
            this.label21.Text = "Yazarı :";
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookName.Location = new System.Drawing.Point(136, 37);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(275, 27);
            this.txtBookName.TabIndex = 4;
            // 
            // cmbBookPublisher
            // 
            this.cmbBookPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBookPublisher.FormattingEnabled = true;
            this.cmbBookPublisher.Location = new System.Drawing.Point(136, 163);
            this.cmbBookPublisher.Name = "cmbBookPublisher";
            this.cmbBookPublisher.Size = new System.Drawing.Size(275, 28);
            this.cmbBookPublisher.TabIndex = 5;
            // 
            // cmbBookCategory
            // 
            this.cmbBookCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBookCategory.FormattingEnabled = true;
            this.cmbBookCategory.Location = new System.Drawing.Point(136, 119);
            this.cmbBookCategory.Name = "cmbBookCategory";
            this.cmbBookCategory.Size = new System.Drawing.Size(275, 28);
            this.cmbBookCategory.TabIndex = 5;
            // 
            // cmbBookAuthor
            // 
            this.cmbBookAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBookAuthor.FormattingEnabled = true;
            this.cmbBookAuthor.Location = new System.Drawing.Point(136, 79);
            this.cmbBookAuthor.Name = "cmbBookAuthor";
            this.cmbBookAuthor.Size = new System.Drawing.Size(275, 28);
            this.cmbBookAuthor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(473, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Satış Adedi  :";
            // 
            // nudUnitPrice
            // 
            this.nudUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudUnitPrice.Location = new System.Drawing.Point(613, 123);
            this.nudUnitPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudUnitPrice.Name = "nudUnitPrice";
            this.nudUnitPrice.Size = new System.Drawing.Size(248, 27);
            this.nudUnitPrice.TabIndex = 8;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Özet";
            this.columnHeader1.Width = 587;
            // 
            // BookTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 796);
            this.Controls.Add(this.gbxBookTransaction);
            this.Controls.Add(this.lvwBooksList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookTransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.gbxBookTransaction.ResumeLayout(false);
            this.gbxBookTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwBooksList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox gbxBookTransaction;
        private System.Windows.Forms.Button btnBookUpdate;
        private System.Windows.Forms.NumericUpDown nudAmountSold;
        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.DateTimePicker dpPublishedDate;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RichTextBox rtxtSummary;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.ComboBox cmbBookPublisher;
        private System.Windows.Forms.ComboBox cmbBookCategory;
        private System.Windows.Forms.ComboBox cmbBookAuthor;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.NumericUpDown nudUnitPrice;
        private System.Windows.Forms.Label label1;
    }
}