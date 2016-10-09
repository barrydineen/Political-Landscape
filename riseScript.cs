using UnityEngine;
using System.Collections;

public class riseScript : MonoBehaviour {
    public Transform t;
    public bool state;
	// Use this for initialization
	void Start () {
        state = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (state)
        {
            StartCoroutine("Rise");
        }
    }

    IEnumerator Rise()
    {
        for (float f = 1f; f >= 0; f -= 0.1f)
        {
            //Debug.Log("i");
            t.position += new Vector3(0,.01f,0);
            yield return new WaitForSeconds(10.0f);
        }
        state = false;
    }
}
