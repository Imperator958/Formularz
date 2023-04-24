namespace Formularz
{
    partial class Form2
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
            this.ZAPISZ = new System.Windows.Forms.Button();
            this.WCZYTAJ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ZAPISZ
            // 
            this.ZAPISZ.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ZAPISZ.Location = new System.Drawing.Point(67, 533);
            this.ZAPISZ.Name = "ZAPISZ";
            this.ZAPISZ.Size = new System.Drawing.Size(144, 72);
            this.ZAPISZ.TabIndex = 0;
            this.ZAPISZ.Text = "ZAPISZ";
            this.ZAPISZ.UseVisualStyleBackColor = true;
            // 
            // WCZYTAJ
            // 
            this.WCZYTAJ.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WCZYTAJ.Location = new System.Drawing.Point(296, 533);
            this.WCZYTAJ.Name = "WCZYTAJ";
            this.WCZYTAJ.Size = new System.Drawing.Size(144, 72);
            this.WCZYTAJ.TabIndex = 1;
            this.WCZYTAJ.Text = "WCZYTAJ";
            this.WCZYTAJ.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 641);
            this.Controls.Add(this.WCZYTAJ);
            this.Controls.Add(this.ZAPISZ);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button ZAPISZ;
        private Button WCZYTAJ;
    }
}