using System;
using System.Drawing;

public class FoodCategory
{
	public string categoryName { get; set; } //name of category
    public Icon categoryIcon { get; set; } //category icon

    //constructor
    public FoodCategory(string name, Icon icon)
	{
		categoryName = name; 
		categoryIcon = icon;
	}
}
