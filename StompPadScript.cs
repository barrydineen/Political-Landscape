using UnityEngine;
using System.Collections;

public class StompPadScript : MonoBehaviour
{
    public float boundary =.5f;
    public Transform headset;
    public string activeState = "inactive";
    //public AudioClip activeClip;

    private AudioSource source;

    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if (activeState == "active")
            ActivatePad();
        if (activeState == "inactive")
            source.Stop();
    }

    public void ActivatePad()
    {
        source.Play();
        //while(activeState == "active")
        //{
        //    if((headset.transform.position.x  - transform.position.x) < boundary && headset.transform.position.z - transform.position.z < boundary)
        //    {
        //        activeState = "inactive";
        //        Debug.Log("inactive");

        //        Debug.Log(headset.transform.position);
        //        Debug.Log(transform.position);
        //    }
        //}
    }

    private void OnCollisionEnter(Collision hit)
    {
        if (activeState == "active")
        {
            if (hit.gameObject.name == "headsetGameObject")
            {
                activeState = "inactive";
                source.Stop();
            }
        }
        
    }



    private void OnCollisionExit(Collision hit)
    {
          
    }


}
