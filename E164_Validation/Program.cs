using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace E164_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
          //Text to be displayed in Console.
                Console.WriteLine(" Please enter phone number:");
                E164_Validation(Console.ReadLine().Trim());

        }
        /// <summary>
        /// Valiadate Function
        /// </summary>
        /// <param name="userInput">This function validates user input phone number and displays it in E164 format like this +1-(XXX)-XXX-XXXX. If user provides anything that is not a qo digit phone number. System throw validatation message as "Wrong Input"</param>
        private static void E164_Validation(string userInput)
        {
            //Standard regex for validating 10 digit phone number.
            Regex regex = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            if (regex.Match(userInput.Trim()).Success && userInput.Count()==10)
            {
                StringBuilder str = new StringBuilder();
                str.Append("+1-(");
                str.Append(userInput.Substring(0, 3)+")-");
                str.Append(userInput.Substring(3, 3) + '-');
                str.Append(userInput.Substring(6, 4));
                Console.WriteLine("Input phone Number is Correct.\n E164 format is : " + str.ToString());
            }
            else
                Console.WriteLine("Wrong Format! Please Enter correct format");
            Console.WriteLine("Press any key to Exit!!");
            Console.ReadKey();
        
        }
    }
}
