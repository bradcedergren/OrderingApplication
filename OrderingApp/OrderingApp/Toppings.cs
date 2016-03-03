using System.Collections.Generic;

namespace OrderingApp
{
    public class Toppings
    {
	    public Toppings(string name)
	    {
		    this.ToppingList = new List<string>();
		    this.Name = name;
	    }
        public List<string> AddToppings(string _toppingsType)
        {
            this.ToppingList.Add(_toppingsType);
            return this.ToppingList;
        }

	    public List<string> ToppingList { get; set; }
		public string Name { get; set; }
    }
}
