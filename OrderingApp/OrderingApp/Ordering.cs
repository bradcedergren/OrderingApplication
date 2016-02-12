using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderingApp
{
    public partial class Ordering : Form
    {
        // Declarations
        bool takeOut;
        int pattyNum;
        string orderStep; //keeps track of current panel

        string[] optionsArray = new string[4];

        string bunType;
        string cheeseType;
        string[] toppings = new string[] {};
        string[] sauce = new string[] {};
        
        public Ordering()
        {
            InitializeComponent();
        }

        /* Application Load Event */
        private void Ordering_Load(object sender, EventArgs e)
        {
            pnlStart.Visible = true;

            // Hide all panels
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlPrevNext.Visible = false;
            pnlBuild.Visible = false;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
            pnlSpecialty.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlNav.Visible = false;
            pnlStack.Visible = false;

            lblStack.Text = "";
        }

        /* Panel Visible Changed Events */
        private void pnlStart_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlStart.Visible == true)
            {
                orderStep = "start";
            }
        }

        private void pnlLocation_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlLocation.Visible == true)
            {
                orderStep = "location";
            }
        }

        private void pnlOrderType_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlOrderType.Visible == true)
            {
                orderStep = "ordertype";
            }
        }

        private void pnlBuild_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlBuild.Visible == true)
            {
                orderStep = "build";
                btnNext.Visible = false;
            }
        }

        private void pnlBun_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlBun.Visible == true)
            {
                orderStep = "bun";
                btnNext.Enabled = false;

                while (optionsArray[0] == "")
                {
                    btnNext.Enabled = false;
                }
            }
        }

        /* Button Click Events */
        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            pnlLocation.Visible = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            takeOut = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlPrevNext.Visible = true;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            takeOut = true;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlPrevNext.Visible = true;
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
            pnlBuild.Visible = true;
        }

        private void btnSpecialty_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            switch (orderStep)
            {
                case "ordertype":
                    pnlOrderType.Visible = false;
                    pnlLocation.Visible = true;
                    break;
                case "build":
                    pnlBuild.Visible = false;
                    pnlLocation.Visible = true;
                    break;
                case "bun":
                    pnlBuild.Visible = true;
                    pnlBun.Visible = false;
                    break;
                default:
                    pnlStart.Visible = true;
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (orderStep)
            {
                case "build":
                    pnlBuild.Visible = false;
                    pnlBun.Visible = true;
                    break;
                case "bun":
                    pnlBun.Visible = false;
                    pnlCheese.Visible = true;
                    break;
                default:
                    pnlStart.Visible = true;
                    break;
            }
        }

        private void btnBuildStart_Click(object sender, EventArgs e)
        {
            pnlBuild.Visible = false;
            pnlBun.Visible = true;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            optionsArray[0] = "whiteBun\n";
            lblStack.Text = optionsArray[0];
            btnNext.Enabled = true;
        }

        private void btnWheat_Click(object sender, EventArgs e)
        {
            optionsArray[0] = "wheatBun\n";
            lblStack.Text = optionsArray[0];
            btnNext.Enabled = true;
        }

        private void btnPotato_Click(object sender, EventArgs e)
        {
            optionsArray[0] = "potatoBun\n";
            lblStack.Text = optionsArray[0];
            btnNext.Enabled = true;
        }

        private void btnAmerican_Click(object sender, EventArgs e)
        {
            optionsArray[1] = "americanCheese\n";
            lblStack.Text += optionsArray[1];
        }

        private void btnCheddar_Click(object sender, EventArgs e)
        {
            optionsArray[1] = "cheddarCheese\n";
            if (optionsArray[1] != "")
            {
                lblStack.Text += optionsArray[1];
            }
        }

        private void btnSwiss_Click(object sender, EventArgs e)
        {
            optionsArray[1] = "swissCheese\n";
            lblStack.Text += optionsArray[1];
        }

        private void btnNoCheese_Click(object sender, EventArgs e)
        {
            optionsArray[1] = "noCheese\n";
            lblStack.Text += optionsArray[1];
        }

    }
}
