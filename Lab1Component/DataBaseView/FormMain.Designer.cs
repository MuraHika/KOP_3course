namespace DataBaseView
{
    partial class FormMain
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSaveBackUp = new System.Windows.Forms.Button();
            this.wordReport = new Konponens.WordReport(this.components);
            this.buttonWordDiagr = new System.Windows.Forms.Button();
            this.buttonWordRept = new System.Windows.Forms.Button();
            this.wordDiagramMaker1 = new ControlLibrary.WordDiagramMaker(this.components);
            this.saveBackupComponent = new Lab1Component.SaveBackupComponent(this.components);
            this.button = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(384, 17);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(123, 37);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить поставщика";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(384, 69);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(123, 37);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Редактировать поставщика";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(384, 122);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(123, 37);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить  поставщика";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(384, 174);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(123, 37);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSaveBackUp
            // 
            this.buttonSaveBackUp.Location = new System.Drawing.Point(384, 283);
            this.buttonSaveBackUp.Name = "buttonSaveBackUp";
            this.buttonSaveBackUp.Size = new System.Drawing.Size(120, 36);
            this.buttonSaveBackUp.TabIndex = 5;
            this.buttonSaveBackUp.Text = "Сохранение даных в JSON файл";
            this.buttonSaveBackUp.UseVisualStyleBackColor = true;
            this.buttonSaveBackUp.Click += new System.EventHandler(this.buttonSaveBackUp_Click);
            // 
            // buttonWordDiagr
            // 
            this.buttonWordDiagr.Location = new System.Drawing.Point(291, 344);
            this.buttonWordDiagr.Name = "buttonWordDiagr";
            this.buttonWordDiagr.Size = new System.Drawing.Size(122, 36);
            this.buttonWordDiagr.TabIndex = 6;
            this.buttonWordDiagr.Text = "Диаграмма в Word";
            this.buttonWordDiagr.UseVisualStyleBackColor = true;
            this.buttonWordDiagr.Click += new System.EventHandler(this.buttonWordDiagr_Click);
            // 
            // buttonWordRept
            // 
            this.buttonWordRept.Location = new System.Drawing.Point(84, 344);
            this.buttonWordRept.Name = "buttonWordRept";
            this.buttonWordRept.Size = new System.Drawing.Size(122, 36);
            this.buttonWordRept.TabIndex = 7;
            this.buttonWordRept.Text = "Отчет в Word";
            this.buttonWordRept.UseVisualStyleBackColor = true;
            this.buttonWordRept.Click += new System.EventHandler(this.buttonWordRept_Click);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(185, 401);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(129, 30);
            this.button.TabIndex = 10;
            this.button.Text = "Выполнить плагин";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(9, 9);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(361, 310);
            this.treeView1.TabIndex = 11;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 453);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.buttonWordRept);
            this.Controls.Add(this.buttonWordDiagr);
            this.Controls.Add(this.buttonSaveBackUp);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormMain";
            this.Text = "Поставщик";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private Lab1Component.SaveBackupComponent saveBackupComponent;
        private System.Windows.Forms.Button buttonSaveBackUp;
        private Konponens.WordReport wordReport;
        private System.Windows.Forms.Button buttonWordDiagr;
        private System.Windows.Forms.Button buttonWordRept;
        private ControlLibrary.WordDiagramMaker wordDiagramMaker1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TreeView treeView1;
    }
}

