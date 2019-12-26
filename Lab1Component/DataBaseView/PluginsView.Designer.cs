namespace DataBaseView
{
    partial class PluginsView
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
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTypeOrg = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonChangeType = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.buttonAdmission = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Location = new System.Drawing.Point(71, 54);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(201, 21);
            this.comboBoxOperation.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Выберите операцию:";
            // 
            // comboBoxTypeOrg
            // 
            this.comboBoxTypeOrg.FormattingEnabled = true;
            this.comboBoxTypeOrg.Location = new System.Drawing.Point(19, 133);
            this.comboBoxTypeOrg.Name = "comboBoxTypeOrg";
            this.comboBoxTypeOrg.Size = new System.Drawing.Size(176, 21);
            this.comboBoxTypeOrg.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Выберите название организации:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Выберите тип организации на который хотите заменить:";
            // 
            // buttonChangeType
            // 
            this.buttonChangeType.Location = new System.Drawing.Point(93, 169);
            this.buttonChangeType.Name = "buttonChangeType";
            this.buttonChangeType.Size = new System.Drawing.Size(157, 27);
            this.buttonChangeType.TabIndex = 16;
            this.buttonChangeType.Text = "ЗАМЕНА";
            this.buttonChangeType.UseVisualStyleBackColor = true;
            this.buttonChangeType.Click += new System.EventHandler(this.buttonChangeType_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(340, 39);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(329, 387);
            this.treeView1.TabIndex = 17;
            // 
            // buttonAdmission
            // 
            this.buttonAdmission.Location = new System.Drawing.Point(22, 232);
            this.buttonAdmission.Name = "buttonAdmission";
            this.buttonAdmission.Size = new System.Drawing.Size(290, 26);
            this.buttonAdmission.TabIndex = 18;
            this.buttonAdmission.Text = "Вывести список последних поставок";
            this.buttonAdmission.UseVisualStyleBackColor = true;
            this.buttonAdmission.Click += new System.EventHandler(this.buttonAdmission_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(683, 40);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(262, 381);
            this.listBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(726, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Список последних поставок:";
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(103, 295);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(146, 35);
            this.buttonReport.TabIndex = 21;
            this.buttonReport.Text = "Сформировать отчет";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // PluginsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 437);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonAdmission);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.buttonChangeType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTypeOrg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxOperation);
            this.Name = "PluginsView";
            this.Text = "Плагины";
            this.Load += new System.EventHandler(this.PluginsView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOperation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTypeOrg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonChangeType;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonAdmission;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonReport;
    }
}