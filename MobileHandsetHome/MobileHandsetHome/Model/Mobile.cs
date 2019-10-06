using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileHandsetHome.Model
{
    public class Mobile
    {
        public string ModelName { set; get; }
        public string Imei { set; get; }
        public int Price { set; get; }
        public int Id { set; get; }
        public int MinPrice { set; get; }
        public int MaxPrice { set; get; }
    }
}
