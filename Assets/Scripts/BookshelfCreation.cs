using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;
//using System.IO.DirectoryInfo;

public class BookshelfCreation : MonoBehaviour {
	int numOfFolders = 0; //The number of folders detected. This will be the number of Bookshelves
	public GameObject Bookshelf; //Allows the Bookshelf prefab to be dynamically created
	public Text testText; //For TESTING

	
	// Use this for initialization
	void Start () {
		string path = System.IO.Directory.GetCurrentDirectory() + "/MyVRLibrary"; //Get the path to the user's folder
		DirectoryInfo userFolder = new DirectoryInfo(path); //This line is needed to reference MyVRLibrary as a directory

		//FOR TESTING
		if (!Directory.Exists(path)) 
		{
			testText.text = "DOES NOT EXIST";
		}
		int j = 1;

		//Returns an array of subdirectories (Bookshelves) in the MyVRLibrary directory
		DirectoryInfo[] folders = userFolder.GetDirectories();

		//Loops through every folder, passing its files to that Bookshelf
		for (int i=0; i < folders.Length; i++) {

			//Creates an array representing the files in the current directory the loop is working with
			FileInfo[] filesInFolder = folders[i].GetFiles();

			//Creates a new Bookshelf, and stores it is a GameObject so it can be referenced below
			GameObject newBookShelf = (Instantiate(Bookshelf, new Vector3 (12 - (i * 5), 0F, -13), Quaternion.identity) as GameObject); //(first bookshelf starting x coordinate - (distance between bookshelves), y coordinate in the game world, z coordinate in the game world)

			//Takes the new Bookshelf GameObject and passes in the array of files
			newBookShelf.SendMessage("setFiles", filesInFolder); //Calls the setBooks function in the newly created Bookshelf
			newBookShelf.SendMessage("setUpdate", j);

		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
