using PhoneNumberLookup.controllers.Helpers;
using PhoneNumberLookup.InteractiveOptions.interfaces;
using System;
using System.Threading.Tasks;

namespace PhoneNumberLookup.controllers
{
    public class InteractiveConsoleController
    {
        public IOption[] _Options;
        public InteractiveConsoleController(IOption[] options)
        {
            _Options = options;
        }

        public async Task Start()
        {
            int option = -1;
            while (option < _Options.Length - 1)
            {
                Console.WriteLine("---------------------------------------------");
                dissplayOptions();
                option = Convert.ToInt32(Console.ReadLine().ToString());
                Console.Clear();
                await _Options[option].Action();
            }

        }

        private void dissplayOptions()
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("---------------------------------------------");
            for (int i = 0; i<_Options.Length; i++)
            {
                Console.WriteLine(String.Format("{0}: {1}", i, _Options[i].message));
            }

            Console.WriteLine("---------------------------------------------");
        }
    }
}
