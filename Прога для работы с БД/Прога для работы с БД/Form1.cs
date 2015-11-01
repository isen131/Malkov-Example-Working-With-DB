using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Прога_для_работы_с_БД 
{
    public partial class Главная_форма : Form
    {
        public OleDbConnection Подключение_к_БД;// Представляет открытое подключение к источнику данных
        OleDbCommand Команда;//Оператор SQL применяемый к источнику данных
        string Выбранная_таблица;

        public Главная_форма()
        {
            InitializeComponent();
            Подключение_к_БД = new OleDbConnection();
            Команда = new OleDbCommand();
        }
              
        private void Файл_Открыть_Click(object sender, EventArgs e)
        {
            if (Диалог.ShowDialog() == DialogResult.OK)//Если диалог заканчивается ОК то:
            {
                try //Блок проверяемый на наличие ошибок
                {
                    Подключение_к_БД.Close();
                    Подключение_к_БД.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Диалог.FileName;
                    Подключение_к_БД.Open();
                    Формирование_списка_Меню_Таблицы();
                }
                catch (Exception Ошибка) // Если имела место ошибка то:
                {
                    Подключение_к_БД.Close();
                    MessageBox.Show("Ошибка:\n" + Ошибка.Message); // Генерируется и выводится на экран ошибка
                    return;
                }
            }
        }

        private void Файл_Выход_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Выход из приложения
        }

            private void Формирование_списка_Меню_Таблицы()
        {
            Меню_Таблицы.DropDownItems.Clear(); //Сначало очистка содержимого выпадающего окна--Таблицы
            DataTable имена_таблиц = Подключение_к_БД.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] {null, null, null, "TABLE" });
            foreach (DataRow содержимое in имена_таблиц.Rows) //выполняется опрос коллекции (имён таблиц)
            {
                Меню_Таблицы.DropDownItems.Add(содержимое[2] as string, null, new System.EventHandler(this.Таблиццы_Click));
            }
            Меню_Таблицы.Visible = true;  // как только список таблиц сформирован--пункт меню становится виден      
            Сетка.Columns.Clear();
        }
        private void Таблиццы_Click(object sender, EventArgs e)//Обработчик нажатия на "какую то строку" в выпадающем списке
        {
            Выбранная_таблица = (sender as ToolStripItem).Text;
            Загрузить_данные();
        }

        private void Загрузить_данные() // в сетку
        {
            Команда.Connection = Подключение_к_БД;
            Команда.CommandText = String.Format("SELECT * FROM `{0}`", Выбранная_таблица); // выбрать все данные в выбраной таблице
            
            Сетка.Columns.Clear();

            DataTable содержание = new DataTable();
            OleDbDataAdapter проводник = new OleDbDataAdapter(Команда);
            проводник.Fill(содержание);
            Сетка.DataSource = содержание; //копирование данных в сетку  

            Меню_Редактор.Visible = true;
        }










        private void Редактор_Добавить_Click(object sender, EventArgs e)
        {
            Универсальная_форма Ред_форма = new Универсальная_форма("Добавление записи", Сетка.Columns); 

            if (Ред_форма.ShowDialog() == System.Windows.Forms.DialogResult.OK)  //Если диалог заканчивается ОК то:

            {   //Создаются два динамически изменяемых массива "Поле" и "Значение" содержащих значения типа string : 
                List<string> Поле = new List<string>();
                List<string> Значение = new List<string>();

                for (int i = 0; i < Сетка.ColumnCount; i++)
                {
                    Поле.Add(string.Format("`{0}`",Сетка.Columns[i].Name)); //Заполнение массива "Поле"названиями полей текущей таблицы
                    Значение.Add(Преобразование_текста(Ред_форма.ед_данных[i].Text, Сетка.Columns[i].ValueType));// Заполнение массива Значения
                }
                string Запрос_на_добавление = String.Format("INSERT INTO `{0}` ({1}) VALUES ({2})", Выбранная_таблица, String.Join(", ", Поле.ToArray()), String.Join(", ", Значение.ToArray()));

                Команда.CommandText = Запрос_на_добавление;
                Команда.Connection = Подключение_к_БД;

                Команда.ExecuteNonQuery();
                int Строка = Сетка.SelectedRows[0].Index;
                Загрузить_данные();
                Сетка.ClearSelection();
            }
            Ред_форма.Dispose();
        }

        private void Редактор_Редактировать_Click(object sender, EventArgs e)
        {
          
            Универсальная_форма Ред_форма = new Универсальная_форма("Редактирование записи", Сетка.Columns, Сетка.SelectedRows[0]);
            if (Ред_форма.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //процедура редактирования записей
                List<string> set = new List<string>();
                List<string> where = new List<string>();

                for (int i = 0; i < Сетка.ColumnCount; i++)
                {
                    if (Сетка.SelectedRows[0].Cells[i].Value.ToString() != Ред_форма.ед_данных[i].Text)
                    {
                        set.Add(String.Format("`{0}` = {1}", Сетка.Columns[i].Name, Преобразование_текста(Ред_форма.ед_данных[i].Text, Сетка.Columns[i].ValueType)));
                    }
                    where.Add(Преобразование_текста(Сетка.Columns[i].Name, Сетка.SelectedRows[0].Cells[i].Value, Сетка.Columns[i].ValueType));
                }

                string Запрос = String.Format("UPDATE `{0}` SET {1} WHERE {2}", Выбранная_таблица, String.Join(", ", set.ToArray()), String.Join(" AND ", where.ToArray()));
                if (set.Count > 0)
                {
                    Команда.CommandText = Запрос;
                    Команда.Connection = Подключение_к_БД;

                    Команда.ExecuteNonQuery();
                    int Строка = Сетка.SelectedRows[0].Index;
                    Загрузить_данные();
                    Сетка.ClearSelection();
                    Сетка.Rows[Строка].Selected = true;
                }
            }
            Ред_форма.Dispose();
        }

        private string Преобразование_текста(string значение, Type тип)
        {
            if (значение.Trim().Length == 0) //если длина слова=0
            {
                return "NULL";
            }
            if (тип == typeof(DateTime))//если тип значения: дата-время суток
            {
                return string.Format("Format('{0}','DD.MM.YYYY')", значение);// то возврат значения по образцу: день.месяц.год
            }
            if ((тип == typeof(int)) || (тип == typeof(Decimal)))// если значение int или decimal
            {
                return string.Format("{0}", значение);
            }
            if (тип == typeof(string))// если значение string
            {
                return string.Format("'{0}'", значение);
            }
            return Искл_ситуация(тип);
        }

        private string Искл_ситуация(Type тип)
        {
            MessageBox.Show(String.Format("Неизвестный формат данных: {0}", тип.Name));
            return "";
        }

        private string Преобразование_текста(string имя, object значение, Type тип)
        {
            if (значение.GetType() == typeof(DBNull))
            {
                return string.Format("`{0}` is NULL", имя);
            }
            return String.Format("`{0}` = {1}", имя, Преобразование_текста(String.Format("{0}", значение), тип));
        }
        
        private void Редактор_Удалить_Click(object sender, EventArgs e)
        {
            string окончание = "ей";
            if (Сетка.SelectedRows.Count % 10 == 1)//для чисел с окончанием на 1: 11 21 31...
            {
                окончание = "ь";
            }
            if ((Сетка.SelectedRows.Count % 10 >= 2 && Сетка.SelectedRows.Count % 10 <= 4))//для чисел с окончанием на (от 2 до 4): 12 22 32...13 23 33...14 24 34...
            {
                окончание = "и";
            }
            if ((Сетка.SelectedRows.Count >= 5) && (Сетка.SelectedRows.Count <= 20))
            {
                окончание = "ей";
            }
            if (MessageBox.Show(String.Format("Вы уверены что хотите удалить {0} запис{1}?", Сетка.SelectedRows.Count, окончание), "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                //процедура удаления записей
                List<string> where = new List<string>();

                for (int i = 0; i < Сетка.ColumnCount; i++)
                {
                    where.Add(Преобразование_текста(Сетка.Columns[i].Name, Сетка.SelectedRows[0].Cells[i].Value, Сетка.Columns[i].ValueType));
                }

                string запрос = String.Format("DELETE FROM `{0}` WHERE {1}", Выбранная_таблица, String.Join(" AND ", where.ToArray()));

                Команда.CommandText = запрос;
                Команда.Connection = Подключение_к_БД;

                Команда.ExecuteNonQuery();
                Загрузить_данные();
                Сетка.ClearSelection();
            }
        }

        private void Меню_Редактор_DropDownOpening(object sender, EventArgs e)
        {
            Редактор_Редактировать.Enabled = (Сетка.SelectedRows.Count == 1);
            Редактор_Удалить.Enabled = (Сетка.SelectedRows.Count >= 1);
        }
    }
}