using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static System.Windows.Forms.Timer Timer = new System.Windows.Forms.Timer();

        string lineaOfCode;
        string lineaOfCodeS;
        string[] line = new string[1000];
        int resource = 0;
        int IR = 0;
        int PC = 1;
        int AC = 0;
        int MAR = 0;
        int MDR = 0;
        string sResource;
        int[] MM = new int[999]; // left direction right data
        string test;
        int LengthMemory;


        public Form1()
        {
            InitializeComponent();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            lineaOfCode = richTextBox1.Text;
            lineaOfCodeS = lineaOfCode;
            lineaOfCode = lineaOfCode.Replace(" ", "");
            string[] line = lineaOfCode.Split('\n');
            int pointer = line.Length;
            for (int i = 0; i < pointer; i++)
            {
                MM[123] = 234;
                MM[234] = 45;
                
                IR = i;
                PC = IR + 1;
                PCBox.Text = PC.ToString();

                IRBox.Text = IR.ToString();
                MARBox.Text = MAR.ToString();
                ACBox.Text = AC.ToString();
                MDRBox.Text = MDR.ToString();
                richTextBox2.Text = i.ToString();
                LengthMemory = line[i].Length;
                richTextBox3.Text += " " + i.ToString();

                

                if (LengthMemory != 6 && LengthMemory != 3 && LengthMemory != 9)
                {
                    // display message error 
                    richTextBox2.Text = "Error Check line: " + i;
                }
                else
                {
                    test = line[i].Substring(0, 3);

                    if (LengthMemory == 6) // if has 3
                    {
                        if (test.ToUpper() == "ORG") {
                            MAR = Int32.Parse(line[i].Substring(3, 3));
                            i = MAR - 1;
                            
                        }
                    }
                    else if (LengthMemory == 9) // if has 9
                    {
                        if (test == "JMP")
                        {
                        }
                        // microoperation of lda
                        else if (test.ToUpper() == "LDA")
                        {
                            test = line[i].Substring(3, 3);
                            if(test == "ABS")
                            {  
                                MAR = Int32.Parse(line[i].Substring(6, 3));
                                AC = MM[MAR];
                                ACBox.Text = AC.ToString();

                            }
                            else if (test.ToUpper() == "IND")
                            {

                                MAR = Int32.Parse(line[i].Substring(6, 3));
                                
                                resource = MM[MAR];
                                AC = MM[resource];
                                ACBox.Text = AC.ToString();

                            }
                            else if (test.ToUpper() == "REL")
                            {

                                resource = Int32.Parse(line[i].Substring(6, 3));
                                
                                resource = PC + resource;
                                AC = MM[resource];
                                ACBox.Text = AC.ToString();

                            }
                            else if (test.ToUpper() == "INM")
                            {
                                AC = Int32.Parse(line[i].Substring(6, 3));
                                ACBox.Text = AC.ToString();
                                 

                            }

                        }
                        // microopretaion of add
                        else if (test.ToUpper() == "ADD")
                        {
                            test = line[i].Substring(3, 3);
                            if (test == "ABS")
                            {
                                MAR = Int32.Parse(line[i].Substring(6, 3));
                                resource = Int32.Parse(ACBox.Text);
                                AC = MM[MAR] + resource;
                                ACBox.Text = AC.ToString();

                            }
                            else if (test.ToUpper() == "IND")
                            {

                                MAR = Int32.Parse(line[i].Substring(6, 3));

                                resource = MM[MAR];
                                AC = AC + MM[resource];
                                ACBox.Text = AC.ToString();

                            }
                            else if (test.ToUpper() == "REL")
                            {

                                resource = Int32.Parse(line[i].Substring(6, 3));

                                resource = PC + resource;
                                AC = AC + MM[resource];
                                ACBox.Text = AC.ToString();

                            }
                            else if (test.ToUpper() == "INM")
                            {
                                AC = AC + Int32.Parse(line[i].Substring(6, 3));
                                ACBox.Text = AC.ToString();



                            }
                        }
                        // MICROOPERATION of STA
                        else if (test.ToUpper() == "STA")
                        {
                            test = line[i].Substring(3, 3);
                            if (test == "ABS")
                            {
                                MAR = Int32.Parse(line[i].Substring(6, 3));
                                MM[MAR] = AC;


                            }
                            else if (test.ToUpper() == "IND")
                            {

                                MAR = Int32.Parse(line[i].Substring(6, 3));

                                resource = MM[MAR];
                                MM[resource] = AC;

                            }
                            else if (test.ToUpper() == "REL")
                            {

                                resource = Int32.Parse(line[i].Substring(6, 3));

                                resource = PC + resource;
                                MM[resource] = AC;

                            }
                        }
                        // Microoperation SUB
                        else if (test.ToUpper() == "SUB")
                        {
                            test = line[i].Substring(3, 3);
                            if (test == "ABS")
                            {
                                MAR = Int32.Parse(line[i].Substring(6, 3));
                                resource = Int32.Parse(ACBox.Text);
                                AC =  resource - MM[MAR];
                                ACBox.Text = AC.ToString();

                            }
                            else if (test.ToUpper() == "IND")
                            {

                                MAR = Int32.Parse(line[i].Substring(6, 3));

                                resource = MM[MAR];
                                AC = AC - MM[resource];
                                ACBox.Text = AC.ToString();

                            }
                            else if (test.ToUpper() == "REL")
                            {

                                resource = Int32.Parse(line[i].Substring(6, 3));

                                resource = PC + resource;
                                AC = AC - MM[resource];
                                ACBox.Text = AC.ToString();

                            }
                            else if (test.ToUpper() == "INM")
                            {
                                AC = AC - Int32.Parse(line[i].Substring(6, 3));
                                ACBox.Text = AC.ToString();



                            }

                        }
                        else if (test.ToUpper() == "CLA") { }

                        else if (test.ToUpper() == "JMP") { }
                    }






                    else if(LengthMemory == 3) // if has 3
                    {
                        if (test.ToUpper() == "HLT") { }
                        else if (test.ToUpper() == "NOP") { }
                        else if (test.ToUpper() == "NEG")
                        {
                            richTextBox2.Text = "NEG";
                        }
                        

                    }
                    else  /*message error*/  { }


                }
            }
        }
        //codigo de prueba



        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
