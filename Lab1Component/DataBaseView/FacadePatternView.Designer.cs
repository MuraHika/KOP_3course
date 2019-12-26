namespace DataBaseView
{
    partial class FacadePatternView
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
            this.nameOrgListComponent = new Lab1Component.NameOrgListComponent();
            this.dateView = new Konponens.DateView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameOrgListComponent
            // 
            this.nameOrgListComponent.Location = new System.Drawing.Point(106, 27);
            this.nameOrgListComponent.Name = "nameOrgListComponent";
            this.nameOrgListComponent.SelectedIndexName = 0;
            this.nameOrgListComponent.Size = new System.Drawing.Size(261, 31);
            this.nameOrgListComponent.TabIndex = 0;
            // 
            // dateView
            // 
            this.dateView.Location = new System.Drawing.Point(106, 55);
            this.dateView.Name = "dateView";
            this.dateView.Size = new System.Drawing.Size(246, 108);
            this.dateView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тип организации:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата поставки:";
            // 
            // FacadePatternView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateView);
            this.Controls.Add(this.nameOrgListComponent);
            this.Name = "FacadePatternView";
            this.Size = new System.Drawing.Size(371, 174);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lab1Component.NameOrgListComponent nameOrgListComponent;
        private Konponens.DateView dateView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
