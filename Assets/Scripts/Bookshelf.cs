using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class Bookshelf : MonoBehaviour {
	private FileInfo[] files; //Stores an array of files in this bookshelve's folder
	public Transform Book; //References the book prefab to be dynamically created
	private bool needsUpdate = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (needsUpdate == true) 
		{
			float shelf = 0; //The current shelf books are being created on in the for loop below
			int booksOnCurrentShelf = 0;
		
			//Loops once for every file that is in the folder
			for (int i=0; i < files.Length; i++) {
				//Instantiates the Books relative to the Bookshelf
				Vector3 vect = transform.TransformPoint (1.19F - (booksOnCurrentShelf * .318F), (5.35F - shelf), 0);  //(distanceFrom Bookshelf origin - (distance between books), height from bottom of Bookshelf, how deep the Books are placed)
				GameObject newBook = (Instantiate (Book, vect, Quaternion.identity) as GameObject);
			
				//This is the only part not working right now. Is there something wrong with .Name?
				//newBook.SendMessage ("setFileName", files[i].Name); 

				booksOnCurrentShelf++;
			
				//Checks if the shelf is full
				if (booksOnCurrentShelf == 10) {
					//If shelf is full, this changes the y location the books in the Vector3 line above
					shelf += 1.12F; 
					booksOnCurrentShelf = 0;
				}
			}
			needsUpdate = false;
		}

	}

	//Called by the BookshelfCreation script when the bookshelf is first created
	public void setFiles (FileInfo[] filePathList)
	{
		files = filePathList;
	}

	public void setUpdate (int update)
	{
		if (update > 0) {
			needsUpdate = true;
		}
	}
}
