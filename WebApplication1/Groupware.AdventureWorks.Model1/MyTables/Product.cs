using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupware.AdventureWorks.Model1
{
    public partial class Product
    {
        public double AntiquityInYears
        {
            get
            {
                var antiquity = 0.0;
                DateTime? miFechaFinal = DateTime.Now;


                if(DiscontinuedDate != null)
                {
                    miFechaFinal = DiscontinuedDate;
                }
                TimeSpan ts = (TimeSpan)(miFechaFinal - SellStartDate);
                antiquity = ts.Days;

                return antiquity;
            }

        }
        public decimal? WeightKilos {
            get
            {
                decimal? weight = Weight;
                if (WeightUnitMeasureCode == "G")
                {
                    weight /= 1000;
                    
                    }
                else if (WeightUnitMeasureCode == "LB")
                {
                    weight /= Convert.ToDecimal(2.2);
                }

                return (weight);

            }
                
                
    }
}
