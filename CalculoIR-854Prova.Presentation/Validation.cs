using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIR_854Prova.Presentation
{
    public class Validation
    {
        public Validation()
        {

        }

        
        public static double ValidatePositiveAndEmptyIntInput( string ErrorMessage = "O valor é inválido")
        {
            double response;
            bool validation;
            do
            {
                validation = !double.TryParse(Console.ReadLine(), out response) || response <= 0;

                if (validation)
                {
                    Console.WriteLine(ErrorMessage);
                }
            } while (validation);

            return response;
        }
        


    }
}
