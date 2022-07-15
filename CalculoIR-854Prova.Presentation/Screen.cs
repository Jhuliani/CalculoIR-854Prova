using System;
using CalculoIR_854Prova.Services.Interfaces;



namespace CalculoIR_854Prova.Presentation
{
    public class Screen : IScreen
    {
        private readonly ITaxCalculator _tax;
        public Screen(ITaxCalculator tax)
        {
            _tax = tax;
        }
        
        public void BegginApp()
        {
            Messages.GetInputUser();
            double inputUser = Validation.ValidatePositiveAndEmptyIntInput();
            
            double userTax = _tax.TaxCalculation(inputUser);
            Console.Clear();
            Messages.InputIR();
            Console.WriteLine(userTax.ToString("C"));
            if(userTax == 0)
            {
                Messages.IsentUser();
            }
            

        }

        



       

        
    }
}
