namespace Mara_Publication
{
    partial class Dashboard
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
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnViewBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddAuthor.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAddAuthor.FlatAppearance.BorderSize = 2;
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.ForeColor = System.Drawing.Color.Blue;
            this.btnAddAuthor.Location = new System.Drawing.Point(248, 114);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(109, 62);
            this.btnAddAuthor.TabIndex = 3;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnViewBook
            // 
            this.btnViewBook.BackColor = System.Drawing.SystemColors.Control;
            this.btnViewBook.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnViewBook.FlatAppearance.BorderSize = 2;
            this.btnViewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBook.ForeColor = System.Drawing.Color.Blue;
            this.btnViewBook.Location = new System.Drawing.Point(248, 192);
            this.btnViewBook.Name = "btnViewBook";
            this.btnViewBook.Size = new System.Drawing.Size(109, 62);
            this.btnViewBook.TabIndex = 4;
            this.btnViewBook.Text = "View Book";
            this.btnViewBook.UseVisualStyleBackColor = false;
            this.btnViewBook.Click += new System.EventHandler(this.btnViewBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddBook.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAddBook.FlatAppearance.BorderSize = 2;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.Blue;
            this.btnAddBook.Location = new System.Drawing.Point(248, 271);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(109, 62);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(128, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "MARA Publication Pvt LTD";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnViewBook);
            this.Controls.Add(this.btnAddAuthor);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnViewBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label1;
    }
}