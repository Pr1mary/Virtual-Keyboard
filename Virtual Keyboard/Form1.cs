using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Keyboard
{
    public partial class Form1 : Form
    {

        bool isShifted = false;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        public Form1()
        {
            TopMost = true;
            //FormBorderStyle = FormBorderStyle.None;
            CenterToScreen();
            InitializeComponent();
            FontUpdate();
        }

        private void FontUpdate()
        {
            if (isShifted)
            {
                buttonQ.Text = "Q";
                buttonW.Text = "W";
                buttonE.Text = "E";
                buttonR.Text = "R";
                buttonT.Text = "T";
                buttonY.Text = "Y";
                buttonU.Text = "U";
                buttonI.Text = "I";
                buttonO.Text = "O";
                buttonP.Text = "P";
                buttonA.Text = "A";
                buttonS.Text = "S";
                buttonD.Text = "D";
                buttonF.Text = "F";
                buttonG.Text = "G";
                buttonH.Text = "H";
                buttonJ.Text = "J";
                buttonK.Text = "K";
                buttonL.Text = "L";
                buttonZ.Text = "Z";
                buttonX.Text = "X";
                buttonC.Text = "C";
                buttonV.Text = "V";
                buttonB.Text = "B";
                buttonN.Text = "N";
                buttonM.Text = "M";
            }
            else
            {
                buttonQ.Text = "q";
                buttonW.Text = "w";
                buttonE.Text = "e";
                buttonR.Text = "r";
                buttonT.Text = "t";
                buttonY.Text = "y";
                buttonU.Text = "u";
                buttonI.Text = "i";
                buttonO.Text = "o";
                buttonP.Text = "p";
                buttonA.Text = "a";
                buttonS.Text = "s";
                buttonD.Text = "d";
                buttonF.Text = "f";
                buttonG.Text = "g";
                buttonH.Text = "h";
                buttonJ.Text = "j";
                buttonK.Text = "k";
                buttonL.Text = "l";
                buttonZ.Text = "z";
                buttonX.Text = "x";
                buttonC.Text = "c";
                buttonV.Text = "v";
                buttonB.Text = "b";
                buttonN.Text = "n";
                buttonM.Text = "m";
            }
                

        }

        private void ButtonShift_Click(object sender, EventArgs e)
        {
            isShifted = true;
            FontUpdate();
        }

        private void ButtonBackspace_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BS}");
        }


        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{LEFT}");
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void ButtonSpace_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
            FontUpdate();
        }

        private void ButtonQ_Click(object sender, EventArgs e)
        {
            
            if (!isShifted)
                SendKeys.SendWait("q");
            else
            {
                SendKeys.SendWait("Q");
                isShifted = !isShifted;
            }
            FontUpdate();

        }

        private void ButtonW_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("w");
            else
            {
                SendKeys.SendWait("W");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonE_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("e");
            else
            {
                SendKeys.SendWait("E");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonR_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("r");
            else
            {
                SendKeys.SendWait("R");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonT_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("t");
            else
            {
                SendKeys.SendWait("T");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonY_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("y");
            else
            {
                SendKeys.SendWait("Y");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonU_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("u");
            else
            {
                SendKeys.SendWait("U");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonI_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("i");
            else
            {
                SendKeys.SendWait("I");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonO_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("o");
            else
            {
                SendKeys.SendWait("O");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonP_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("p");
            else
            {
                SendKeys.SendWait("P");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonA_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("a");
            else
            {
                SendKeys.SendWait("A");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonS_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("s");
            else
            {
                SendKeys.SendWait("S");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonD_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("d");
            else
            {
                SendKeys.SendWait("D");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonF_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("f");
            else
            {
                SendKeys.SendWait("F");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonG_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("g");
            else
            {
                SendKeys.SendWait("G");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonH_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("h");
            else
            {
                SendKeys.SendWait("H");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonJ_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("j");
            else
            {
                SendKeys.SendWait("J");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonK_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("k");
            else
            {
                SendKeys.SendWait("K");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonL_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("l");
            else
            {
                SendKeys.SendWait("L");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonZ_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("z");
            else
            {
                SendKeys.SendWait("Z");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonX_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("x");
            else
            {
                SendKeys.SendWait("X");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("c");
            else
            {
                SendKeys.SendWait("C");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonV_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("v");
            else
            {
                SendKeys.SendWait("V");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonB_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("b");
            else
            {
                SendKeys.SendWait("B");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonN_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("n");
            else
            {
                SendKeys.SendWait("N");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void ButtonM_Click(object sender, EventArgs e)
        {
            if (!isShifted)
                SendKeys.SendWait("m");
            else
            {
                SendKeys.SendWait("M");
                isShifted = !isShifted;
            }
            FontUpdate();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("3");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("6");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("9");
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("0");
        }
    }
}
