using UnityEngine;
using System.Collections;

public class ObjectHighlight : MonoBehaviour {
	private Color startcolor;
	// Use this for initialization
	void Start () {

		//Get the array from the Bookshelf
		/*GameObject bookshelf = GameObject.Find("Bookshelf"); //Locates the Bookshelf
		Bookshelf bookshelfScript = bookshelf.GetComponent<Bookshelf>(); //Takes the Bookshelf script in the Bookshelf model

		if (bookInSlot == true) 
		{
			GetComponent<Renderer>().material.color = Color.blue;
			//GetComponent<Renderer>().material.color = startcolor;
		} 
		else 
		{
			GetComponent<Renderer>().material.color = Color.clear;
			//GetComponent<Renderer>().material.color = Color
			//this.GetComponent<Renderer>(false);
		}*/
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseEnter()
	{
		//temporary if statement until array is coded
		if (!(GetComponent<Renderer>().material.color == Color.clear))
		{
			startcolor = GetComponent<Renderer>().material.color; //Sets startcolor to the objects initial color
			GetComponent<Renderer>().material.color = Color.red; //Sets the color to red while the mouse is over
		}

	}
	void OnMouseExit()
	{
		GetComponent<Renderer>().material.color = startcolor; //Return the object to it's initial color
	}
}