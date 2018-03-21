using System;
using System.Drawing.Text;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace FileFinder
{
    public partial class Form1 : Form
    {
        private string fileName;
        private bool False;
        private object searchString;

        //private object dialog;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string[] files = Directory.GetFiles(PathSearch.Text, "*." + ExtSearch.Text);

                foreach (string file in files)
                {
                    searchFile(file, StringSearch.Text);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private bool searchFile(string fileName, string searchString)
        {
            bool stringFound = False;

            FileStream file = new FileStream(fileName, FileMode.Open);
            StreamReader sr = new StreamReader(file);

            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();

                if (line.ToUpper().Contains(searchString.ToUpper()))
                {
                    stringFound = true;
                    break;
                }
            }

            return stringFound;
        }



    }
}














