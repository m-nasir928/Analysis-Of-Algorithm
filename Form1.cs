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
namespace AOAprojectpart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Mahnoor Nasir\Desktop\New folder";
            string[] folders = Directory.GetDirectories(path);

            foreach (string folder in folders)
            {
                string partialName = textBox1.Text;
                DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(folder);
                FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + partialName + "*.*");

                foreach (FileInfo foundFile in filesInDir)
                {
                    string fullName = foundFile.FullName;
                    listfiles.Items.Add(fullName);
                }
            }
        }
    }
}
