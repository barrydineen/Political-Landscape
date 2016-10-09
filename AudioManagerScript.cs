using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioManagerScript : MonoBehaviour {

    public  List<AudioClip> questionsaudiolist = new List<AudioClip>();

    public List<AudioClip> answeraudiolist = new List<AudioClip>();

    public AudioSource playingClip;
    // Use this for initialization
    void Start () {

        playingClip = GetComponent<AudioSource>();
}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void playQuestionAudio(int i)
    {
        Debug.Log(i);
        Debug.Log(questionsaudiolist[i].name);
        playingClip.clip = questionsaudiolist[i];
        playingClip.Play();
    }
}
