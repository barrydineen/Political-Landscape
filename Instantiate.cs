using UnityEngine;
using System.Collections;

public class Instantiate : MonoBehaviour {

	public GameObject Mountain;

	public int[] RotationChoice = new int[]{0,90,180,270};

	// Use this for initialization
	void Start () {

		int howManyThings = RotationChoice.Length;
		//Instantiate (Mountain, new Vector3 (0, 0, 0), Quaternion.Euler(-90,0,0));
		int myRandomIndex = Random.Range(0, howManyThings);

		//int result = RotationChoice [myRandomIndex];

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
