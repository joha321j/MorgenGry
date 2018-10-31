using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public class ValuableRepository
    {
        private List<IValuable> valuableList = new List<IValuable>();

        public void AddValuable(IValuable iValuable)
        {
            valuableList.Add(iValuable);
        }

        public IValuable GetValuable(string id)
        {
            foreach (var valuable in valuableList)
            {
                if (valuable is Course && string.Equals((valuable as Course).Name, id))
                {
                    return valuable;
                }
                else if (valuable is Merchandise && string.Equals((valuable as Merchandise).ItemId, id))
                {
                    return valuable;
                }
            }

            return null;
        }

        public double GetTotalValue()
        {
            double totalValue = 0.0;
            foreach (var valuable in valuableList)
            {
                totalValue += valuable.GetValue();
            }

            return totalValue;
        }

        public int Count()
        {
            return valuableList.Count();
        }
    }
}
