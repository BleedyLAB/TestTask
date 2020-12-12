using System.Collections.Generic;
using Task.Interfaces;

namespace Task.Util
{
    public class DataImpl : IData
    {

        private List<double> list;
        private int digits = 2;

        public DataImpl(List<double> List, int Digits)
        {
            this.list = List;
            this.digits = Digits;

        }

        public int GetDigits()
        {
            if (digits == 0) {
                return 2;
            }
            return digits;
        }

        public List<double> GetList()
        {
            return list;
        }

    }
}
