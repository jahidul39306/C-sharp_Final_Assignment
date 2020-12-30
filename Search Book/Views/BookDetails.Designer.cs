
namespace Search_Book.Views
{
    partial class BookDetails
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelEdition = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.textBoxEdition = new System.Windows.Forms.TextBox();
            this.textBoxBookId = new System.Windows.Forms.TextBox();
            this.textBoxAuthorName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(105, 59);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(136, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Book Name:";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(143, 246);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(98, 25);
            this.labelId.TabIndex = 5;
            this.labelId.Text = "Book Id:";
            // 
            // labelEdition
            // 
            this.labelEdition.AutoSize = true;
            this.labelEdition.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdition.Location = new System.Drawing.Point(150, 187);
            this.labelEdition.Name = "labelEdition";
            this.labelEdition.Size = new System.Drawing.Size(91, 25);
            this.labelEdition.TabIndex = 6;
            this.labelEdition.Text = "Edition:";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.Location = new System.Drawing.Point(86, 124);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(155, 25);
            this.labelAuthor.TabIndex = 7;
            this.labelAuthor.Text = "Author Name:";
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookName.Location = new System.Drawing.Point(247, 59);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.ReadOnly = true;
            this.textBoxBookName.Size = new System.Drawing.Size(242, 29);
            this.textBoxBookName.TabIndex = 8;
            this.textBoxBookName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxEdition
            // 
            this.textBoxEdition.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEdition.Location = new System.Drawing.Point(247, 183);
            this.textBoxEdition.Name = "textBoxEdition";
            this.textBoxEdition.ReadOnly = true;
            this.textBoxEdition.Size = new System.Drawing.Size(242, 29);
            this.textBoxEdition.TabIndex = 9;
            // 
            // textBoxBookId
            // 
            this.textBoxBookId.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookId.Location = new System.Drawing.Point(247, 246);
            this.textBoxBookId.Name = "textBoxBookId";
            this.textBoxBookId.ReadOnly = true;
            this.textBoxBookId.Size = new System.Drawing.Size(242, 29);
            this.textBoxBookId.TabIndex = 10;
            this.textBoxBookId.TextChanged += new System.EventHandler(this.textBoxBookId_TextChanged);
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthorName.Location = new System.Drawing.Point(247, 124);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.ReadOnly = true;
            this.textBoxAuthorName.Size = new System.Drawing.Size(242, 29);
            this.textBoxAuthorName.TabIndex = 11;
            // 
            // BookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAuthorName);
            this.Controls.Add(this.textBoxBookId);
            this.Controls.Add(this.textBoxEdition);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelEdition);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelName);
            this.Name = "BookDetails";
            this.Text = "BookDetails";
            this.Load += new System.EventHandler(this.BookDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelEdition;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.TextBox textBoxEdition;
        private System.Windows.Forms.TextBox textBoxBookId;
        private System.Windows.Forms.TextBox textBoxAuthorName;
    }
}