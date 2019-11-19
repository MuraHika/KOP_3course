namespace Lab1ComponentDasha
{
    partial class ChastotaDiapComponent
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(3, 3);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(59, 20);
            this.textBoxYear.TabIndex = 4;
            this.textBoxYear.TextChanged += new System.EventHandler(this.buttonGo_Click);
            // 
            // ChastotaDiapComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxYear);
            this.Name = "ChastotaDiapComponent";
            this.Size = new System.Drawing.Size(70, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxYear;
    }
}
