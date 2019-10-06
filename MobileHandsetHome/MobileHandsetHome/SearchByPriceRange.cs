using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileHandsetHome.Bill;
using MobileHandsetHome.Model;

namespace MobileHandsetHome
{
    public partial class SearchByPriceRange : Form
    {
        MobileManager _mobileManager = new MobileManager();
        Mobile _mobile = new Mobile();
        public SearchByPriceRange()
        {
            InitializeComponent();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewMobiles.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            _mobile.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
            _mobile.MaxPrice = Convert.ToInt32(textBoxMaximunPrice.Text);

            List<Mobile>mobiles=new List<Mobile>();
           // int isSearch = _mobileManager.SearchByPriceRange(_mobile);
            if (mobiles.Count>0)
            {
                // dataGridViewMobiles.DataSource = Convert.ToBoolean(_mobileManager.SearchByPriceRange(_mobile));
                MessageBox.Show("Data Found!");
                dataGridViewMobiles.DataSource = _mobileManager.SearchByPriceRange(_mobile);
               
            }
            else
            {
                MessageBox.Show("Not Exist");
            }
        }
    }
}
