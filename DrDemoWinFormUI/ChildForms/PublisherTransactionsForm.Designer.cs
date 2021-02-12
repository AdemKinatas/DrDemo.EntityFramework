
namespace DrWinFormUI.ChildForms
{
    partial class PublisherTransactionsForm
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
            this.lvwPublisherList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxAuthorTransactions = new System.Windows.Forms.GroupBox();
            this.rtxtPublisherAddress = new System.Windows.Forms.RichTextBox();
            this.btnUpdatePublisher = new System.Windows.Forms.Button();
            this.btnDeletePublisher = new System.Windows.Forms.Button();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.txtPublisherPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPublisherEmail = new System.Windows.Forms.TextBox();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxAuthorTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwPublisherList
            // 
            this.lvwPublisherList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwPublisherList.FullRowSelect = true;
            this.lvwPublisherList.GridLines = true;
            this.lvwPublisherList.HideSelection = false;
            this.lvwPublisherList.Location = new System.Drawing.Point(82, 84);
            this.lvwPublisherList.Name = "lvwPublisherList";
            this.lvwPublisherList.Size = new System.Drawing.Size(1078, 365);
            this.lvwPublisherList.TabIndex = 14;
            this.lvwPublisherList.UseCompatibleStateImageBehavior = false;
            this.lvwPublisherList.View = System.Windows.Forms.View.Details;
            this.lvwPublisherList.Click += new System.EventHandler(this.lvwPublisherList_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Yayınevi Adı";
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
            this.gbxAuthorTransactions.Controls.Add(this.rtxtPublisherAddress);
            this.gbxAuthorTransactions.Controls.Add(this.btnUpdatePublisher);
            this.gbxAuthorTransactions.Controls.Add(this.btnDeletePublisher);
            this.gbxAuthorTransactions.Controls.Add(this.btnAddPublisher);
            this.gbxAuthorTransactions.Controls.Add(this.txtPublisherPhoneNumber);
            this.gbxAuthorTransactions.Controls.Add(this.txtPublisherEmail);
            this.gbxAuthorTransactions.Controls.Add(this.txtPublisherName);
            this.gbxAuthorTransactions.Controls.Add(this.label5);
            this.gbxAuthorTransactions.Controls.Add(this.label3);
            this.gbxAuthorTransactions.Controls.Add(this.label2);
            this.gbxAuthorTransactions.Controls.Add(this.label1);
            this.gbxAuthorTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAuthorTransactions.Location = new System.Drawing.Point(420, 455);
            this.gbxAuthorTransactions.Name = "gbxAuthorTransactions";
            this.gbxAuthorTransactions.Size = new System.Drawing.Size(490, 336);
            this.gbxAuthorTransactions.TabIndex = 13;
            this.gbxAuthorTransactions.TabStop = false;
            this.gbxAuthorTransactions.Text = "Yazar İşlemleri";
            // 
            // rtxtPublisherAddress
            // 
            this.rtxtPublisherAddress.Location = new System.Drawing.Point(178, 171);
            this.rtxtPublisherAddress.Name = "rtxtPublisherAddress";
            this.rtxtPublisherAddress.Size = new System.Drawing.Size(275, 96);
            this.rtxtPublisherAddress.TabIndex = 8;
            this.rtxtPublisherAddress.Text = "";
            // 
            // btnUpdatePublisher
            // 
            this.btnUpdatePublisher.Location = new System.Drawing.Point(195, 278);
            this.btnUpdatePublisher.Name = "btnUpdatePublisher";
            this.btnUpdatePublisher.Size = new System.Drawing.Size(118, 38);
            this.btnUpdatePublisher.TabIndex = 7;
            this.btnUpdatePublisher.Text = "Güncelle";
            this.btnUpdatePublisher.UseVisualStyleBackColor = true;
            this.btnUpdatePublisher.Click += new System.EventHandler(this.btnUpdatePublisher_Click);
            // 
            // btnDeletePublisher
            // 
            this.btnDeletePublisher.Location = new System.Drawing.Point(335, 278);
            this.btnDeletePublisher.Name = "btnDeletePublisher";
            this.btnDeletePublisher.Size = new System.Drawing.Size(118, 38);
            this.btnDeletePublisher.TabIndex = 7;
            this.btnDeletePublisher.Text = "Sil";
            this.btnDeletePublisher.UseVisualStyleBackColor = true;
            this.btnDeletePublisher.Click += new System.EventHandler(this.btnDeletePublisher_Click);
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.Location = new System.Drawing.Point(41, 278);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(118, 38);
            this.btnAddPublisher.TabIndex = 7;
            this.btnAddPublisher.Text = "Ekle";
            this.btnAddPublisher.UseVisualStyleBackColor = true;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // txtPublisherPhoneNumber
            // 
            this.txtPublisherPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPublisherPhoneNumber.Location = new System.Drawing.Point(178, 82);
            this.txtPublisherPhoneNumber.Name = "txtPublisherPhoneNumber";
            this.txtPublisherPhoneNumber.Size = new System.Drawing.Size(275, 27);
            this.txtPublisherPhoneNumber.TabIndex = 4;
            // 
            // txtPublisherEmail
            // 
            this.txtPublisherEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPublisherEmail.Location = new System.Drawing.Point(178, 127);
            this.txtPublisherEmail.Name = "txtPublisherEmail";
            this.txtPublisherEmail.Size = new System.Drawing.Size(275, 27);
            this.txtPublisherEmail.TabIndex = 4;
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPublisherName.Location = new System.Drawing.Point(178, 40);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(275, 27);
            this.txtPublisherName.TabIndex = 4;
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
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yayınevi Adı :";
            // 
            // PublisherTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 803);
            this.Controls.Add(this.lvwPublisherList);
            this.Controls.Add(this.gbxAuthorTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PublisherTransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PublisherTransactionsForm";
            this.Load += new System.EventHandler(this.PublisherTransactionsForm_Load);
            this.gbxAuthorTransactions.ResumeLayout(false);
            this.gbxAuthorTransactions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwPublisherList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox gbxAuthorTransactions;
        private System.Windows.Forms.Button btnUpdatePublisher;
        private System.Windows.Forms.Button btnDeletePublisher;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtPublisherAddress;
        private System.Windows.Forms.TextBox txtPublisherPhoneNumber;
        private System.Windows.Forms.TextBox txtPublisherEmail;
    }
}