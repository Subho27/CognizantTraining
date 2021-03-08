using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async_Await_Usage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountCharacters()
        {
            int count = 0;
<<<<<<< HEAD
            using (StreamReader reader = new StreamReader("C:\\Users\\Subhodip\\Desktop\\abc.txt"))
=======
            using (StreamReader reader = new StreamReader(".......filepath to read a file........."))
>>>>>>> f3b1934f657018e5f903883fc622bc4d22f0ead3
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(1000);
            }
            return count;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            {
                Task<int> tasks = new Task<int>(CountCharacters);
                tasks.Start();
                label.Text = "Processing File Please Wait....";
                int count = await tasks;
                // int count = CountCharacters();
                label.Text = count.ToString() + " characters in file";
            }
        }
    }
}
