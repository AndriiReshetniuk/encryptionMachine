using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace encryptionMachine
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Encryptor encryptor;
        public MainWindow()
        {
            InitializeComponent();
            encryptor = new Encryptor();
            CommandBinding encryptCommand = new CommandBinding(CustomCommands.Encrypt, executeEncrypt, canExecuteEncryptOrDecrypt);
            CommandBindings.Add(encryptCommand);
            CommandBinding decryptCommand = new CommandBinding(CustomCommands.Decrypt, executeDecrypt, canExecuteEncryptOrDecrypt);
            CommandBindings.Add(decryptCommand);
        }

        void canExecuteEncryptOrDecrypt(object sender, CanExecuteRoutedEventArgs e)
        {
            if (userInput.Text.Trim().Length > 0) e.CanExecute = true; else e.CanExecute = false;
        }
        void executeEncrypt(object sender, ExecutedRoutedEventArgs e)
        {
            userInput.Text = encryptor.ceazarEncryption(userInput.Text);
        }
        void executeDecrypt(object sender, ExecutedRoutedEventArgs e)
        {
            userInput.Text = encryptor.caezarDecryption(userInput.Text);
        }
    }
}
