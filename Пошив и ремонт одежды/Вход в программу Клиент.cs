using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пошив_и_ремонт_одежды
{
    public partial class Вход_в_программу_Клиент : Form
    {
        private readonly string ordersFilter;

        private string textBoxOrdersFilter;
        private string readyOrNotReadyOrdersFilter;

        public Вход_в_программу_Клиент(Int64 userId)
        {
            this.ordersFilter = $"([Номер клиента] = {userId})";
            InitializeComponent();
        }

        private void Вход_в_программу_Клиент_Load(object sender, EventArgs e)
        {
            this.заказыДляКлиентаBindingSource.Filter = this.textBoxOrdersFilter = ordersFilter;
            this.заказы_для_клиентаTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Заказы_для_клиента);

            this.цены_работ_для_клиентаTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Цены_работ_для_клиента);            
        }

        private void orderFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var findFields = new[] { "[Вид работы]", "[Тип одежды]" };
            var filterString =
                EntityManager.GetFilterStringByFields(findFields, this.orderFilterTextBox.Text).Trim();

            this.textBoxOrdersFilter = ordersFilter;
            if (!string.IsNullOrEmpty(filterString))
            {
                this.textBoxOrdersFilter += $" AND ({filterString})";
            }

            this.заказыДляКлиентаBindingSource.Filter = EntityManager.UnionFilter(
                this.textBoxOrdersFilter,
                this.readyOrNotReadyOrdersFilter);
        }

        private void priceListFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var findFields = new[] { "[Вид работы]", "[Тип одежды]" };
            var filterString =
                EntityManager.GetFilterStringByFields(findFields, this.priceListFilterTextBox.Text).Trim();

            this.ценыРаботДляКлиентаBindingSource.Filter = filterString;
        }

        private void clientOrdersFilterCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            switch (this.clientOrdersFilterCheckBox.CheckState)
            {
                case CheckState.Checked:
                    this.readyOrNotReadyOrdersFilter = "[Заказ готов] = TRUE";
                    this.clientOrdersFilterCheckBox.Text = "Отображаются готовые заказы";
                    break;

                case CheckState.Indeterminate:
                    this.readyOrNotReadyOrdersFilter = string.Empty;
                    this.clientOrdersFilterCheckBox.Text = "Отображаются все заказы";
                    break;

                case CheckState.Unchecked:
                    this.readyOrNotReadyOrdersFilter = "[Заказ готов] = FALSE";
                    this.clientOrdersFilterCheckBox.Text = "Отображаются неготовые заказы";
                    break;
            }

            this.заказыДляКлиентаBindingSource.Filter = EntityManager.UnionFilter(
                this.textBoxOrdersFilter,
                this.readyOrNotReadyOrdersFilter);
        }

        private void updateOrdersButton_Click(object sender, EventArgs e)
        {
            this.заказы_для_клиентаTableAdapter.Fill(this.пошив_и_ремонт_одеждыDataSet.Заказы_для_клиента);
        }
    }
}
