using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;

namespace CMPG215_Encryption_Assignment
{
    public partial class EncryptionForm : Form
    {
        string filePath = string.Empty;
        bool isEncryptionFileSelected = false;
        bool isDecryptionFileSelected = false;
        byte[] convertedFile;
        public EncryptionForm()
        {
            InitializeComponent();
        }

        private void EncryptionForm_Load(object sender, EventArgs e)
        {
            // Set default form state to encrypt
            EncryptTabButton.PerformClick();
        }

        public static byte[] GetHash(string inputString)
        {
            // Create an instance of the HashAlgorithm class
            using (HashAlgorithm algorithm = SHA256.Create())
                // Return the SHA256 hash of the byte values of the given password
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            // Returns the Hexadecimal values of the GetHash method
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        private int[] FeistelEncrypt(int pLeft, int pRight, int key)
        {
            int L1 = pLeft;
            int R1 = pRight;

            // Round 1
            int R2 = (key + 1) ^ L1;
            int L2 = R1;

            // Round 2
            int R3 = (key + 2) ^ L2;
            int L3 = R2;

            // Final
            int R4 = L3;
            int L4 = R3;

            int[] returnArray = { L4, R4 };
            return returnArray;
        }

        private int[] FeistelDecrypt(int pLeft, int pRight, int key)
        {
            int L1 = pLeft;
            int R1 = pRight;

            // Round 1
            int R2 = (key + 2) ^ L1;
            int L2 = R1;

            // Round 2
            int R3 = (key + 1) ^ L2;
            int L3 = R2;

            // Final
            int R4 = L3;
            int L4 = R3;

            int[] returnArray = { L4, R4 };
            return returnArray;
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            // Prompt a dialog so the user can select a file to encrypt / decrypt
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = OpenFileDialog.FileName; // Store the selected file path

                if (EncryptPane.Visible)
                {
                    isEncryptionFileSelected = true;
                    EncryptionSelectedFileLabel.Text = filePath;
                }
                else
                {
                    isDecryptionFileSelected = true;
                    DecryptionSelectedFileLabel.Text = filePath;
                }
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (isEncryptionFileSelected)
            {
                convertedFile = System.IO.File.ReadAllBytes(filePath);
                int fileLength = convertedFile.Length;
                int lastValue;
                int loopRange = fileLength;

                string password = txtPasswordEnc.Text;
                password = GetHashString(password);

                // Generate the key to use in encrypting the file
                int key = 0;
                int length = password.Length;
                for (int cnt = 0; cnt < length; cnt ++)
                {
                    key += password[cnt];
                    key -= password[length - 1];
                    
                }
                key /= length;

                // If the file contains an uneven amount of values, manually encrypt the last value
                if (fileLength % 2 != 0)
                {
                    lastValue = convertedFile[fileLength - 1];
                    loopRange -= 1;
                    convertedFile[fileLength - 1] = (byte)(lastValue + 1); // Shift the last value with one
                }

                for (int counter = 0; counter <= loopRange; counter++)
                {
                    if (counter % 2 != 0) // Execute after every second index
                    {
                        int leftValue = convertedFile[counter - 1];
                        int rightValue = convertedFile[counter];
                        int[] encryptedValues = FeistelEncrypt(leftValue, rightValue, key);

                        // Write the encrypted left and right values to the original byte array
                        convertedFile[counter - 1] = (byte)encryptedValues[0];
                        convertedFile[counter] = (byte)encryptedValues[1];
                    }
                }


                // Write encrypted values to file
                using (Stream file = File.OpenWrite(filePath))
                {
                    file.Write(convertedFile, 0, convertedFile.Length);
                    file.Close();
                }
                EncryptionResultLabel.Text = "Encryption done.";
            }
            else
            {
                EncryptionResultLabel.Text = "No file was selected";
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            // Set the filters to the correct file types
            saveFileDialog.Filter = "Text Files|*.txt|JPEG Image|*.jpeg|Png Image|*.png|RAR Files|*.rar";
            if (isDecryptionFileSelected)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK) // User should select a save location for the decrypted file
                {
                    string saveFilePath = saveFileDialog.FileName;
                    convertedFile = System.IO.File.ReadAllBytes(filePath);
                    int fileLength = convertedFile.Length;
                    int lastValue;
                    int loopRange = fileLength;

                    string password = txtPasswordDec.Text;
                    password = GetHashString(password);

                    // Generate the key to be used for the decryption
                    int key = 0;
                    int length = password.Length;
                    for (int cnt = 0; cnt < length; cnt++)
                    {
                        key += password[cnt];
                        key -= password[length - 1];
                    }
                    key /= length;

                    // If the amount of values in the array is uneven, decrypt the last value manually
                    if (fileLength % 2 != 0)
                    {
                        lastValue = convertedFile[fileLength - 1];
                        loopRange -= 1;
                        convertedFile[fileLength - 1] = (byte)(lastValue - 1); // Unshift the last value with one
                    }

                    for (int counter = 0; counter <= loopRange; counter++)
                    {
                        if (counter % 2 != 0)
                        {
                            int leftValue = convertedFile[counter - 1];
                            int rightValue = convertedFile[counter];
                            int[] decryptedValues = FeistelDecrypt(leftValue, rightValue, key);

                            // Write the decrypted values to the byte array
                            convertedFile[counter - 1] = (byte)decryptedValues[0];
                            convertedFile[counter] = (byte)decryptedValues[1];
                        }
                    }

                    // Write decrypted values to file in the selected path
                    using (Stream file2 = File.OpenWrite(saveFilePath))
                    {
                        file2.Write(convertedFile, 0, convertedFile.Length);
                        file2.Close();
                    }
                    DecryptionResultLabel.Text = "Decryption done.";
                }
                else
                {
                    DecryptionResultLabel.Text = "Decryption cancelled.";
                }
            }
            else
            {
                DecryptionResultLabel.Text = "No file was selected.";
            }
        }

        private void EncryptTabButton_Click(object sender, EventArgs e)
        {
            // Reset all critical values to default
            DisplayActionLabel.Text = "Encrypt";

            filePath = string.Empty;
            isEncryptionFileSelected = false;
            isDecryptionFileSelected = false;

            EncryptionResultLabel.Text = "-";
            EncryptionSelectedFileLabel.Text = "None selected";

            DecryptionSelectedFileLabel.Text = "None selected";
            DecryptionResultLabel.Text = "-";

            DecryptPane.Visible = false;
            EncryptPane.Visible = true;

            isEncryptionFileSelected = true;
            EncryptionSelectedFileLabel.Text = filePath;


        }

        private void DecryptTabButton_Click(object sender, EventArgs e)
        {
            // Reset all critical values to default
            DisplayActionLabel.Text = "Decrypt";

            filePath = string.Empty;
            isEncryptionFileSelected = false;
            isDecryptionFileSelected = false;

            EncryptionResultLabel.Text = "-";
            EncryptionSelectedFileLabel.Text = "None selected";

            DecryptionSelectedFileLabel.Text = "None selected";
            DecryptionResultLabel.Text = "-";

            EncryptPane.Visible = false;
            DecryptPane.Visible = true;

            isDecryptionFileSelected = true;
            DecryptionSelectedFileLabel.Text = filePath;
        }
    }
}
