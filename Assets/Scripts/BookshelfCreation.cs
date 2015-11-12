using UnityEngine;
using System.Collections;

public class BookshelfCreation : MonoBehaviour {
	// Use this for initialization
	int numOfFolders = 0; //The number of folders detected. This will be the number of Bookcases.
	public Transform Bookshelf; //Allows the Bookshelf prefab to be dynamically created
	
	// Use this for initialization
	void Start () {

		numOfFolders = Random.Range(1, 6);//Creates a number >=1 and <6 FOR TESTING

		for (int i=0; i<numOfFolders; i++) {
			GameObject go = Instantiate( Bookshelf, new Vector3 (12 - (i * 5), 0F, -13), Quaternion.identity) as GameObject; //(first bookshelf starting x coordinate - (distance between bookshelves), y coordinate in the game world, z coordinate in the game world)
			//go.SendMessage("CreateBooks", 10); //Trying to pass in a number into the Bookshelf script
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
