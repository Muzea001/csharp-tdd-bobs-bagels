using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public string bagel { get; set; }

        private int _maxCapacity = 5;

        public int maxCapacity
        {
            get { return _maxCapacity; }
            private set { _maxCapacity = value; }
        }

        public List<string> basket = new List<string>();

        public bool removeBagel(List<string> basket, string removedBasket)
        {
            
            if (!basket.Contains(removedBasket))
            {
                return false;
            }

            foreach (string b in basket)
            {

                if (b == removedBasket)
                {
                    basket.Remove(b);
                    return true;
                }
            }
            return false;
        }

        public void setMax(int max)
        {
            if (max > maxCapacity)
            {
                _maxCapacity = max;
            }





        }
    }
}

