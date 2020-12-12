using System;
using System.Collections.Generic;
using Task.Interfaces;

namespace Task.Util
{
    public class MathImpl : IMath<double>
    {

        /**
        * 
        * <param name="list"> Set list with data rows</param>
        * <param name="digits"> Set amount of numbers after dot</param>
        */
        public double GetDispersion(List<double> list, int digits)
        {
            double average = 0;
            foreach (double iteam in list)
            {
                average = average += iteam;

            }

            average = Math.Round((average / list.Count), digits);

            double dispersion = 0;
            foreach (double iteam in list)
            {
                dispersion = dispersion + Math.Pow((iteam - average), 2);

            }

            dispersion = Math.Round(dispersion / list.Count, digits);
            return dispersion;
        }

        /**
        * <param name="list"> Set list with data rows</param>
        * <param name="digits"> Set amount of numbers after dot</param>
        */
        public double GetMediana(List<double> list, int digits)
        {
            list.Sort();
            if (list.Count % 2 == 1)
            {

                return list[list.Count / 2];
            }
            else
            {

                return Math.Round((list[list.Count / 2] + list[(list.Count / 2) - 1]) / 2, digits);
            }


        }

        /**
         * <param name="list"> Set list with data rows</param>
         * <param name="digits"> Set amount of numbers after dot</param>
         */
        public List<double> GetModa(List<double> list, int digits)
        {
            int MaxCount = 0;
            List<double> moda = new List<double>();
            Dictionary<double, int> map = new Dictionary<double, int>();
            foreach (double i in list)
            {
                if (!map.ContainsKey(i))
                {
                    map.Add(i, 1);
                }
                else
                {
                    map[i]++;
                    MaxCount = map[i];
                }
            }

            foreach (double iteam in map.Keys)
            {
                if (MaxCount == map[iteam])
                {

                    moda.Add(iteam);
                }
            }

            return moda;
        }


        /**
        * <param name="list"> Set list with data rows</param>
        * <param name="digits"> Set amount of numbers after dot</param>
        */
        public double GetMSD(List<double> list, int digits)
        {

            return Math.Round(Math.Sqrt(GetDispersion(list, digits)), digits);
        }
    }
}
