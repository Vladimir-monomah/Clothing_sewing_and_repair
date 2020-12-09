using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSetTableAdapters;
using static Пошив_и_ремонт_одежды.пошив_и_ремонт_одеждыDataSet;

namespace Пошив_и_ремонт_одежды
{
    public partial class Вход_в_программу : Form
    {
        const string FilterNonAdministrators = "([Является администратором] = FALSE)";
        private string textBoxOrdersFilter;
        private string readyOrNotReadyOrdersFilter;

        public Вход_в_программу()
        {
            InitializeComponent();
        }

        private void Вход_в_программу_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пошив_и_ремонт_одеждыDataSet.Тип_одежды". При необходимости она может быть перемещена или удалена.
            this.тип_одеждыTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Тип_одежды);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пошив_и_ремонт_одеждыDataSet.Вид_работ". При необходимости она может быть перемещена или удалена.
            this.вид_работTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Вид_работ);
            this.заказы_с_клиентамиTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Заказы_с_клиентами);

            this.пользователиBindingSource.Filter = FilterNonAdministrators;
            this.пользователиTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Пользователи);            
        }

        /// <summary>
        /// Фильтрация пользователей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var findFields = new[] { "[номер телефона]", "Фамилия", "Имя", "Отчество" };
            var filterString = EntityManager.GetFilterStringByFields(findFields, clientFilterTextBox.Text).Trim();

            this.пользователиBindingSource.Filter = FilterNonAdministrators;
            if (!string.IsNullOrEmpty(filterString))
            {
                this.пользователиBindingSource.Filter += $" AND ({filterString})";
            }
        }

        /// <summary>
        /// Добавление пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            (new ДобавлениеКлиента()).ShowDialog();
            this.пользователиTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Пользователи);
        }

        /// <summary>
        /// Фильтрует заказы по строке поиска, учитывая фильтрацию по готовности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var findFields = new[] { "ФИО", "[вид работы]", "[тип одежды]" };
            this.textBoxOrdersFilter =
                EntityManager.GetFilterStringByFields(findFields, orderFilterTextBox.Text).Trim();

            this.заказыСКлиентамиBindingSource.Filter =EntityManager.UnionFilter(
                this.textBoxOrdersFilter,
                this.readyOrNotReadyOrdersFilter);
        }

        /// <summary>
        /// Добавление заказов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addOrderButton_Click(object sender, EventArgs e)
        {
            (new Добавление_заказа()).ShowDialog();
            this.заказы_с_клиентамиTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Заказы_с_клиентами);
        }

        /// <summary>
        /// Обновляет информацию в бд об отредактированном заказе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewReadyOrders_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var changedRow = (Заказы_с_клиентамиRow)((DataRowView)((DataGridView)sender).CurrentRow.DataBoundItem).Row;
            var orderTable = EntityManager.FilterOrders($"Идентификатор = {changedRow.Номер_заказа}");

            orderTable[0].заказ_готов = changedRow.Заказ_готов;
            orderTable[0].Цена = changedRow.Цена;
            // TODO Сделать возможность редактирования вида работы и типа одежды
            // orderTable[0].Вид_работы = changedRow.Вид_работы;
            // orderTable[0].тип_одежды = changedRow.тип_одежды;
            EntityManager.UpdateOrders();
        }

        /// <summary>
        /// Обновляет информацию в бд об отредактированном клиенте
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewClient_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var changedRow = (ПользователиRow)((DataRowView)((DataGridView)sender).CurrentRow.DataBoundItem).Row;
            var userTable = EntityManager.FilterUsers($"Идентификатор = {changedRow.Идентификатор}");

            userTable[0].Идентификатор = changedRow.Идентификатор;
            userTable[0].Фамилия = changedRow.Фамилия;
            userTable[0].Имя = changedRow.Имя;
            userTable[0].Отчество = changedRow.Отчество;
            userTable[0].номер_телефона = changedRow.номер_телефона;
            userTable[0]._E_mail = changedRow._E_mail;

            EntityManager.UpdateUsers();

            this.заказы_с_клиентамиTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Заказы_с_клиентами);
        }

        /// <summary>
        /// Переключает фильтрацию заказов по полю "Заказ готов": true, false, all
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readyOrdersFilterCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            switch (this.readyOrdersFilterCheckBox.CheckState)
            {
                case CheckState.Checked:
                    this.readyOrNotReadyOrdersFilter = "[Заказ готов] = TRUE";
                    this.readyOrdersFilterCheckBox.Text = "Отображаются готовые заказы";
                    break;

                case CheckState.Indeterminate:
                    this.readyOrNotReadyOrdersFilter = string.Empty;
                    this.readyOrdersFilterCheckBox.Text = "Отображаются все заказы";
                    break;

                case CheckState.Unchecked:
                    this.readyOrNotReadyOrdersFilter = "[Заказ готов] = FALSE";
                    this.readyOrdersFilterCheckBox.Text = "Отображаются неготовые заказы";
                    break;
            }

            this.заказыСКлиентамиBindingSource.Filter = EntityManager.UnionFilter(
                this.textBoxOrdersFilter,
                this.readyOrNotReadyOrdersFilter);            
        }
    }
}