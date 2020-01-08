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
            this.components = new System.ComponentModel.Container();
            this.vivodTableComponent = new Lab1ComponentKate.VivodTableComponent();
            this.buttonCreateD = new System.Windows.Forms.Button();
            this.diagrammaExcelComponent = new Lab1ComponentKate.DiagrammaExcelComponent(this.components);
            this.SuspendLayout();
            // 
            // vivodTableComponent
            // 
            this.vivodTableComponent.Location = new System.Drawing.Point(12, 12);
            this.vivodTableComponent.Name = "vivodTableComponent";
            this.vivodTableComponent.Size = new System.Drawing.Size(445, 238);
            this.vivodTableComponent.TabIndex = 0;
            // 
            // buttonCreateD
            // 
            this.buttonCreateD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateD.Location = new System.Drawing.Point(112, 273);
            this.buttonCreateD.Name = "buttonCreateD";
            this.buttonCreateD.Size = new System.Drawing.Size(176, 30);
            this.buttonCreateD.TabIndex = 1;
            this.buttonCreateD.Text = "Создать гистограмму";
            this.buttonCreateD.UseVisualStyleBackColor = true;
            this.buttonCreateD.Click += new System.EventHandler(this.buttonCreateD_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 317);
            this.Controls.Add(this.buttonCreateD);
            this.Controls.Add(this.vivodTableComponent);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private Lab1ComponentKate.VivodTableComponent vivodTableComponent;
        private System.Windows.Forms.Button buttonCreateD;
        private Lab1ComponentKate.DiagrammaExcelComponent diagrammaExcelComponent;
    }
}