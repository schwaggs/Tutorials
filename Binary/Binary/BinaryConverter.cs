using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    public class BinaryConverter
    {
        private int _Dec { get; set; }

        public BinaryConverter(int dec)
        {
            _Dec = dec;
        }

        /// <summary>
        /// This uses the string conversion which has a parameter to convert form one base to another and return a string of the result
        /// </summary>
        /// <returns></returns>
        public string UseString()
        {
            return Convert.ToString(_Dec, 2);
        }
    }
}
