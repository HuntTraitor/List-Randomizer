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
using System.Collections;

namespace Random_List_Picker
{
    public partial class rerol : Form
    {


        ArrayList arlist = new ArrayList();
        int count = 0;

        OpenFileDialog oFile = new OpenFileDialog();
        string line = "";

        /*
          
            CODED MODULES
         
         
         */

        private void button1_Click(object sender, EventArgs e)
        {

            result.Clear();
            arlist.Clear();
            count = 0;
            if (oFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(oFile.FileName);

                line = sr.ReadLine();

                //case 0
                if (line == null)
                {
                    result.Text = "NO TEXT DETECTED";
                    return;
                }

                arlist.Add(line);
                count++;

                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        arlist.Add(line);
                        count++;
                    }
                }

                result.Text += arlist[randomNum(count)];

            }

            
        }

        private void reroll_Click(object sender, EventArgs e)
        {
            //case 0
            if (result.Text == "NO TEXT DETECTED" || result.Text == "")
                return;


            result.Clear();
            result.Text += arlist[randomNum(count)];
        }

        public int randomNum(int num)
        {
            var randomGenerator = new Random();
            return randomGenerator.Next(num);
        }

        /*
         
         EMPTY MODULES
         
         */


        public rerol()
        {
            InitializeComponent();
        }

        private void openFile_Load(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
