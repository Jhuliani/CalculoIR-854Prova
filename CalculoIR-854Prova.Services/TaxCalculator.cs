﻿using CalculoIR_854Prova.Services.Interfaces;
using System;


namespace CalculoIR_854Prova.Services
{
    public class TaxCalculator : ITaxCalculator
    {
        public TaxCalculator()
        {

        }

        public double TaxCalculation(double value)
        {

            if (value <= 22847.76 )
            {
                return 0;
            }
            else if(value >= 22847.77 && value <= 33919.80){
                return value * 0.075 - 1713.58;
            }
            else if(value >=33919.81 && value <= 45012.60)
            {
                return value * 0.15 - 4257.57;
            }
            else if (value >= 45012.61 && value <= 55976.16)
            {
                return value * 0.225 - 7633.51;
            }
            else
            {
                return value * 0.275 - 10432.32;
            }
                        
        }
    }
}
