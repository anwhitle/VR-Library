using UnityEngine;
using System.Collections;

public class Bookshelf : MonoBehaviour {
	public int numOfFiles = 0; //The number of files detected. This will be the number of Books in a Bookshelf.
	public Transform Book; //References the book prefab to be dynamically created

	// Use this for initialization
	void Start () {
		numOfFiles = Random.Range(1, 51);//Creates a number >=1 and <51 representing the # of files FOR TESTING

		float shelf = 0; //The current shelf books are being created on in the for loop below
		int booksOnCurrentShelf = 0;

		//Loops once for every file that is in the folder
		for (int i=0; i<numOfFiles; i++) {
			//Instantiates the Books relative to the Bookshelf
			Vector3 vect = transform.TransformPoint(1.19F - (booksOnCurrentShelf * .318F), (5.35F - shelf), 0);  //(distanceFrom Bookshelf origin - (distance between books), height from bottom of Bookshelf, how deep the Books are placed)
			Instantiate(Book, vect, Quaternion.identity);
			booksOnCurrentShelf++;

			//Checks if the shelf is full
			if (booksOnCurrentShelf == 10)
			{
				shelf += 1.12F; //If shelf is full, this changes the y location the books in the Vector3 line above
				booksOnCurrentShelf = 0;
			}

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Would be called by the BookshelfCreation script when the bookshelf is first created
	void CreateBooks (int numOfFiles)
	{

	}
}
