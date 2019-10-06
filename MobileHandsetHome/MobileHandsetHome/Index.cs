using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileHandsetHome
{
    public partial class Index : Form
    {
        Save save=new Save();
        SearchByPriceRange searchByPriceRange=new SearchByPriceRange();
        SearchByIMEI searchByImei=new SearchByIMEI();
        public Index()
        {
            InitializeComponent();
        }

        private void SaveMobileButton_Click(object sender, EventArgs e)
        {
            if (save.IsDisposed)
            {
                save=new Save();
            }
            save.Show();
            save.BringToFront();
        }

        private void SearchPriceButton_Click(object sender, EventArgs e)
        {
            if (searchByPriceRange.IsDisposed)
            {
                searchByPriceRange=new SearchByPriceRange();
            }
            searchByPriceRange.Show();
            searchByPriceRange.BringToFront();
        }

        private void SearchImeiButton_Click(object sender, EventArgs e)
        {
            if (searchByImei.IsDisposed)
            {
                searchByImei=new SearchByIMEI();
            }
            searchByImei.Show();
            searchByImei.BringToFront();
        }
    }
}
