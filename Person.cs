using System;

public class Person
{
	//Declare variables
	public int personId;
	public string firstName;
	public string lastName;
	public string favoriteColour;
	public int age;
	public bool isWorking;
	public string name;

	//Constructor
	public Person(int personId = 123, string firstName = "First", string lastName = "Last", string favoriteColour = "None", int age = 0, bool isWorking = false)
	{
		this.personId = personId;
		this.firstName = firstName;
		this.lastName = lastName;
		this.favoriteColour = favoriteColour;
		this.age = age;
		this.isWorking = isWorking;
		this.name = firstName + " " + lastName;
	}

	public string DisplayPersonInfo()
	{
		return $"{this.personId}:{this.name}'s favorite color is {this.favoriteColour}";
    }

	public void ChangeFavoriteColour()
	{
		this.favoriteColour = "White";
	}

	public int GetAgeInTenYears()
	{
		return this.age + 10;
	}

	public override string ToString()
	{
        return $"ID: {this.personId} \nName: {this.name} \nFav. Color: {this.favoriteColour} \nAge: {this.age} \nWorking: {this.isWorking}";
    }

}
