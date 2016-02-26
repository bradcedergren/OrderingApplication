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

        public string[] optionsArray = new string[4];

        string bunType;
        string cheeseType;
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

        private void pnlCheese_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlCheese.Visible == true)
            {
                orderStep = "cheese";
                btnNext.Enabled = false;

                while (optionsArray[1] == "")
                {
                    btnNext.Enabled = false;
                }
            }
        }


        private void pnlToppings_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlToppings.Visible == true)
            {
                orderStep = "toppings";
                btnNext.Enabled = false;

                while (optionsArray[2] == "")
                {
                    btnNext.Enabled = false;
                }
            }
        }

        private void pnlSauce_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlSauce.Visible == true)
            {
                orderStep = "sauce";
                btnNext.Enabled = false;

                while (optionsArray[3] == "")
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
                case "cheese":
                    pnlBun.Visible = true;
                    pnlCheese.Visible = false;
                    break;
                case "toppings":
                    pnlCheese.Visible = true;
                    pnlToppings.Visible = false;
                    break;
                case "sauce":
                    pnlToppings.Visible = true;
                    pnlSauce.Visible = false;
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
                case "cheese":
                    pnlCheese.Visible = false;
                    pnlToppings.Visible = true;
                    break;
                case "toppings":
                    pnlToppings.Visible = false;
                    pnlSauce.Visible = true;
                    break;
                case "sauce":
                    pnlSauce.Visible = false;
                    pnlSummary.Visible = true;
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
            string bunType = Bun.createBun("whiteBun");
            optionsArray[0] = bunType;
            buildOptions();
            btnNext.Enabled = true;
        }

        private void btnWheat_Click(object sender, EventArgs e)
        {
            string bunType = Bun.createBun("wheatBun");
            optionsArray[0] = bunType;
            buildOptions();
            btnNext.Enabled = true;
        }

        private void btnPotato_Click(object sender, EventArgs e)
        {
            string bunType = Bun.createBun("potatoBun");
            optionsArray[0] = bunType;
            buildOptions();
            btnNext.Enabled = true;
        }

        private void btnAmerican_Click(object sender, EventArgs e)
        {
            string cheeseType = Cheese.createCheese("americanCheese");
            optionsArray[1] = cheeseType;
            buildOptions();
            btnNext.Enabled = true;
        }

        private void btnCheddar_Click(object sender, EventArgs e)
        {
            string cheeseType = Cheese.createCheese("cheddarCheese");
            optionsArray[1] = cheeseType;
            buildOptions();
            btnNext.Enabled = true;
        }

        private void btnSwiss_Click(object sender, EventArgs e)
        {
            string cheeseType = Cheese.createCheese("swissCheese");
            optionsArray[1] = cheeseType;
            buildOptions();
            btnNext.Enabled = true;
        }

        private void btnNoCheese_Click(object sender, EventArgs e)
        {
            string cheeseType = Cheese.createCheese("noCheese");
            optionsArray[1] = cheeseType;
            buildOptions();
            btnNext.Enabled = true;
        }

        private void btnTomatoes_Click(object sender, EventArgs e)
        {
            string toppingsType = Toppings.createToppings("tomatoes");
            buildToppings(toppingsType);
            //optionsArray[2] = toppingsType;
            //buildOptions();
            btnNext.Enabled = true;
        }

        private void buildToppings(string topping)
        {
            var toppingsArray = new string[4];
            for (int i = 0; i < toppingsArray.Length; i++)
            {
                toppingsArray[i] = topping;
                optionsArray[2] += toppingsArray[i];
            }
            buildOptions();
        }

        private void btnOnions_Click(object sender, EventArgs e)
        {
            string toppingsType = Toppings.createToppings("onions");
            optionsArray[2] = toppingsType;
            buildOptions();
            btnNext.Enabled = true;
        }

        private void btnPickles_Click(object sender, EventArgs e)
        {
            string toppingsType = Toppings.createToppings("pickles");
            optionsArray[2] = toppingsType;
            buildOptions();
            btnNext.Enabled = true;
        }

        private void btnLettuce_Click(object sender, EventArgs e)
        {
            string toppingsType = Toppings.createToppings("lettuce");
            optionsArray[2] = toppingsType;
            buildOptions();
            btnNext.Enabled = true;
        }

        private void btnKetchup_Click(object sender, EventArgs e)
        {
            string sauceType = Sauce.createSauce("ketchup");
            optionsArray[3] = sauceType;
            buildOptions();
            btnNext.Enabled = true;
        }

        private void btnMustard_Click(object sender, EventArgs e)
        {
            string sauceType = Sauce.createSauce("mustard");
            optionsArray[3] = sauceType;
            buildOptions();
            btnNext.Enabled = true;
        }

        private void btnMayo_Click(object sender, EventArgs e)
        {
            string sauceType = Sauce.createSauce("mayo");
            optionsArray[3] = sauceType;
            buildOptions();
            btnNext.Enabled = true;
        }

        private void btnBbq_Click(object sender, EventArgs e)
        {
            string sauceType = Sauce.createSauce("bbq");
            optionsArray[3] = sauceType;
            buildOptions();
            btnNext.Enabled = true;
        }

        private void clickHandler(object sender)
        {
            lblStack.Text = sender.ToString();
        }

        private void buildOptions()
        {
            lblStack.Text = string.Join("\n", optionsArray);
        }
    }
}
