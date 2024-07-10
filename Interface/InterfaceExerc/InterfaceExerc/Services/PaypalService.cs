using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExerc.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        private const double taxInterestPercentage = 0.01;
        private const double taxPaymentFeePercentage = 0.02;

        public double Interest(double amount, int months)
        {
            return taxInterestPercentage * months * amount;
            
            throw new NotImplementedException();
        }

        public double PaymentFee(double amount)
        {
            return amount * taxPaymentFeePercentage;

            throw new NotImplementedException();
        }
    }
}
