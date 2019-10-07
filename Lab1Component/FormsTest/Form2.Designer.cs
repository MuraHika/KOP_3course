namespace FormsTest
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
            this.chastotaDiapComponent = new Lab1ComponentDasha.ChastotaDiapComponent();
            this.SuspendLayout();
            // 
            // chastotaDiapComponent
            // 
            this.chastotaDiapComponent.Location = new System.Drawing.Point(12, 12);
            this.chastotaDiapComponent.Name = "chastotaDiapComponent";
            this.chastotaDiapComponent.Size = new System.Drawing.Size(295, 180);
            this.chastotaDiapComponent.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 214);
            this.Controls.Add(this.chastotaDiapComponent);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Lab1ComponentDasha.ChastotaDiapComponent chastotaDiapComponent;
    }
}