using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //primer stuffs, can move later
            Boolean Race = false;
            Boolean Archetype = false;
            Boolean Gear = false;
            Boolean Augments = false;
            Random Rng = new Random();
            int ranVal = -1;
            string raceName;
            
            /*the archetype value for uses
            order ( from 0 to 8)
            Street Samurai
            Adept
            Decker
            Rigger
            Technomancer
            Magician
            Shaman
            Face
            Random
             */
            int AcheType= -1;

            //nine stats, eight classes
            //ini is not inlcuded.
            int[,] AcheVals= new int[8, 9];
            
            for ( int i=0; i<8; i++){
                for (int y = 0; y < 9; y++)
                {
                    AcheVals[i, y] = 1;
                }
            }
            //street samurai focusing on body, agi, and rea
            AcheVals[0, 0] = 2;
            AcheVals[0, 1] = 2;
            AcheVals[0, 2] = 2;
            //adept on magic, agi and rea
            AcheVals[1, 1] = 2;
            AcheVals[1, 2] = 2;
            AcheVals[1, 8] = 2;
            //Decker focuses only on logic, as does rigger
            AcheVals[2, 6] = 2;
            AcheVals[3, 6] = 2;
            //technomancer has resonance(magic), willpower, and logic
            AcheVals[4, 8] = 2;
            AcheVals[4, 7] = 2;
            AcheVals[4, 6] = 2;
            //magic character, mage first with magic, will, and logic
            AcheVals[5, 8] = 2;
            AcheVals[5, 7] = 2;
            AcheVals[5, 6] = 2;
            //shaman, the charimatic spellcaster!
            AcheVals[6, 8] = 2;
            AcheVals[6, 7] = 2;
            AcheVals[6, 4] = 2;
            //face is all over, but focusing on cha
            AcheVals[7, 4] = 2;

            // a chunk of race max values and maximum points they can spend.
            // save the races as a multidimensional array, move this out of here afterwards
            // fisrt val is the racial val, the second is the max natural value
            // third is the highest possible value.
 
            int[,] human = new int[3, 11];
            int[,] ork = new int[3, 11];
            int[,] dwarf = new int[3, 11];
            int[,] elf = new int[3, 11];
            int[,] troll = new int[3, 11];

            for (int i = 0; i < 11; i++)
            {
                //BP values. second and thrid are the same becuase I don't want to alter the system for one thing!!
                if (i == 0)
                {
                    human[0, i] = 0;
                    human[1, i] = 150;
                    human[2, i] = 150;
                    ork[0,i] = 20;
                    ork[1, i] = 150;
                    ork[2, i] = 150;
                    dwarf[0, i] = 25;
                    dwarf[1, i] = 150;
                    dwarf[2, i] = 150;
                    elf[0, i] = 30;
                    elf[1, i] = 150;
                    elf[2, i] = 150;
                    troll[0, i] = 40;
                    troll[1, i] = 150;
                    troll[2, i] = 150;
                }
                //bod scores
                else if(i==1)
                {
                    human[0, i] = 1;
                    human[1, i] = 6;
                    human[2, i] = 9;
                    ork[0, i] = 4;
                    ork[1, i] = 9;
                    ork[2, i] = 13;
                    dwarf[0, i] = 2;
                    dwarf[1, i] = 7;
                    dwarf[2, i] = 10;
                    elf[0, i] = 1;
                    elf[1, i] = 6;
                    elf[2, i] = 9;
                    troll[0, i] = 5;
                    troll[1, i] = 10;
                    troll[2, i] = 15;
                }
                //agi scores
                else if (i == 2)
                {
                    human[0, i] = 1;
                    human[1, i] = 6;
                    human[2, i] = 9;
                    ork[0, i] = 1;
                    ork[1, i] = 6;
                    ork[2, i] = 9;
                    dwarf[0, i] = 1;
                    dwarf[1, i] = 6;
                    dwarf[2, i] = 9;
                    elf[0, i] = 2;
                    elf[1, i] = 7;
                    elf[2, i] = 10;
                    troll[0, i] = 1;
                    troll[1, i] = 5;
                    troll[2, i] = 7;
                }
                //rea scores
                else if (i == 3)
                {
                    human[0, i] = 1;
                    human[1, i] = 6;
                    human[2, i] = 9;
                    ork[0, i] = 1;
                    ork[1, i] = 6;
                    ork[2, i] = 9;
                    dwarf[0, i] = 1;
                    dwarf[1, i] = 5;
                    dwarf[2, i] = 7;
                    elf[0, i] = 1;
                    elf[1, i] = 6;
                    elf[2, i] = 9;
                    troll[0, i] = 1;
                    troll[1, i] = 6;
                    troll[2, i] = 9;
                }
                //str scores
                else if (i == 4)
                {
                    human[0, i] = 1;
                    human[1, i] = 6;
                    human[2, i] = 9;
                    ork[0, i] = 3;
                    ork[1, i] = 8;
                    ork[2, i] = 12;
                    dwarf[0, i] = 3;
                    dwarf[1, i] = 8;
                    dwarf[2, i] = 12;
                    elf[0, i] = 1;
                    elf[1, i] = 6;
                    elf[2, i] = 9;
                    troll[0, i] = 5;
                    troll[1, i] = 10;
                    troll[2, i] = 15;
                }
                //cha scores
                else if (i == 5)
                {
                    human[0, i] = 1;
                    human[1, i] = 6;
                    human[2, i] = 9;
                    ork[0, i] = 1;
                    ork[1, i] = 5;
                    ork[2, i] = 7;
                    dwarf[0, i] = 1;
                    dwarf[1, i] = 6;
                    dwarf[2, i] = 9;
                    elf[0, i] = 3;
                    elf[1, i] = 8;
                    elf[2, i] = 12;
                    troll[0, i] = 1;
                    troll[1, i] = 4;
                    troll[2, i] = 6;
                }
                //int scores
                else if (i == 6)
                {
                    human[0, i] = 1;
                    human[1, i] = 6;
                    human[2, i] = 9;
                    ork[0, i] = 1;
                    ork[1, i] = 6;
                    ork[2, i] = 9;
                    dwarf[0, i] = 1;
                    dwarf[1, i] = 6;
                    dwarf[2, i] = 9;
                    elf[0, i] = 1;
                    elf[1, i] = 6;
                    elf[2, i] = 9;
                    troll[0, i] = 1;
                    troll[1, i] = 5;
                    troll[2, i] = 7;
                }
                //log scores
                else if (i == 7)
                {
                    human[0, i] = 1;
                    human[1, i] = 6;
                    human[2, i] = 9;
                    ork[0, i] = 1;
                    ork[1, i] = 5;
                    ork[2, i] = 7;
                    dwarf[0, i] = 1;
                    dwarf[1, i] = 6;
                    dwarf[2, i] = 9;
                    elf[0, i] = 1;
                    elf[1, i] = 6;
                    elf[2, i] = 9;
                    troll[0, i] = 1;
                    troll[1, i] = 5;
                    troll[2, i] = 7;
                }
                //wil scores
                else if (i == 8)
                {
                    human[0, i] = 1;
                    human[1, i] = 6;
                    human[2, i] = 9;
                    ork[0, i] = 1;
                    ork[1, i] = 6;
                    ork[2, i] = 9;
                    dwarf[0, i] = 2;
                    dwarf[1, i] = 7;
                    dwarf[2, i] = 10;
                    elf[0, i] = 1;
                    elf[1, i] = 6;
                    elf[2, i] = 9;
                    troll[0, i] = 1;
                    troll[1, i] = 6;
                    troll[2, i] = 9;
                }
                //ini socres
                else if (i == 9)
                {
                    human[0, i] = 2;
                    human[1, i] = 12;
                    human[2, i] = 18;
                    ork[0, i] = 2;
                    ork[1, i] = 12;
                    ork[2, i] = 18;
                    dwarf[0, i] = 2;
                    dwarf[1, i] = 11;
                    dwarf[2, i] = 16;
                    elf[0, i] = 2;
                    elf[1, i] = 12;
                    elf[2, i] = 18;
                    troll[0, i] = 2;
                    troll[1, i] = 11;
                    troll[2, i] = 16;
                }
                //magi scores
                else if (i == 10)
                {
                    human[0, i] = 1;
                    human[1, i] = 6;
                    human[2, i] = 9;
                    ork[0, i] = 1;
                    ork[1, i] = 6;
                    ork[2, i] = 9;
                    dwarf[0, i] = 1;
                    dwarf[1, i] = 6;
                    dwarf[2, i] = 9;
                    elf[0, i] = 1;
                    elf[1, i] = 6;
                    elf[2, i] = 9;
                    troll[0, i] = 1;
                    troll[1, i] = 6;
                    troll[2, i] = 9;
                }
            }


            // test the race to see if it is empty.
            //if so choose a random value.
            //boolean for future proofing and a vlue for weighing characters in random generation.
            if (comboBox1.Text.Length != 0 && !comboBox1.Text.Equals("Random"))
            {
                Race = true;
                raceName = comboBox1.Text;
                label5.Text = raceName;
                
            }

            else
            {
                ranVal = Rng.Next(0, 4);
                raceName = comboBox1.Items[ranVal].ToString();
                label5.Text = raceName;
            }

            //archetype
            if (comboBox2.Text.Length != 0 && !comboBox2.Text.Equals("Random"))
            {
                Archetype = true;
                label5.Text += "\n" + comboBox2.Text;
                for (int i = 0; i < 8; i++)
                {
                    if (comboBox2.Text.Equals(comboBox2.Items[i]))
                    {
                        AcheType = i;
                        break;
                    }
                }

            }
            else
            {
                ranVal = Rng.Next(0, 7);
                label5.Text += "\n"+comboBox2.Items[ranVal];
                AcheType = ranVal;
                

            }

            //gear level
            if (comboBox3.Text.Length != 0 && !comboBox3.Text.Equals("Random"))
            {
                Gear = true;
                label5.Text += "\n" + comboBox3.Text;
            }
            else
            {
                ranVal = Rng.Next(0, 3);
                label5.Text += "\n" + comboBox3.Items[ranVal];

            }

            //augments
            if (comboBox4.Text.Length != 0 && !comboBox4.Text.Equals("Random"))
            {
                Augments = true;
                label5.Text += "\n" + comboBox4.Text;
            }
            else
            {
                ranVal = Rng.Next(0, 3);
                label5.Text += "\n" + comboBox4.Items[ranVal];

            }

            //decide the characters stats. This is determined by race and archetype. 
            //each archetype should have weighted values and a maximum skill value. 


            //create character with base stats! start by new character with 11 values( one for each stat plus BP.
            // remove 10 BP(or 25) for stat bought. Also, remove the cost of the race

            int[] character = new int[11];
            int[,] selectRace = new int[3, 11];

            if(raceName.Equals("Human"))
            {
                selectRace = human;
            }
            else if(raceName.Equals("Dwarf"))
            {
                selectRace = dwarf;
                
            }

            else if(raceName.Equals("Elf"))
            {
                selectRace= elf;

            }
            else if(raceName.Equals("Orc"))
            {
                selectRace = ork;
                
            }
            else if(raceName.Equals("Troll"))
            {
                selectRace = troll;
            }

            character[0] = selectRace[1, 0] - selectRace[0, 0];
            for (int i = 1; i < 11; i++)
            {
                character[i] = selectRace[0, i];
            }

            //time to do more of the random that this does so well.. i hope.
            //randome weigthed values to increase stats based on the archetype

            //for non magic classes, eight attributes. for magic classes, nine attributes.

            //TEST CHUNK!!!

           //thinking... okay, ranVal needs to change depending on class, with extra random values to serve as the weight.
           // if ranVal is above eight(or nine with magic classes) decrease by the value and use the seconday stat table.
           // secondary stat table is sized to the the summation of AcheVals - stat size, where value zero will be
           // the stat with 2, one will be the second value, so on and so forth.
           

            int[] secondStat= new int[8];
            int secondTemp=0;
            int Sized = 0;
            int valMax = 0;
            if (AcheType < 1 || AcheType == 7 || AcheType ==3 || AcheType== 2)
            {
                Sized = 8;
                
            }
            else 
            {
                Sized = 9;
            }

            for (int i = 0; i < Sized; i++)
            {
                valMax++;
                // created a second list, wshich skills have extra stats to be increased
                if (AcheVals[AcheType, i] > 1)
                {
                    valMax++;
                    secondStat[secondTemp] = i;
                    secondTemp++;
                }
            }

            valMax= valMax;
            while (character[0] >= 10)
            {

                ranVal = Rng.Next(1, valMax);
                if (ranVal < Sized+1)
                {
                    if (Sized == 9 && ranVal == Sized)
                    {
                        ranVal++;
                    }
                    if (character[ranVal] < selectRace[1, ranVal])
                    {
                        character[ranVal]++;
                        character[0] -= 10;
                    }
                    else if (character[ranVal] == selectRace[1, ranVal] && character[0] >= 25)
                    {
                        character[ranVal]++;
                        character[0] -= 25;
                    }
                }
                else
                {
                    ranVal -= Sized;
                    if (character[secondStat[ranVal]] < selectRace[1, secondStat[ranVal]])
                    {
                        character[ranVal]++;
                        character[0] -= 10;
                    }
                    else if (character[secondStat[ranVal]] == selectRace[1, secondStat[ranVal]] && character[0] >= 25)
                    {
                        character[ranVal]++;
                        character[0] -= 25;
                    }

                }
               
            }
            character[9] = character[3] + character[6];
            
            label5.Text += "\n bod \t"+ character[1];
            label5.Text += "\n agi \t" + character[2];
            label5.Text += "\n rea \t" + character[3];
            label5.Text += "\n str \t" + character[4];
            label5.Text += "\n cha \t" + character[5];
            label5.Text += "\n int \t" + character[6];
            label5.Text += "\n log \t" + character[7];
            label5.Text += "\n wil \t" + character[8];
            label5.Text += "\n ini \t" + character[9];
            label5.Text += "\n mag \t" + character[10];
            label5.Text += "\n BP: " + character[0];
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
