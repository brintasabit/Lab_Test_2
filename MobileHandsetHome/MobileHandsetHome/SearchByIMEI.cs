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
    public partial class SearchByIMEI : Form
    {
        MobileManager _mobileManager = new MobileManager();
        Mobile _mobile = new Mobile();
        public SearchByIMEI()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            _mobile.Imei = textBoxImei.Text;
            List<Mobile> mobiles = _mobileManager.SearchByImei(_mobile);
            if (mobiles.Count > 0)
            {
                labelModelName.Text = _mobile.ModelName;
                labelImei.Text = _mobile.Imei;
                labelPrice.Text = Convert.ToString(_mobile.Price);
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }
    }
}
