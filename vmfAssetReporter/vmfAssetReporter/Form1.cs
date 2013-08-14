using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string[] storedNames = new string[1000];


        public Form1()
        {
            InitializeComponent();
        }

        //This function checks to see if a word is contained in our string
        public string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }

        //checks to see if string is present in string array
        public bool isPresent(string strSource, int counter)
        {
            int j = 0;
            for (int i = 0; i < counter; i++)
            {
                if (storedNames.Contains(strSource))
                {
                    return true;
                }
                j++;
            }
            storedNames[counter + 1] = strSource;
            return false;

        }

        private void openBttn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                storedNames[i] = "";
            }
            textBox2.Clear();
            string filename;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                filename = ofd.FileName;
                int counter = 0;
                using (var reader = new StreamReader(filename))
                {
                    string line;
                    string tempString;
                    string holdString = "";


                    //This is for models
                    if (modelBttn.Checked)
                    {
                        textBox2.AppendText("****Models****" + "\r\n");
                    }
                    else if (textureBttn.Checked)
                    {
                        textBox2.AppendText("****Textures****" + "\r\n");
                    }
                    else if (soundBttn.Checked)
                    {
                        textBox2.AppendText("****Sound****" + "\r\n");
                    }
                    else
                    {
                    }
                    while ((line = reader.ReadLine()) != null)
                    {
                        
                        
                        tempString = line.ToString();
                        if (modelBttn.Checked)
                        {
                            //checking for models
                            holdString = getBetween(tempString, "models/", ".mdl");
                            if (holdString != "")
                            {
                                if(isPresent(holdString, counter) != true)
                                {
                                textBox2.AppendText("models/" + holdString + ".mdl" + "\r\n"); //checks to see if string is present already
                                counter++;
                                }
                            }
                            holdString = "";
                        }
                        else if (textureBttn.Checked)
                        {
                            //This is for textures
                            tempString = line.ToString();
                            //checking for textures
                            holdString = getBetween(tempString, "material\" \"", "\"");
                            if (holdString != "")
                            {
                                if (isPresent(holdString, counter) != true)
                                {
                                    textBox2.AppendText(holdString + "\r\n"); //checks to see if string is present already
                                    counter++;
                                }
                                
                            }
                            holdString = "";
                        }
                        else if (soundBttn.Checked)
                        {
                            //checking for sounds
                            holdString = getBetween(tempString, "message\" \"", "\"");
                            if (holdString != "")
                            {
                                if (isPresent(holdString, counter) != true)
                                {
                                    textBox2.AppendText(holdString + "\r\n"); //checks to see if string is present already
                                    counter++;
                                }
                                
                            }
                            holdString = "";
                        }
                        else
                        {
                        }
                         

                    } 

                }

            }

        }

        private void saveBttn_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {

                    sw.Write(textBox2.Text);

                }

            }
        }
    }
}
