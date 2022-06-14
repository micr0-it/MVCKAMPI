﻿using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingdal)
        {
            _headingDal = headingdal;
        }

        public Heading GetByID(int id)
        {
            return _headingDal.Get(x=> x.HeadingID==id);
        }

        public List<Heading> GetHeadingList()
        {
            return _headingDal.List();
        }

        public void HeadingAddBL(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public void HeadingDelete(Heading heading)
        {
            _headingDal.Delete(heading);
        }

        public void HeadingUpdate(Heading heading)
        {
            _headingDal.Update(heading);
        }
    }
}
