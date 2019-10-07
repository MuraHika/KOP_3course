namespace Lab1Component
{
    partial class SaveBackupComponent
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
            this.buttonSaveBackup = new System.Windows.Forms.Button();
            // 
            // buttonSaveBackup
            // 
            this.buttonSaveBackup.Location = new System.Drawing.Point(0, 0);
            this.buttonSaveBackup.Name = "buttonSaveBackup";
            this.buttonSaveBackup.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveBackup.TabIndex = 0;
            this.buttonSaveBackup.Text = "Сохранить данные в формате json";
            this.buttonSaveBackup.UseVisualStyleBackColor = true;
            this.buttonSaveBackup.Click += new System.EventHandler(this.buttonSaveBackup_Click);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveBackup;
    }
}
