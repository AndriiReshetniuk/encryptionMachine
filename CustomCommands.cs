using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace encryptionMachine
{
    public static class CustomCommands
    {
        public static RoutedCommand Encrypt = new RoutedCommand();
        public static RoutedCommand Decrypt = new RoutedCommand();
    }
}
