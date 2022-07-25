using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_004
{
    internal class Product : IFormattable
    {
        private const double CURRENCY_RATE = 35.00;

        public string Name { get; }
        public double USD { get => UAH / CURRENCY_RATE; }
        public double UAH { get; }

        public Product(string name, double price)
        {
            Name = name;
            UAH = price;
        }

        public string ToString()
        {
            return this.ToString("G", CultureInfo.CurrentCulture);
        }

        public string ToString(string? format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string? format, IFormatProvider? provider)
        {
            if (string.IsNullOrEmpty(format))
            {
                format = "G";
            }

            if (provider == null)
            {
                provider = CultureInfo.CurrentCulture;
            }

            switch (format.ToUpperInvariant())
            {
                case "G":
                case "A":
                    return Name + " " + UAH.ToString("F2", provider) + " UAH";
                case "B":
                    return Name + " " + USD.ToString("F2", provider) + " USD";
                default:
                    throw new FormatException($"The {format} format string isn't supported");
            }
        }
    }
}
