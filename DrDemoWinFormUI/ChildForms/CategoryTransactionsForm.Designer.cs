
namespace DrWinFormUI.ChildForms
{
    partial class CategoryTransactionsForm
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
            this.lvwCategoryList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxAuthorTransactions = new System.Windows.Forms.GroupBox();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpAddedDate = new System.Windows.Forms.DateTimePicker();
            this.cmbParentCategory = new System.Windows.Forms.ComboBox();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.cbNotActive = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPopuler = new System.Windows.Forms.CheckBox();
            this.cbNotPopuler = new System.Windows.Forms.CheckBox();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxAuthorTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwCategoryList
            // 
            this.lvwCategoryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwCategoryList.FullRowSelect = true;
            this.lvwCategoryList.GridLines = true;
            this.lvwCategoryList.HideSelection = false;
            this.lvwCategoryList.Location = new System.Drawing.Point(46, 71);
            this.lvwCategoryList.Name = "lvwCategoryList";
            this.lvwCategoryList.Size = new System.Drawing.Size(1078, 333);
            this.lvwCategoryList.TabIndex = 12;
            this.lvwCategoryList.UseCompatibleStateImageBehavior = false;
            this.lvwCategoryList.View = System.Windows.Forms.View.Details;
            this.lvwCategoryList.Click += new System.EventHandler(this.lvwCategoryList_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategori Adı";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Üst Kategori";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Aktiflik Durumu";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Popülerlik Durumu";
            this.columnHeader5.Width = 150;
            // 
            // gbxAuthorTransactions
            // 
            this.gbxAuthorTransactions.Controls.Add(this.cbNotPopuler);
            this.gbxAuthorTransactions.Controls.Add(this.cbPopuler);
            this.gbxAuthorTransactions.Controls.Add(this.cbNotActive);
            this.gbxAuthorTransactions.Controls.Add(this.cbActive);
            this.gbxAuthorTransactions.Controls.Add(this.cmbParentCategory);
            this.gbxAuthorTransactions.Controls.Add(this.btnUpdateCategory);
            this.gbxAuthorTransactions.Controls.Add(this.btnDeleteCategory);
            this.gbxAuthorTransactions.Controls.Add(this.btnAddCategory);
            this.gbxAuthorTransactions.Controls.Add(this.dpAddedDate);
            this.gbxAuthorTransactions.Controls.Add(this.txtCategoryName);
            this.gbxAuthorTransactions.Controls.Add(this.label5);
            this.gbxAuthorTransactions.Controls.Add(this.label4);
            this.gbxAuthorTransactions.Controls.Add(this.label3);
            this.gbxAuthorTransactions.Controls.Add(this.label2);
            this.gbxAuthorTransactions.Controls.Add(this.label1);
            this.gbxAuthorTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAuthorTransactions.Location = new System.Drawing.Point(369, 424);
            this.gbxAuthorTransactions.Name = "gbxAuthorTransactions";
            this.gbxAuthorTransactions.Size = new System.Drawing.Size(490, 336);
            this.gbxAuthorTransactions.TabIndex = 11;
            this.gbxAuthorTransactions.TabStop = false;
            this.gbxAuthorTransactions.Text = "Yazar İşlemleri";
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(178, 278);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(118, 38);
            this.btnUpdateCategory.TabIndex = 7;
            this.btnUpdateCategory.Text = "Güncelle";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(313, 278);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(118, 38);
            this.btnDeleteCategory.TabIndex = 7;
            this.btnDeleteCategory.Text = "Sil";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(41, 278);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(118, 38);
            this.btnAddCategory.TabIndex = 7;
            this.btnAddCategory.Text = "Ekle";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategoryName.Location = new System.Drawing.Point(178, 40);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(275, 27);
            this.txtCategoryName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Aktiflik Durumu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eklenme Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Üst Kategorisi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı :";
            // 
            // dpAddedDate
            // 
            this.dpAddedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dpAddedDate.Location = new System.Drawing.Point(178, 121);
            this.dpAddedDate.Name = "dpAddedDate";
            this.dpAddedDate.Size = new System.Drawing.Size(275, 27);
            this.dpAddedDate.TabIndex = 5;
            // 
            // cmbParentCategory
            // 
            this.cmbParentCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParentCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbParentCategory.FormattingEnabled = true;
            this.cmbParentCategory.Location = new System.Drawing.Point(178, 81);
            this.cmbParentCategory.Name = "cmbParentCategory";
            this.cmbParentCategory.Size = new System.Drawing.Size(275, 28);
            this.cmbParentCategory.TabIndex = 8;
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(203, 170);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(65, 24);
            this.cbActive.TabIndex = 9;
            this.cbActive.Text = "True";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // cbNotActive
            // 
            this.cbNotActive.AutoSize = true;
            this.cbNotActive.Location = new System.Drawing.Point(322, 170);
            this.cbNotActive.Name = "cbNotActive";
            this.cbNotActive.Size = new System.Drawing.Size(72, 24);
            this.cbNotActive.TabIndex = 9;
            this.cbNotActive.Text = "False";
            this.cbNotActive.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Popülerlik Durumu :";
            // 
            // cbPopuler
            // 
            this.cbPopuler.AutoSize = true;
            this.cbPopuler.Location = new System.Drawing.Point(203, 209);
            this.cbPopuler.Name = "cbPopuler";
            this.cbPopuler.Size = new System.Drawing.Size(65, 24);
            this.cbPopuler.TabIndex = 9;
            this.cbPopuler.Text = "True";
            this.cbPopuler.UseVisualStyleBackColor = true;
            // 
            // cbNotPopuler
            // 
            this.cbNotPopuler.AutoSize = true;
            this.cbNotPopuler.Location = new System.Drawing.Point(322, 209);
            this.cbNotPopuler.Name = "cbNotPopuler";
            this.cbNotPopuler.Size = new System.Drawing.Size(72, 24);
            this.cbNotPopuler.TabIndex = 9;
            this.cbNotPopuler.Text = "False";
            this.cbNotPopuler.UseVisualStyleBackColor = true;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Eklenme Tarihi";
            this.columnHeader6.Width = 150;
            // 
            // CategoryTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 772);
            this.Controls.Add(this.lvwCategoryList);
            this.Controls.Add(this.gbxAuthorTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryTransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CategoryTransactionsForm";
            this.Load += new System.EventHandler(this.CategoryTransactionsForm_Load);
            this.gbxAuthorTransactions.ResumeLayout(false);
            this.gbxAuthorTransactions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwCategoryList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox gbxAuthorTransactions;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.CheckBox cbNotPopuler;
        private System.Windows.Forms.CheckBox cbPopuler;
        private System.Windows.Forms.CheckBox cbNotActive;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.ComboBox cmbParentCategory;
        private System.Windows.Forms.DateTimePicker dpAddedDate;
        private System.Windows.Forms.Label label4;
    }
}