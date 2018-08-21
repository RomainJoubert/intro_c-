using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    //public class FakeDateTime : IDateTime
    //{
    //    public DateTime Date
    //    {
    //        get
    //        {
    //            return new DateTime(2018, 08, 25, 20, 00, 00);
    //        }
    //    }
    //}

    public class FakeDateTime : IDateTime
    {
        DateTime _dateToReturn;
        public FakeDateTime(DateTime dateToReturn)
        {
            _dateToReturn = dateToReturn;
        }
        public DateTime Date
        {
            get
            {
                return _dateToReturn;
            }
        }
    }
}
