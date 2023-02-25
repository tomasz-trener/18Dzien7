namespace P02DynamiczneGenerowanieKontrolek
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
            this.btnGeneruj = new System.Windows.Forms.Button();
            this.cbRozmiar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlObszarGry = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnGeneruj
            // 
            this.btnGeneruj.Location = new System.Drawing.Point(97, 12);
            this.btnGeneruj.Name = "btnGeneruj";
            this.btnGeneruj.Size = new System.Drawing.Size(64, 37);
            this.btnGeneruj.TabIndex = 0;
            this.btnGeneruj.Text = "Generuj";
            this.btnGeneruj.UseVisualStyleBackColor = true;
            this.btnGeneruj.Click += new System.EventHandler(this.btnGeneruj_Click);
            // 
            // cbRozmiar
            // 
            this.cbRozmiar.FormattingEnabled = true;
            this.cbRozmiar.Location = new System.Drawing.Point(16, 28);
            this.cbRozmiar.Name = "cbRozmiar";
            this.cbRozmiar.Size = new System.Drawing.Size(75, 21);
            this.cbRozmiar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rozmiar";
            // 
            // pnlObszarGry
            // 
            this.pnlObszarGry.Location = new System.Drawing.Point(19, 69);
            this.pnlObszarGry.Name = "pnlObszarGry";
            this.pnlObszarGry.Size = new System.Drawing.Size(878, 603);
            this.pnlObszarGry.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 684);
            this.Controls.Add(this.pnlObszarGry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRozmiar);
            this.Controls.Add(this.btnGeneruj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneruj;
        private System.Windows.Forms.ComboBox cbRozmiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlObszarGry;
    }
}

