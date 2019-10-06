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
using MobileHandsetHome.Repository;

namespace MobileHandsetHome
{
    public partial class Save : Form
    {
        MobileManager _mobileManager=new MobileManager();
        Mobile _mobile=new Mobile();
        public Save()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            


                try
                {
                    _mobile.ModelName = textBoxModelName.Text;
                    _mobile.Imei = textBoxImei.Text;
                    _mobile.Price = Convert.ToInt32(textBoxPrice.Text);
                   
                    
                    bool isSaved = _mobileManager.SaveMobiles(_mobile);
                    if (isSaved)
                    {
                        MessageBox.Show("Saved");
                    }
                    else
                    {
                        MessageBox.Show("Not Saved");
                    }
            }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }


        }
    }
}
