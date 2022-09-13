using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantLineups
{
    internal static class KeyHelper
    {
        public static void DisableKey(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode is Keys.Left or Keys.Right)
            {
                e.Handled = true;
            }
        }
    }
}
