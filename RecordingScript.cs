using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RecordingScript : MonoBehaviour {

    public Text text;
    public Color textColor;
    public Transform head;

    // Use this for initialization
    void Start() {

        text = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
     void Update() {
        transform.position = head.position + new Vector3(0, 0, 1f); 
    }

    public void turnOnRecording(bool state)
    {
        if (state)
        {
            //textColor = new Color ;
            text.color = new Vector4(255, 0, 0, 255);
        }
        else
        {
            text.color = new Vector4(0, 0, 0, 0);
        }
    }
}
