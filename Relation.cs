using System;
using System.Security.Cryptography.X509Certificates;

public class Relation
{
	//Declate variable
    public string relationshipType;
	public Person person1;
	public Person person2;

	//Constructor
    public Relation(Person person1, Person person2, string relationshipType = "None")
	{
		this.person1 = person1;
		this.person2 = person2;
		this.relationshipType = relationshipType;
	}
}
