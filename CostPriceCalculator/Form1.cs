using CostPriceCalculator.Calculation;
using CostPriceCalculator.Exceptions;
using CostPriceCalculator.Orders;
using CostPriceCalculator.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostPriceCalculator
{
    public partial class Form1 : Form
    {
      private  InventoryService _inventoryService;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(CostingMethod));
            _inventoryService = new InventoryService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(errorProvider1.GetError(txt_shareSold))
                && string.IsNullOrEmpty(errorProvider1.GetError(txt_salePrice)) // text fields validations
                )
            {
                Order order = new Order();
                order.NoOfShares = Convert.ToInt32(txt_shareSold.Text);
                order.Price = Convert.ToDouble(txt_salePrice.Text);
                order.SellDate = txt_SaleDate.Value;
                CostingMethod costingMethod;
                Enum.TryParse<CostingMethod>(comboBox1.SelectedValue.ToString(), out costingMethod);

                try
                {
                    // Proess input
                    OrderInvoice orderInvoice = _inventoryService.Order(order, costingMethod);

                    lbl_costPriceRemShare.Text = orderInvoice.CostPriceRemShares.ToString();
                    lbl_costPriceShareSold.Text = orderInvoice.CostPriceOfSoldShares.ToString();
                    lbl_remShare.Text = orderInvoice.RemShares.ToString();
                    lbl_profitLoss.Text = orderInvoice.ProfitLoss.ToString();

                }
                catch (InventoryException ex)
                {
                    MessageBox.Show(ex.Message, "Inventory Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unhandled Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }
    }
}
