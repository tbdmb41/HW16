namespace FileFinder
{
    partial class Form1
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
            this.FileExtSearch = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Erasejb = new System.Windows.Forms.Button();
            this.ExtSearch = new System.Windows.Forms.TextBox();
            this.PathSearch = new System.Windows.Forms.TextBox();
            this.StringSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FileExtSearch
            // 
            this.FileExtSearch.AutoSize = true;
            this.FileExtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileExtSearch.Location = new System.Drawing.Point(12, 9);
            this.FileExtSearch.Name = "FileExtSearch";
            this.FileExtSearch.Size = new System.Drawing.Size(337, 26);
            this.FileExtSearch.TabIndex = 0;
            this.FileExtSearch.Text = "File Ext. Search (TXT, JSON, etc)";
            //this.FileExtSearch.Click += new System.EventHandler(this.FileExtSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Path to Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "String to Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(29, 432);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 49);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Erasejb
            // 
            this.Erasejb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Erasejb.Location = new System.Drawing.Point(141, 432);
            this.Erasejb.Name = "Erasejb";
            this.Erasejb.Size = new System.Drawing.Size(89, 49);
            this.Erasejb.TabIndex = 4;
            this.Erasejb.Text = "Clear";
            this.Erasejb.UseVisualStyleBackColor = true;
            //this.Erasejb.Click += new System.EventHandler(this.Erasejb_Click);
            // 
            // ExtSearch
            // 
            this.ExtSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ExtSearch.Location = new System.Drawing.Point(350, 9);
            this.ExtSearch.Multiline = true;
            this.ExtSearch.Name = "ExtSearch";
            this.ExtSearch.Size = new System.Drawing.Size(719, 26);
            this.ExtSearch.TabIndex = 5;
            this.ExtSearch.Text = "TXT";
            // 
            // PathSearch
            // 
            this.PathSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PathSearch.Location = new System.Drawing.Point(350, 100);
            this.PathSearch.Multiline = true;
            this.PathSearch.Name = "PathSearch";
            this.PathSearch.Size = new System.Drawing.Size(719, 26);
            this.PathSearch.TabIndex = 6;
            this.PathSearch.Text = "C:\\TestFiles";
            // 
            // StringSearch
            // 
            this.StringSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.StringSearch.Location = new System.Drawing.Point(350, 57);
            this.StringSearch.Multiline = true;
            this.StringSearch.Name = "StringSearch";
            this.StringSearch.Size = new System.Drawing.Size(719, 26);
            this.StringSearch.TabIndex = 7;
            this.StringSearch.Text = "hi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Results";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox4.Location = new System.Drawing.Point(358, 159);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(710, 250);
            this.textBox4.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 568);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StringSearch);
            this.Controls.Add(this.PathSearch);
            this.Controls.Add(this.ExtSearch);
            this.Controls.Add(this.Erasejb);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FileExtSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileExtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button Erasejb;
        private System.Windows.Forms.TextBox ExtSearch;
        private System.Windows.Forms.TextBox PathSearch;
        private System.Windows.Forms.TextBox StringSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
    }
}

