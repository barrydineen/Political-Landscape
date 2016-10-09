using UnityEngine;
using System.Collections;

public class SceneInitialize : MonoBehaviour {

	public GameObject[] goMountain = new GameObject[8];
    public GameObject[] goHill = new GameObject[8];
    public GameObject[] goFlat = new GameObject[8];
    public GameObject[] goLake = new GameObject[8];
    public GameObject[] goHole = new GameObject[8];
    //public Renderer MountainRenderer;

    public int[] RotationChoice = new int[]{0,90,180,270};
	// Use this for initialization

	void Start () {

		int howManyThings = RotationChoice.Length;
		//Instantiate (Mountain, new Vector3 (0, 0, 0), Quaternion.Euler(-90,0,0));
		//int myRandomIndex = Random.Range(0, howManyThings);
		//int result = RotationChoice [myRandomIndex];

		foreach (GameObject mountain in goMountain) {

            Renderer MountainRenderer = mountain.GetComponent<Renderer>();
            MountainRenderer.enabled = false;
			int myRandomIndex = Random.Range (0, howManyThings);
			int result = RotationChoice [myRandomIndex];
            if(!mountain.name.Contains("Flat"))
			    mountain.transform.rotation = Quaternion.Euler (-90, 0, result);
            mountain.transform.parent.localScale -=  new Vector3(0, mountain.transform.parent.localScale.y, 0);
            //mountain.SetActive (false);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
