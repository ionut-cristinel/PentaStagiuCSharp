using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    // clasa Exit este responsabila de inchiderea aplicatiei la comanda exit
    public static class Exit
    {
        public static void ExitApplication()
        {
            Environment.Exit(0);
        }
    }
}
