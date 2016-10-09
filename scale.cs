using UnityEngine;
using System.Collections;

public class scale : MonoBehaviour {

	float currentScale = 1f;
	bool growing = false;
	//bool shrinking = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//currentScale = transform.localScale.y;

		if (currentScale >= 1) {
			growing = false;
			//shrinking = true;
		}
		else if (currentScale <= 0) {
			growing = true;
			//shrinking = false;
		}

		if (growing) {
			transform.localScale += new Vector3 (0, 0, 0.01f);
			currentScale += 0.01f;
		} else {
			transform.localScale -= new Vector3 (0, 0, 0.01f);
			currentScale -= 0.01f;
		}
	
	}
}
