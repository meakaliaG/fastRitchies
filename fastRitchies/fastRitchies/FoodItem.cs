using System;

public class FoodItem
{
	public string foodItemName; //name of food item
	public double foodPrice; //price of food item
	public string foodDescription; //description of food item

	//constructor
	public FoodItem(string name, double price, string description)
	{
		foodItemName = name;
		foodPrice = price;
		foodDescription = description;
	}
}
