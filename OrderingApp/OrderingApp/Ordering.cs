﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderingApp
{
	public partial class Ordering : Form
	{
		// Declarations
		bool takeOut;
		int pattyNum;
		string orderStep; //keeps track of current panel

		//public string[] optionsArray = new string[4];

		List<string> optionsList = new List<string>();
		List<Cheese> cheeseList = new List<Cheese>();
		List<Toppings> toppingsList = new List<Toppings>();
		List<Sauce> sauceList = new List<Sauce>();
		List<Bun> bunList = new List<Bun>();

		Bun wheat = new Bun("wheat");
		Bun white = new Bun("Wheat");
		Bun potato = new Bun("Potato");
		Cheese american = new Cheese("american");
		Cheese cheddar = new Cheese("cheddar");
		Cheese swiss = new Cheese("swiss");
		Toppings tomatoes = new Toppings("tomatoes");
		Toppings onions = new Toppings("onions");
		Toppings pickles = new Toppings("pickles");
		Toppings lettuce = new Toppings("lettuce");
		Sauce ketchup = new Sauce("ketchup");
		Sauce mustard = new Sauce("mustard");
		Sauce mayo = new Sauce("mayo");
		Sauce bbq = new Sauce("bbq");


		string bunType;
		string cheeseType;

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

				if (optionsList.Count < 1)
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

				if (optionsList.Count < 1)
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

				if (optionsList.Count < 1)
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

				if (optionsList.Count < 1)
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

		#region bun
		private void btnWhite_Click(object sender, EventArgs e)
		{
			updateBunList(white, false);
			updateBunOptions();
			buildOptions();
			btnNext.Enabled = true;
		}

		private void btnWheat_Click(object sender, EventArgs e)
		{
			updateBunList(wheat, false);
			updateBunOptions();
			buildOptions();
			btnNext.Enabled = true;
		}

		private void btnPotato_Click(object sender, EventArgs e)
		{
			updateBunList(potato, false);
			updateBunOptions();
			buildOptions();
			btnNext.Enabled = true;
		}
		#endregion

		#region Cheese
		private void btnAmerican_Click(object sender, EventArgs e)
		{
			updateCheeseList(american, false);
			updateCheeseOptions();
			buildOptions();
			btnNext.Enabled = true;
		}


		private void btnCheddar_Click(object sender, EventArgs e)
		{
			updateCheeseList(cheddar, false);
			updateCheeseOptions();
			buildOptions();
			btnNext.Enabled = true;
		}

		private void btnSwiss_Click(object sender, EventArgs e)
		{
			updateCheeseList(swiss, false);
			updateCheeseOptions();
			buildOptions();
			btnNext.Enabled = true;
		}

		private void btnNoCheese_Click(object sender, EventArgs e)
		{
		//	var NoCheese = new Cheese("No Cheese");
		//	updateCheeseList(NoCheese, true);
		//	updateCheeseOptions();
		//	buildOptions();
		btnNext.Enabled = true;
		}
#endregion

		#region toppings
		private void btnTomatoes_Click(object sender, EventArgs e)
		{
			updateToppingsList(tomatoes, false);
			updateToppingsOptions();
			buildOptions();
			btnNext.Enabled = true;
		}

		private void btnOnions_Click(object sender, EventArgs e)
		{
			updateToppingsList(onions, false);
			updateToppingsOptions();
			buildOptions();
			btnNext.Enabled = true;
		}

		private void btnPickles_Click(object sender, EventArgs e)
		{
			updateToppingsList(pickles, false);
			updateToppingsOptions();
			buildOptions();
			btnNext.Enabled = true;
		}

		private void btnLettuce_Click(object sender, EventArgs e)
		{
			updateToppingsList(lettuce, false);
			updateToppingsOptions();
			buildOptions();
			btnNext.Enabled = true;
		}
		#endregion

		#region Sauce
		private void btnKetchup_Click(object sender, EventArgs e)
		{
			updateSauceList(ketchup, false);
			updateSauceOptions();
			buildOptions();
			btnNext.Enabled = true;
		}

		private void btnMustard_Click(object sender, EventArgs e)
		{
			updateSauceList(mustard, false);
			updateSauceOptions();
			buildOptions();
			btnNext.Enabled = true;
		}

		private void btnMayo_Click(object sender, EventArgs e)
		{
			updateSauceList(mayo, false);
			updateSauceOptions();
			buildOptions();
			btnNext.Enabled = true;
		}

		private void btnBbq_Click(object sender, EventArgs e)
		{
			updateSauceList(bbq, false);
			updateSauceOptions();
			buildOptions();
			btnNext.Enabled = true;
		}


		#endregion

		#region Private Methods

		private void updateBunList(Bun bun, bool remove)
		{
			if (remove)
			{
				bunList.Clear();
			}
			if (!bunList.Contains(bun))
			{
				bunList.Add(bun);
			}
			else
			{
				bunList.Remove(bun);
				optionsList.Remove(bun.Name);
			}
		}


		private void updateCheeseList(Cheese cheese, bool remove)
		{
			if (remove)
			{
				cheeseList.Clear();
			}
			if (!cheeseList.Contains(cheese))
			{
				cheeseList.Add(cheese);
			}
			else
			{
				cheeseList.Remove(cheese);
				optionsList.Remove(cheese.Name);
			}
		}

		private void updateToppingsList(Toppings topping, bool remove)
		{
			if (remove)
			{
				toppingsList.Clear();
			}
			if (!toppingsList.Contains(topping))
			{
				toppingsList.Add(topping);
			}
			else
			{
				toppingsList.Remove(topping);
				optionsList.Remove(topping.Name);
			}
		}

		private void updateSauceList(Sauce sauce, bool remove)
		{
			if (remove)
			{
				sauceList.Clear();
			}
			if (!sauceList.Contains(sauce))
			{
				sauceList.Add(sauce);
			}
			else
			{
				sauceList.Remove(sauce);
				optionsList.Remove(sauce.Name);
			}
		}

		private void updateBunOptions()
		{
			foreach (var bun in bunList)
			{
				if (!optionsList.Contains(bun.Name))
				{
					optionsList.Add(bun.Name);
				}
			}
			if (bunList.Count == 0)
			{
				for (int i = optionsList.Count - 1; i > -1; i--)
				{
					if (optionsList[i] == (white.Name) | optionsList[i] == (potato.Name) | optionsList[i] == (wheat.Name))
					{
						optionsList.RemoveAt(i);
					}
				}
			}
		}

		private void updateCheeseOptions()
		{
			foreach (var cheese in cheeseList)
			{
				if (!optionsList.Contains(cheese.Name))
				{
					optionsList.Add(cheese.Name);
				}
			}
			if (cheeseList.Count == 0)
			{
				for (int i = optionsList.Count - 1; i > -1; i--)
				{
					if (optionsList[i] == (american.Name) | optionsList[i] == (swiss.Name) | optionsList[i] == (cheddar.Name))
					{
						optionsList.RemoveAt(i);
					}
				}
			}
		}

		private void updateToppingsOptions()
		{
			foreach (var toppings in toppingsList)
			{
				if (!optionsList.Contains(toppings.Name))
				{
					optionsList.Add(toppings.Name);
				}
			}
			if (toppingsList.Count == 0)
			{
				for (int i = optionsList.Count - 1; i > -1; i--)
				{
					if (optionsList[i] == (lettuce.Name) | optionsList[i] == (pickles.Name) | optionsList[i] == (onions.Name) | optionsList[i] == (tomatoes.Name))
					{
						optionsList.RemoveAt(i);
					}
				}
			}
		}

		private void updateSauceOptions()
		{
			foreach (var sauce in sauceList)
			{
				if (!optionsList.Contains(sauce.Name))
				{
					optionsList.Add(sauce.Name);
				}
			}
			if (sauceList.Count == 0)
			{
				for (int i = optionsList.Count - 1; i > -1; i--)
				{
					if (optionsList[i] == (lettuce.Name) | optionsList[i] == (pickles.Name) | optionsList[i] == (onions.Name) | optionsList[i] == (tomatoes.Name))
					{
						optionsList.RemoveAt(i);
					}
				}
			}
		}


		private void buildOptions()
		{
			lblStack.Text = string.Join("\n", optionsList);
		}
		#endregion

	}
}
