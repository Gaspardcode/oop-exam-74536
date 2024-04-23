using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace question_4_74536
{
    class CarRegistration
    {
        private string _plate { get; set; }
        public string GetPlate()
        {
            return _plate;
        }
        public string CheckPlate(string plate)
        {
            string pattern = @"\d{2}[1-2][-]\d?\d[-]\d{1,6}";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(plate))
            {
                return plate;
            }
            else {
                return "N/A";
            }
        }
        public CarRegistration(string p) {
            _plate = CheckPlate(p);
        }
    }
}
