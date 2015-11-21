using UnityEngine;
using System.Collections;

public class Book : MonoBehaviour {

	string fileName = "";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Called by the Bookshelf script when the book is first created
	public void setFileName (string newFileName)
	{
		fileName = newFileName;
	}
}
