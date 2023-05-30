using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPoject
{
    public class Currency
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal ExchangeRate { get; set; }
        public Currency()
        { }

        public Currency(string name, string code, decimal exchangeRate)
        {
            Name = name;
            Code = code;
            ExchangeRate = exchangeRate;
        }

        public static decimal ConvertToCurrency(decimal amount, Currency targetCurrency)
        {
            if (targetCurrency != null && targetCurrency != MainMenu.Instance.currency)
            {
                decimal convertedAmount = amount / MainMenu.Instance.currency.ExchangeRate * targetCurrency.ExchangeRate;
                return convertedAmount;
            }
            else
            {
                return amount;
            }
        }

    }
}
