using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryDecimalApp
{
    public partial class Form1 : Form
    {
        private CustomNumber customNumber;
        public Form1()
        {
            InitializeComponent();
            customNumber = new CustomNumber();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
            SetButtonStyles(SetBinaryString);
            SetButtonStyles(SetDigit);
            SetButtonStyles(AddDigit);
            SetButtonStyles(RemoveLastDigit);
            SetButtonStyles(Clear);
            SetButtonStyles(Copy);

        
            SetTextBoxStyles(tbBinaryString);
            SetNumericUpDownStyles(nudIndex);
            SetNumericUpDownStyles(nudValue);
            SetTextBoxStyles(lblNumber);
        }

        private void SetButtonStyles(Button button)
        {
            button.BackColor = Color.Blue;
            button.ForeColor = Color.White;
            button.Font = new Font(button.Font, FontStyle.Bold);
        }

        private void SetTextBoxStyles(TextBox textBox)
        {
            textBox.BackColor = Color.LightGray;
            textBox.Font = new Font(textBox.Font, FontStyle.Italic);
        }

        private void SetNumericUpDownStyles(NumericUpDown numericUpDown)
        {
            numericUpDown.BackColor = Color.LightGray;
            numericUpDown.Font = new Font(numericUpDown.Font, FontStyle.Italic);
        }

       
        private void SetBinaryString_Click(object sender, EventArgs e)
        {
            string binaryString = tbBinaryString.Text;
            customNumber.SetBinaryString(binaryString);
            UpdateNumberLabel();
        }

        private void SetDigit_Click(object sender, EventArgs e)
        {
            int index = (int)nudIndex.Value;
            byte value = (byte)nudValue.Value;
            customNumber.SetDigit(index, value);
            UpdateNumberLabel();
        }

        private void AddDigit_Click(object sender, EventArgs e)
        {
            byte value = (byte)nudValue.Value;
            customNumber.AddDigit(value);
            UpdateNumberLabel();
        }

        private void RemoveLastDigit_Click(object sender, EventArgs e)
        {
            customNumber.RemoveLastDigit();
            UpdateNumberLabel();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            customNumber = new CustomNumber();
            UpdateNumberLabel();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(customNumber.ToString());
        }
        private void UpdateNumberLabel()
        {
            lblNumber.Text = customNumber.ToString();
        }

        private void txt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileContents = File.ReadAllText(filePath);
                customNumber.SetBinaryString(fileContents);
                UpdateNumberLabel();
            }
        }

        private void img_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png, *.jpg, *.jpeg)|*.png;*.jpg;*.jpeg";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                try
                {
            
                    Image image = Image.FromFile(imagePath);

                    pictureBox.Image = image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка завантаження зображення: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    public class CustomNumber
    {
        private List<byte> digits; 

        public CustomNumber()
        {
            digits = new List<byte>();
        }

        public CustomNumber(string binaryString)
        {
            digits = new List<byte>();
            ParseBinaryString(binaryString);
        }

        public CustomNumber(CustomNumber other)
        {
            digits = new List<byte>(other.digits);
        }

        public void SetBinaryString(string binaryString)
        {
            digits.Clear();
            ParseBinaryString(binaryString);
        }

        public void SetDigit(int index, byte value)
        {
            if (index < 0 || index >= digits.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            digits[index] = (byte)(value & 0xF);
        }

        public byte GetDigit(int index)
        {
            if (index < 0 || index >= digits.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            return digits[index];
        }

        public void AddDigit(byte value)
        {
            digits.Add((byte)(value & 0xF));
        }

        public void RemoveLastDigit()
        {
            if (digits.Count > 0)
            {
                digits.RemoveAt(digits.Count - 1);
            }
        }

        public override string ToString()
        {
            string binaryString = "";
            foreach (byte digit in digits)
            {
                binaryString += Convert.ToString(digit, 2).PadLeft(4, '0');
            }
            return binaryString;
        }

        private void ParseBinaryString(string binaryString)
        {
            foreach (char c in binaryString)
            {
                if (c != '0' && c != '1')
                {
                    throw new ArgumentException("Invalid binary string.");
                }

                AddDigit((byte)(c - '0'));
            }
        }
    }
}
