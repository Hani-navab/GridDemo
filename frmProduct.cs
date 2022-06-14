using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GridDemo
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            dbgProduct.DataSource = DataAccess.Product.GetAllProducts().Tables[0];
        }

        private void dbgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
                if (Business.Product.DeleteProduct(dbgProduct[1, e.RowIndex].Value))
                    ((DataTable)dbgProduct.DataSource).Rows.Find(dbgProduct[1, e.RowIndex].Value).Delete();
            }
        }
    }
}
