namespace Lab1ComponentKate
{
    partial class DiagrammaExcelComponent
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
            this.buttonCreateDiagramma = new System.Windows.Forms.Button();
            // 
            // buttonCreateDiagramma
            // 
            this.buttonCreateDiagramma.Location = new System.Drawing.Point(0, 0);
            this.buttonCreateDiagramma.Name = "buttonCreateDiagramma";
            this.buttonCreateDiagramma.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateDiagramma.TabIndex = 0;
            this.buttonCreateDiagramma.Text = "button1";
            this.buttonCreateDiagramma.UseVisualStyleBackColor = true;

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateDiagramma;
    }
}
