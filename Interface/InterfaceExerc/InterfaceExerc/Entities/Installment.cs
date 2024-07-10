using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExerc.Entities
{
    internal class Installment 
    {
        public DateTime DueData { get; set; }
        public Double Amount { get; set; }

        public Installment(DateTime dueData, double amount)
        {
            DueData = dueData;
            Amount = amount;
        }

        public override string ToString()
        {
            return  DueData.ToString("dd/MM/yy") + " - " +
                    Amount.ToString("F2", CultureInfo.InvariantCulture); ;
        }
    }
}
