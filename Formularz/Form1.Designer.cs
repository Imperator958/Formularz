namespace Formularz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Forma = new System.Windows.Forms.Label();
            this.Wybór = new System.Windows.Forms.ComboBox();
            this.Zatwierdź = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Forma
            // 
            this.Forma.AllowDrop = true;
            this.Forma.AutoSize = true;
            this.Forma.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Forma.Location = new System.Drawing.Point(25, 84);
            this.Forma.Name = "Forma";
            this.Forma.Size = new System.Drawing.Size(387, 32);
            this.Forma.TabIndex = 0;
            this.Forma.Text = "Wybierz dokument do wypełnienia";
            this.Forma.Click += new System.EventHandler(this.Forma_Click);
            // 
            // Wybór
            // 
            this.Wybór.FormattingEnabled = true;
            this.Wybór.Location = new System.Drawing.Point(25, 143);
            this.Wybór.Name = "Wybór";
            this.Wybór.Size = new System.Drawing.Size(387, 23);
            this.Wybór.TabIndex = 1;
            // 
            // Zatwierdź
            // 
            this.Zatwierdź.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Zatwierdź.Location = new System.Drawing.Point(87, 198);
            this.Zatwierdź.Name = "Zatwierdź";
            this.Zatwierdź.Size = new System.Drawing.Size(266, 81);
            this.Zatwierdź.TabIndex = 2;
            this.Zatwierdź.Text = "ZATWIERDŹ";
            this.Zatwierdź.UseVisualStyleBackColor = true;
            this.Zatwierdź.Click += new System.EventHandler(this.Zatwierdź_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 412);
            this.Controls.Add(this.Zatwierdź);
            this.Controls.Add(this.Wybór);
            this.Controls.Add(this.Forma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Forma;
        private ComboBox Wybór;
        private Button Zatwierdź;
    }
}