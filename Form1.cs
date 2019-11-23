using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace AOA_projectpart2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string partialName = txtfile.Text;
            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(@"C:\folder");
            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + partialName + "*.*");

            foreach (FileInfo foundFile in filesInDir)
            {
                string fullName = foundFile.FullName;
                listBox1.Items.Add(fullName);
            }
        }
    }
}
