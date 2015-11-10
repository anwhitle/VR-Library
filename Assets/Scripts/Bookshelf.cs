using UnityEngine;
using System.Collections;

public class Bookshelf : MonoBehaviour {
	public string[] bookSlots = new string[50];

	// Use this for initialization
	void Start () {
		//NOTE: These lines are used for testing until file system code is added
		bookSlots [0] = "Text Doc 1";
		bookSlots [1] = "Text Doc 2";
		bookSlots [2] = "Text Doc 3";
		bookSlots [3] = "Text Doc 4";
		bookSlots [4] = "Text Doc 5";
		//The rest will be null
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
