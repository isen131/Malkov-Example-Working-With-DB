namespace Прога_для_работы_с_БД
{
    partial class Главная_форма
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.Сетка = new System.Windows.Forms.DataGridView();
			this.Меню = new System.Windows.Forms.MenuStrip();
			this.Меню_Файл = new System.Windows.Forms.ToolStripMenuItem();
			this.Файл_Открыть = new System.Windows.Forms.ToolStripMenuItem();
			this.Файл_Выход = new System.Windows.Forms.ToolStripMenuItem();
			this.Меню_Таблицы = new System.Windows.Forms.ToolStripMenuItem();
			this.Меню_Редактор = new System.Windows.Forms.ToolStripMenuItem();
			this.Редактор_Редактировать = new System.Windows.Forms.ToolStripMenuItem();
			this.Редактор_Добавить = new System.Windows.Forms.ToolStripMenuItem();
			this.Редактор_Удалить = new System.Windows.Forms.ToolStripMenuItem();
			this.Диалог = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.Сетка)).BeginInit();
			this.Меню.SuspendLayout();
			this.SuspendLayout();
			// 
			// Сетка
			// 
			this.Сетка.AllowUserToAddRows = false;
			this.Сетка.AllowUserToDeleteRows = false;
			this.Сетка.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.Сетка.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Сетка.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Сетка.Location = new System.Drawing.Point(0, 24);
			this.Сетка.Name = "Сетка";
			this.Сетка.ReadOnly = true;
			this.Сетка.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.Сетка.ShowEditingIcon = false;
			this.Сетка.Size = new System.Drawing.Size(666, 277);
			this.Сетка.TabIndex = 2;
			this.Сетка.DoubleClick += new System.EventHandler(this.Редактор_Редактировать_Click);
			// 
			// Меню
			// 
			this.Меню.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Меню_Файл,
            this.Меню_Таблицы,
            this.Меню_Редактор});
			this.Меню.Location = new System.Drawing.Point(0, 0);
			this.Меню.Name = "Меню";
			this.Меню.Size = new System.Drawing.Size(666, 24);
			this.Меню.TabIndex = 1;
			this.Меню.Text = "menuStrip1";
			// 
			// Меню_Файл
			// 
			this.Меню_Файл.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Файл_Открыть,
            this.Файл_Выход});
			this.Меню_Файл.Name = "Меню_Файл";
			this.Меню_Файл.Size = new System.Drawing.Size(48, 20);
			this.Меню_Файл.Text = "Файл";
			// 
			// Файл_Открыть
			// 
			this.Файл_Открыть.Name = "Файл_Открыть";
			this.Файл_Открыть.Size = new System.Drawing.Size(152, 22);
			this.Файл_Открыть.Text = "Открыть";
			this.Файл_Открыть.Click += new System.EventHandler(this.Файл_Открыть_Click);
			// 
			// Файл_Выход
			// 
			this.Файл_Выход.Name = "Файл_Выход";
			this.Файл_Выход.Size = new System.Drawing.Size(152, 22);
			this.Файл_Выход.Text = "Выход";
			this.Файл_Выход.Click += new System.EventHandler(this.Файл_Выход_Click);
			// 
			// Меню_Таблицы
			// 
			this.Меню_Таблицы.Name = "Меню_Таблицы";
			this.Меню_Таблицы.Size = new System.Drawing.Size(69, 20);
			this.Меню_Таблицы.Text = "Таблицы";
			this.Меню_Таблицы.Visible = false;
			// 
			// Меню_Редактор
			// 
			this.Меню_Редактор.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Редактор_Редактировать,
            this.Редактор_Добавить,
            this.Редактор_Удалить});
			this.Меню_Редактор.Name = "Меню_Редактор";
			this.Меню_Редактор.Size = new System.Drawing.Size(69, 20);
			this.Меню_Редактор.Text = "Редактор";
			this.Меню_Редактор.Visible = false;
			this.Меню_Редактор.DropDownOpening += new System.EventHandler(this.Меню_Редактор_DropDownOpening);
			// 
			// Редактор_Редактировать
			// 
			this.Редактор_Редактировать.Name = "Редактор_Редактировать";
			this.Редактор_Редактировать.Size = new System.Drawing.Size(154, 22);
			this.Редактор_Редактировать.Text = "Редактировать";
			this.Редактор_Редактировать.Click += new System.EventHandler(this.Редактор_Редактировать_Click);
			// 
			// Редактор_Добавить
			// 
			this.Редактор_Добавить.Name = "Редактор_Добавить";
			this.Редактор_Добавить.Size = new System.Drawing.Size(154, 22);
			this.Редактор_Добавить.Text = "Добавить";
			this.Редактор_Добавить.Click += new System.EventHandler(this.Редактор_Добавить_Click);
			// 
			// Редактор_Удалить
			// 
			this.Редактор_Удалить.Name = "Редактор_Удалить";
			this.Редактор_Удалить.Size = new System.Drawing.Size(154, 22);
			this.Редактор_Удалить.Text = "Удалить";
			this.Редактор_Удалить.Click += new System.EventHandler(this.Редактор_Удалить_Click);
			// 
			// Диалог
			// 
			this.Диалог.FileName = "22.mdb";
			// 
			// Главная_форма
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(666, 301);
			this.Controls.Add(this.Сетка);
			this.Controls.Add(this.Меню);
			this.MainMenuStrip = this.Меню;
			this.Name = "Главная_форма";
			this.Text = "Редактор БД";
			((System.ComponentModel.ISupportInitialize)(this.Сетка)).EndInit();
			this.Меню.ResumeLayout(false);
			this.Меню.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Сетка;
        private System.Windows.Forms.MenuStrip Меню;
        private System.Windows.Forms.ToolStripMenuItem Меню_Файл;
        private System.Windows.Forms.ToolStripMenuItem Файл_Открыть;
        private System.Windows.Forms.ToolStripMenuItem Файл_Выход;
        private System.Windows.Forms.ToolStripMenuItem Меню_Таблицы;
        private System.Windows.Forms.ToolStripMenuItem Меню_Редактор;
        private System.Windows.Forms.ToolStripMenuItem Редактор_Редактировать;
        private System.Windows.Forms.ToolStripMenuItem Редактор_Добавить;
        private System.Windows.Forms.ToolStripMenuItem Редактор_Удалить;
        private System.Windows.Forms.OpenFileDialog Диалог;
    }
}

