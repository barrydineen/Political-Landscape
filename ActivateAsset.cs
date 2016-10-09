using UnityEngine;
using System.Collections;

public class ActivateAsset : MonoBehaviour {

	public GameObject Mountain;
    public Renderer MountainRenderer;
	

	// Use this for initialization
	void Start () {

        MountainRenderer = Mountain.GetComponent<Renderer>();

        //Mountain.SetActive(true);


	}
	
	// Update is called once per frame
	void Update () {
	
  
	}

    void EnableMountain()
    {
        if (MountainRenderer.enabled == false)
        {
            MountainRenderer.enabled = true;
        }

    }
}
