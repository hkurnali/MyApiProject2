using HotelProject.EntityLayer.Concrate;
using HotelProjeDataAccesLayer.Abstract;
using HotelProjeDataAccesLayer.Concrate;
using HotelProjeDataAccesLayer.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjeDataAccesLayer.EntityFrameWork
{
    public class EfServiceDal:GenericRepostory<Service>,IServiceDal
    {
        public EfServiceDal(Context context):base(context) 
        {
               
        }
    }
}
