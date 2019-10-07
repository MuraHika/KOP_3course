namespace FormsTest
{
    partial class Form3
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
            this.vivodTableComponent = new Lab1ComponentKate.VivodTableComponent();
            this.SuspendLayout();
            // 
            // vivodTableComponent
            // 
            this.vivodTableComponent.Location = new System.Drawing.Point(12, 12);
            this.vivodTableComponent.Name = "vivodTableComponent";
            this.vivodTableComponent.Size = new System.Drawing.Size(388, 238);
            this.vivodTableComponent.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 317);
            this.Controls.Add(this.vivodTableComponent);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private Lab1ComponentKate.VivodTableComponent vivodTableComponent;
    }
}