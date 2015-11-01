namespace Прога_для_работы_с_БД
{
    partial class Универсальная_форма
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
            this.Кн_ОК = new System.Windows.Forms.Button();
            this.Кн_Отмена = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Кн_ОК
            // 
            this.Кн_ОК.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Кн_ОК.Location = new System.Drawing.Point(696, 106);
            this.Кн_ОК.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Кн_ОК.Name = "Кн_ОК";
            this.Кн_ОК.Size = new System.Drawing.Size(150, 44);
            this.Кн_ОК.TabIndex = 11;
            this.Кн_ОК.Text = "Добавить";
            this.Кн_ОК.UseVisualStyleBackColor = true;
            // 
            // Кн_Отмена
            // 
            this.Кн_Отмена.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Кн_Отмена.Location = new System.Drawing.Point(480, 106);
            this.Кн_Отмена.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Кн_Отмена.Name = "Кн_Отмена";
            this.Кн_Отмена.Size = new System.Drawing.Size(150, 44);
            this.Кн_Отмена.TabIndex = 1;
            this.Кн_Отмена.Text = "Отмена";
            this.Кн_Отмена.UseVisualStyleBackColor = true;
            // 
            // Универсальная_форма
            // 
            this.AcceptButton = this.Кн_ОК;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.Кн_Отмена;
            this.ClientSize = new System.Drawing.Size(922, 215);
            this.Controls.Add(this.Кн_Отмена);
            this.Controls.Add(this.Кн_ОК);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Универсальная_форма";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Кн_ОК;
        private System.Windows.Forms.Button Кн_Отмена;
    }
}