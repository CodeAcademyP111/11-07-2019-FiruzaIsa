using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugList
{
   public class Drug
    {
        private static int _id;
        public int ID { get; set; }
        public string Type { get; set; }
        public string Name{ get; set; }
        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public Drug()
        {
            _id++;
            ID = _id;
            

        }
    }
}
