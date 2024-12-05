using System;
using System.Drawing;

public class FoodCategory
{
	public string categoryName; //name of category
	public Icon categoryIcon; //category icon

	//constructor
	public FoodCategory(string name, Icon icon)
	{
		categoryName = name; 
		categoryIcon = icon;
	}
}
