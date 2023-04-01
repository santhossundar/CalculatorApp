using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v2
{
    internal class Program
    {
        static void Main(String[] args)
        {
            DisplayMenu displayMenu = new DisplayMenu();
            displayMenu.ShowOperatorSelectionMenu();

            CommandLineInputForOperator inputForOperator = new CommandLineInputForOperator();
            string operation = inputForOperator.getOperator();
        }
    }
}
