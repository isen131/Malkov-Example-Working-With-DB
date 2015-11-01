using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Прога_для_работы_с_БД
{
    public partial class Универсальная_форма : Form  //Одна форма для окна редактирования и добавления записи
    {
        private DataGridViewRow Редактирование_строк;
        public List<TextBox> ед_данных; // создание дин. измен. массива типа string: ед_данных

        public Универсальная_форма (string Окно_имя, DataGridViewColumnCollection Коллекция, DataGridViewRow Строка = null)
        {
            InitializeComponent();

            this.Text = Окно_имя; 

            Редактирование_строк = Строка;
            ед_данных = new List<TextBox>();
            for (int i = 0; i < Коллекция.Count; i++)
            {
                Label Имя_поля = new Label();  //заполнение и размещение списка названий полей
                Имя_поля.Text = Коллекция[i].Name;
                Имя_поля.Location = new Point(10, 9 + i * 26);//(гориз,верт)
                Controls.Add(Имя_поля); //добавление на форму

                TextBox Значение = new TextBox(); //(редактирование/ввод новых) и размещение изменяемых значений строк
                ед_данных.Add(Значение);
                Значение.Location = new Point(110, 6 + i * 26);//(гориз,верт)
                Значение.Size = new Size(250, Значение.Size.Height);
                Controls.Add(Значение); //добавление на форму

            }
            //размещаем кнопки
            Кн_ОК.Location = new Point(Кн_ОК.Location.X, Коллекция.Count * 26 + 10);//(гориз,верт)
            Кн_Отмена.Location = new Point(Кн_Отмена.Location.X, Коллекция.Count * 26 + 10);//(гориз,верт)

            if (Строка != null)// Если строка DataGrid не пуста (режим редактирования записи):
            {
                for (int i = 0; i < Строка.Cells.Count; i++)// Заполняем TextBox-ы значениями 
                {
                    ед_данных[i].Text = Строка.Cells[i].Value.ToString();
                }

                Кн_ОК.Text = "Сохранить"; // И т.к. это режим Редактирования меняем название кнопки  
            }
        }
    }
}
        




