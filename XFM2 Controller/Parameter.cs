using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFM2_Controller
{
    public class Parameter
    {

        #region Constructor
        public Parameter(string name, int number, int minValue, int maxValue)
        {
            Name = name;
            Number = number;
            MinValue = minValue;
            MaxValue = maxValue;
        }
        #endregion


        public string Name { get; set; } = "New Parameter";
        public int Number { get; set; } = 0;
        public int MaxValue { get; set; } = 255;
        public int MinValue { get; set; } = 0;
        public int Value { get; set; } = 0;


    }
}
