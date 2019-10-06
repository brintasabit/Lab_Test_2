using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileHandsetHome.Model;
using MobileHandsetHome.Repository;

namespace MobileHandsetHome.Bill
{
    class MobileManager
    {
        MobileRepository _mobileRepository=new MobileRepository();
        public bool SaveMobiles(Mobile _mobile)
        {
            return _mobileRepository.SaveMobiles(_mobile);
        }

        public List<Mobile> SearchByPriceRange(Mobile _mobile)
        {
            return _mobileRepository.SearchByPriceRange(_mobile);
        }

        public List<Mobile> SearchByImei(Mobile _mobile)
        {
            return _mobileRepository.SearchByImei(_mobile);
        }
    }
}
