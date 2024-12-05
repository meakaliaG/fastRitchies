using System;
using System.Drawing;

public class FoodItem : FoodCategory
{
	public string foodItemName { get; set; } //name of food item
	public double foodPrice { get; set; } //price of food item
	public string foodDescription { get; set; } //description of food item

	//constructor
	public FoodItem(string name, string category, double price, string description, Icon icon) : base(category, icon)
	{
		foodItemName = name;
		foodPrice = price;
		foodDescription = description;
	}
}
