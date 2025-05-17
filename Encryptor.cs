using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encryptionMachine
{
    public class Encryptor
    {
        public string ceazarEncryption(string wordToEncryp)
        {
            StringBuilder encryptedWord = new StringBuilder();
            for(int i = 0; i< wordToEncryp.Length; i++)
            {
                char encryptedSymbol = (char)(wordToEncryp[i] + 1);
                encryptedWord.Append(encryptedSymbol);
            }
            return encryptedWord.ToString();
        }

        public string caezarDecryption(string wordToDecrypt)
        {
            StringBuilder decryptedWord = new StringBuilder();
            for(int i = 0; i < wordToDecrypt.Length; i++)
            {
                char decryptedSymbol = (char)(wordToDecrypt[i] - 1);
                decryptedWord.Append(decryptedSymbol);
            }
            return decryptedWord.ToString();

        }
    }
}
