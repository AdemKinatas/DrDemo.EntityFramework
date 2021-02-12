
namespace DrWinFormUI.ChildForms
{
    partial class AuthorTransactionsForm
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
            this.gbxAuthorTransactions = new System.Windows.Forms.GroupBox();
            this.btnUpdateAuthor = new System.Windows.Forms.Button();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.rtxtAuthorBiography = new System.Windows.Forms.RichTextBox();
            this.dpAuthorBirthDay = new System.Windows.Forms.DateTimePicker();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwAuthorsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxAuthorTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAuthorTransactions
            // 
            this.gbxAuthorTransactions.Controls.Add(this.btnUpdateAuthor);
            this.gbxAuthorTransactions.Controls.Add(this.btnDeleteAuthor);
            this.gbxAuthorTransactions.Controls.Add(this.btnAddAuthor);
            this.gbxAuthorTransactions.Controls.Add(this.rtxtAuthorBiography);
            this.gbxAuthorTransactions.Controls.Add(this.dpAuthorBirthDay);
            this.gbxAuthorTransactions.Controls.Add(this.txtAuthorName);
            this.gbxAuthorTransactions.Controls.Add(this.label4);
            this.gbxAuthorTransactions.Controls.Add(this.label3);
            this.gbxAuthorTransactions.Controls.Add(this.label1);
            this.gbxAuthorTransactions.Location = new System.Drawing.Point(433, 433);
            this.gbxAuthorTransactions.Name = "gbxAuthorTransactions";
            this.gbxAuthorTransactions.Size = new System.Drawing.Size(469, 336);
            this.gbxAuthorTransactions.TabIndex = 9;
            this.gbxAuthorTransactions.TabStop = false;
            this.gbxAuthorTransactions.Text = "Yazar İşlemleri";
            // 
            // btnUpdateAuthor
            // 
            this.btnUpdateAuthor.Location = new System.Drawing.Point(178, 245);
            this.btnUpdateAuthor.Name = "btnUpdateAuthor";
            this.btnUpdateAuthor.Size = new System.Drawing.Size(118, 38);
            this.btnUpdateAuthor.TabIndex = 7;
            this.btnUpdateAuthor.Text = "Güncelle";
            this.btnUpdateAuthor.UseVisualStyleBackColor = true;
            this.btnUpdateAuthor.Click += new System.EventHandler(this.btnUpdateAuthor_Click);
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.Location = new System.Drawing.Point(313, 245);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(118, 38);
            this.btnDeleteAuthor.TabIndex = 7;
            this.btnDeleteAuthor.Text = "Sil";
            this.btnDeleteAuthor.UseVisualStyleBackColor = true;
            this.btnDeleteAuthor.Click += new System.EventHandler(this.btnDeleteAuthor_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(41, 245);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(118, 38);
            this.btnAddAuthor.TabIndex = 7;
            this.btnAddAuthor.Text = "Ekle";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // rtxtAuthorBiography
            // 
            this.rtxtAuthorBiography.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxtAuthorBiography.Location = new System.Drawing.Point(197, 141);
            this.rtxtAuthorBiography.Name = "rtxtAuthorBiography";
            this.rtxtAuthorBiography.Size = new System.Drawing.Size(256, 86);
            this.rtxtAuthorBiography.TabIndex = 6;
            this.rtxtAuthorBiography.Text = "";
            // 
            // dpAuthorBirthDay
            // 
            this.dpAuthorBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dpAuthorBirthDay.Location = new System.Drawing.Point(197, 88);
            this.dpAuthorBirthDay.Name = "dpAuthorBirthDay";
            this.dpAuthorBirthDay.Size = new System.Drawing.Size(256, 27);
            this.dpAuthorBirthDay.TabIndex = 5;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAuthorName.Location = new System.Drawing.Point(197, 42);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(256, 27);
            this.txtAuthorName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Biyografisi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğum Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazar Adı Soyadı :";
            // 
            // lvwAuthorsList
            // 
            this.lvwAuthorsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwAuthorsList.FullRowSelect = true;
            this.lvwAuthorsList.GridLines = true;
            this.lvwAuthorsList.HideSelection = false;
            this.lvwAuthorsList.Location = new System.Drawing.Point(38, 71);
            this.lvwAuthorsList.Name = "lvwAuthorsList";
            this.lvwAuthorsList.Size = new System.Drawing.Size(1198, 356);
            this.lvwAuthorsList.TabIndex = 10;
            this.lvwAuthorsList.UseCompatibleStateImageBehavior = false;
            this.lvwAuthorsList.View = System.Windows.Forms.View.Details;
            this.lvwAuthorsList.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Yazar Adı-Soyadı";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Doğum Tarihi";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Biyografi";
            this.columnHeader5.Width = 750;
            // 
            // AuthorTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 770);
            this.Controls.Add(this.lvwAuthorsList);
            this.Controls.Add(this.gbxAuthorTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorTransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AuthorListForm";
            this.Load += new System.EventHandler(this.AuthorListForm_Load);
            this.gbxAuthorTransactions.ResumeLayout(false);
            this.gbxAuthorTransactions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAuthorTransactions;
        private System.Windows.Forms.Button btnUpdateAuthor;
        private System.Windows.Forms.Button btnDeleteAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.RichTextBox rtxtAuthorBiography;
        private System.Windows.Forms.DateTimePicker dpAuthorBirthDay;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwAuthorsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}