namespace FormsTest
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonChange = new System.Windows.Forms.Button();
            this.nameOrgListComponent = new Lab1Component.NameOrgListComponent();
            this.saveBackupComponent = new Lab1Component.SaveBackupComponent(this.components);
            this.SuspendLayout();
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(86, 168);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(170, 39);
            this.buttonChange.TabIndex = 1;
            this.buttonChange.Text = "Сменить номер";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // nameOrgListComponent
            // 
            this.nameOrgListComponent.Location = new System.Drawing.Point(12, 12);
            this.nameOrgListComponent.Name = "nameOrgListComponent";
            this.nameOrgListComponent.SelectedIndexName = 0;
            this.nameOrgListComponent.Size = new System.Drawing.Size(322, 150);
            this.nameOrgListComponent.TabIndex = 2;
            this.nameOrgListComponent.ComboBoxSelectedElementChange += new System.EventHandler(this.controlComboBoxSelected_ComboBoxSelectedElementChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 224);
            this.Controls.Add(this.nameOrgListComponent);
            this.Controls.Add(this.buttonChange);
            this.Name = "Form1";
            this.Text = "Тестовая форма";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonChange;
        private Lab1Component.NameOrgListComponent nameOrgListComponent;
        private Lab1Component.SaveBackupComponent saveBackupComponent;
    }
}

