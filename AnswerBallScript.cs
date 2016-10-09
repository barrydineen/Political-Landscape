using UnityEngine;
using System.Collections;
// System;
using VRTK;

public class AnswerBallScript : MonoBehaviour
{
    public PoliticalLansdscapeGM gameMaster;
    public RecordingScript recordingscript;

    public int answerOrbNumber;
    public float scaleFactor = 1.0f;
    public string targetZone = "Zone1";

    public AudioSource audioclip;
    public string question = "";
    public float colorVal = 0f;
    public float answerVal = 0f;

    public int importance = 1;

    public bool isScaling = false;

    public GameObject grabbingController = null;
    public GameObject ScaleHandle;

    //public float oriPos = 

    VRTK_InteractableObject ball;

    void Awake()
    {
        answerOrbNumber = 0;
        ball = GetComponent<VRTK_InteractableObject>();
        //Debug.Log(targetZone);
        gameMaster = GameObject.Find("GameManager").GetComponent<PoliticalLansdscapeGM>();
        recordingscript = GameObject.Find("recpanel").GetComponent<RecordingScript>();
    }

    // Use this for initialization
    void Start()
    {

        //When object grabbed call this Method
        ball.InteractableObjectGrabbed += OnGrab;
        ball.InteractableObjectUngrabbed += OnUnGrab;

        ball.InteractableObjectUsed += OnTouchPadPressed;

        //ball.InteractableObjectUsed += OnTriggerPull;
        //ball.InteractableObjectUnused += OnTriggerRelease;


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGrab(object sender, InteractableObjectEventArgs e)
    {
        //throw new System.NotImplementedException();
        Debug.Log("Grabbed");
        grabbingController = e.interactingObject.gameObject;
        //e.interactingObject...

        //show handle
        //ScaleHandle.SetActive(true);

        gameMaster.HideOnGrab(gameObject);
        //play rec audio
        //recordingscript.turnOnRecording(true);

    }

    private void OnUnGrab(object sender, InteractableObjectEventArgs e)
    {
        gameObject.GetComponent<Rigidbody>().useGravity = true;
        //CheckTrigger();
        //  throw new System.NotImplementedException();
        //e.interactingObject...
        grabbingController = null;

        Debug.Log("ans#: " + answerOrbNumber);
        Debug.Log("ansval: "+answerVal);
        Debug.Log("importance: " + importance);


        importance = Random.Range(0,5);
        Debug.Log(importance);
        //recordingscript.turnOnRecording(false);
        //hide handle
        //ScaleHandle.SetActive(false);
    }

    private void OnTriggerPull(object sender, InteractableObjectEventArgs e)
    {
        Debug.Log("Trigger");
        isScaling = true;
        while (isScaling && (grabbingController != e.interactingObject.gameObject))
        {
            Debug.Log("scaling");
        }
    }

    private void OnTriggerRelease(object sender, InteractableObjectEventArgs e)
    {
        Debug.Log("Trigger Release");
        isScaling = false;
    }

    private void OnTouchPadPressed(object sender, InteractableObjectEventArgs e)
    {
        if (e.interactingObject.GetComponent<ControllerInteractionEventArgs>().touchpadAngle < 30 || e.interactingObject.GetComponent<ControllerInteractionEventArgs>().touchpadAngle > 290)
        {
            Debug.Log("pressed up");
        }

    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        //if (other.gameObject.name == targetZone)
        if (other.gameObject.name.Contains("Zone"))
        {
            Debug.Log(other.gameObject.name);
            //HideBall();



            //FIRST PARAM IS THE ZONE# ,2ND PARAM IS THE MATERIAL PROPERTY

            //Debug.Log(Convert.ToInt32(targetZone.Remove(0, 4)));


            //importance (1-5),answerorb# affects color (1-5)
            gameMaster.changeterrain(other.gameObject, importance, answerOrbNumber);
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
            //gameMaster.changeterrain(Convert.ToInt32(targetZone.Remove(0,4)),0);
            //Destroy(gameObject);
            //Debug.Log("HitTarget");
            gameMaster.UpdateQuestion(gameMaster.currentQuestionNum);
            gameMaster.ResetPosition();

        }
        if(other.gameObject.name.Contains("Plane"))
        {
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            gameMaster.ResetPosition();
            //ReturnBallLocation();
            Debug.Log("Not Target: "+other.gameObject.name);

        }

    }




    //if object is grabbed, and other controller(right) trigger is pressed, start to scale the ball
    public void ResizeBallMethod()
    {
        Debug.Log("Resizing");
    }

    public void PlaySound(string name)
    {
        if (name == "grow")
        {
            //play sound clip1 
        }
        if (name == "shrink")
        {


        }
        if (name == "audio clip")
        {
            audioclip.Play();
        }


        Debug.Log("Playin sound");
    }

    public void ResetBallPosition()
    {

    }

    public void UpdateBallQuestion(Answer answer)
    {
        answerOrbNumber = (int)answer.answer;
        answerVal = answer.answer;
        colorVal = answer.color;
    }


    public void ReturnBallLocation()
    {
        Debug.Log("Returning Ball");
    }

    public void HideBall()
    {
        gameObject.SetActive(false);
    }


    public void OnGaze()
    {
        if (audioclip != null)
            PlaySound("audioclip");
    }

}
