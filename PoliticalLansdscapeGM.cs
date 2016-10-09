using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PoliticalLansdscapeGM : MonoBehaviour {
    public riseScript risescript;

    public List<GameObject> objectList = new List<GameObject>();

    public List<GameObject> answerBalls = new List<GameObject>();
    public QuestionList questionlist = new QuestionList();

    public List<Vector3> oriObjectVecPos = new List<Vector3>();

    public GameObject leftAnswerPanel;
    public GameObject rightAnswerPanel;

    public int currentQuestionNum = 0;

    public GameObject answerBall1;
    public GameObject answerBall2;
    public GameObject answerBall3;
    public GameObject answerBall4;
    public GameObject answerBall5;


    public GameObject ControllerLeft;
    public GameObject ControllerRight;

    private TerrainChangerScript terrainchangescript;
    public AudioManagerScript audiomanagerscript;
    //public SteamVR_GazeTracker

    public GameObject dummy;


    void Awake()
    {
        answerBalls.Add(answerBall1);
        answerBalls.Add(answerBall2);
        answerBalls.Add(answerBall3);
        answerBalls.Add(answerBall4);
        answerBalls.Add(answerBall5);

        //Construct Q&A
        //Add Question , 
        questionlist.QList.Add(new Question(0, "how are you doing", "I am optimistic about VR", "I am pessimistic about VR", .1f));
        //Add Answers 1-5 for Question #
        questionlist.QList[0].answerList.Add(new Answer(0f, .1f)); //Q1 Answer 1
        questionlist.QList[0].answerList.Add(new Answer(1f, .2f)); //Q1 Answer 2
        questionlist.QList[0].answerList.Add(new Answer(2f, .3f)); //Q1 Answer 3
        questionlist.QList[0].answerList.Add(new Answer(3f, .4f)); //Q1 Answer 4
        questionlist.QList[0].answerList.Add(new Answer(4f, .5f)); //Q1 Answer 5

        questionlist.QList.Add(new Question(1, "are you hungry", "Government regulation of business is necessary to protect the public interest", "Government regulation of business usually does more harm than good", .2f));
        //Add Answers 1-5 for Question #
        questionlist.QList[1].answerList.Add(new Answer(0f, .6f)); //Q2 Answer 1
        questionlist.QList[1].answerList.Add(new Answer(1f, .7f)); //Q2 Answer 2
        questionlist.QList[1].answerList.Add(new Answer(2f, .8f)); //Q2 Answer 3
        questionlist.QList[1].answerList.Add(new Answer(3f, .9f)); //Q2 Answer 4
        questionlist.QList[1].answerList.Add(new Answer(4f, .10f)); //Q2 Answer 5

        questionlist.QList.Add(new Question(2, "red or blue", "Poor people have hard lives because government benefits don't go far enough to help them live decently ", "Poor people today have it easy because they can get government benefits without doing anything in return", .2f));
        //Add Answers 1-5 for Question #
        questionlist.QList[2].answerList.Add(new Answer(0f, .6f)); //Q2 Answer 1
        questionlist.QList[2].answerList.Add(new Answer(1f, .7f)); //Q2 Answer 2
        questionlist.QList[2].answerList.Add(new Answer(2f, .8f)); //Q2 Answer 3
        questionlist.QList[2].answerList.Add(new Answer(3f, .9f)); //Q2 Answer 4
        questionlist.QList[2].answerList.Add(new Answer(4f, .10f)); //Q2 Answer 5

        questionlist.QList.Add(new Question(3, "Yeahhhhhhhhhhh yeahhhhhhh or Noooooooooooooo nooooooooo", "The government should do more to help needy Americans, even if it means going deeper into debt", "The government today can't afford to do much more to help the needy", .2f));
        //Add Answers 1-5 for Question #
        questionlist.QList[3].answerList.Add(new Answer(0f, .6f)); //Q2 Answer 1
        questionlist.QList[3].answerList.Add(new Answer(1f, .7f)); //Q2 Answer 2
        questionlist.QList[3].answerList.Add(new Answer(2f, .8f)); //Q2 Answer 3
        questionlist.QList[3].answerList.Add(new Answer(3f, .9f)); //Q2 Answer 4
        questionlist.QList[3].answerList.Add(new Answer(4f, .10f)); //Q2 Answer 5

        questionlist.QList.Add(new Question(4, "Yeahhhhhhhhhhh yeahhhhhhh or Noooooooooooooo nooooooooo", "Racial discrimination is the main reason why many black people can't get ahead these days", "Blacks who can't get ahead in this country are mostly responsible for their own condition", .2f));
        //Add Answers 1-5 for Question #
        questionlist.QList[4].answerList.Add(new Answer(0f, .6f)); //Q2 Answer 1
        questionlist.QList[4].answerList.Add(new Answer(1f, .7f)); //Q2 Answer 2
        questionlist.QList[4].answerList.Add(new Answer(2f, .8f)); //Q2 Answer 3
        questionlist.QList[4].answerList.Add(new Answer(3f, .9f)); //Q2 Answer 4
        questionlist.QList[4].answerList.Add(new Answer(4f, .10f)); //Q2 Answer 5

        questionlist.QList.Add(new Question(5, "Yeahhhhhhhhhhh yeahhhhhhh or Noooooooooooooo nooooooooo", "Immigrants today strengthen our country because of their hard work and talents", "Immigrants today are a burden on our country because they take our jobs, housing and health care", .2f));
        //Add Answers 1-5 for Question #
        questionlist.QList[5].answerList.Add(new Answer(0f, .6f)); //Q2 Answer 1
        questionlist.QList[5].answerList.Add(new Answer(1f, .7f)); //Q2 Answer 2
        questionlist.QList[5].answerList.Add(new Answer(2f, .8f)); //Q2 Answer 3
        questionlist.QList[5].answerList.Add(new Answer(3f, .9f)); //Q2 Answer 4
        questionlist.QList[5].answerList.Add(new Answer(4f, .10f)); //Q2 Answer 5

        questionlist.QList.Add(new Question(6, "Yeahhhhhhhhhhh yeahhhhhhh or Noooooooooooooo nooooooooo", "Good diplomacy is the best way to ensure peace", "The best way to ensure peace is through military strength", .2f));
        //Add Answers 1-5 for Question #
        questionlist.QList[6].answerList.Add(new Answer(0f, .6f)); //Q2 Answer 1
        questionlist.QList[6].answerList.Add(new Answer(1f, .7f)); //Q2 Answer 2
        questionlist.QList[6].answerList.Add(new Answer(2f, .8f)); //Q2 Answer 3
        questionlist.QList[6].answerList.Add(new Answer(3f, .9f)); //Q2 Answer 4
        questionlist.QList[6].answerList.Add(new Answer(4f, .10f)); //Q2 Answer 5

        questionlist.QList.Add(new Question(7, "Yeahhhhhhhhhhh yeahhhhhhh or Noooooooooooooo nooooooooo", "Corporations make too much profit", "Most corporations make a fair and reasonable amount of profit", .2f));
        //Add Answers 1-5 for Question #
        questionlist.QList[7].answerList.Add(new Answer(0f, .6f)); //Q2 Answer 1
        questionlist.QList[7].answerList.Add(new Answer(1f, .7f)); //Q2 Answer 2
        questionlist.QList[7].answerList.Add(new Answer(2f, .8f)); //Q2 Answer 3
        questionlist.QList[7].answerList.Add(new Answer(3f, .9f)); //Q2 Answer 4
        questionlist.QList[7].answerList.Add(new Answer(4f, .10f)); //Q2 Answer 5

        questionlist.QList.Add(new Question(8, "Yeahhhhhhhhhhh yeahhhhhhh or Noooooooooooooo nooooooooo", "Stricter environmental laws and regulations are worth the cost", "Stricter environmental laws and regulations cost too many jobs and hurt the economy", .2f));
        //Add Answers 1-5 for Question #
        questionlist.QList[8].answerList.Add(new Answer(0f, .6f)); //Q2 Answer 1
        questionlist.QList[8].answerList.Add(new Answer(1f, .7f)); //Q2 Answer 2
        questionlist.QList[8].answerList.Add(new Answer(2f, .8f)); //Q2 Answer 3
        questionlist.QList[8].answerList.Add(new Answer(3f, .9f)); //Q2 Answer 4
        questionlist.QList[8].answerList.Add(new Answer(4f, .10f)); //Q2 Answer 5

        questionlist.QList.Add(new Question(9, "Yeahhhhhhhhhhh yeahhhhhhh or Noooooooooooooo nooooooooo", "Homosexuality should be accepted by society", "Homosexuality should be discouraged", .2f));
        //Add Answers 1-5 for Question #
        questionlist.QList[9].answerList.Add(new Answer(0f, .6f)); //Q2 Answer 1
        questionlist.QList[9].answerList.Add(new Answer(1f, .7f)); //Q2 Answer 2
        questionlist.QList[9].answerList.Add(new Answer(2f, .8f)); //Q2 Answer 3
        questionlist.QList[9].answerList.Add(new Answer(3f, .9f)); //Q2 Answer 4
        questionlist.QList[9].answerList.Add(new Answer(4f, .10f)); //Q2 Answer 5


        terrainchangescript = GetComponent<TerrainChangerScript>();
        audiomanagerscript = GetComponent<AudioManagerScript>();

        risescript = GameObject.Find("rise").GetComponent<riseScript>();


    }


    // Use this for initialization
    void Start() {
        foreach (GameObject go in objectList)
        {
            oriObjectVecPos.Add(go.transform.position);
            //  Instantiate(dummy, go.transform.position + new Vector3(0, 0, .1f), Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            UpdateQuestion(currentQuestionNum);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            HideOnGrab(answerBall1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ShowAll();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetPosition();
        }

    }

    public void HideOnGrab(GameObject grabbedObject)
    {
        foreach (GameObject go in objectList)
        {
            if (go != grabbedObject && ((go.GetComponent<MeshRenderer>() != null)))
            {
                go.GetComponent<MeshRenderer>().enabled = false;
            }

            if(go.GetComponent<Canvas>() && go.tag == "ui")
            {
                go.gameObject.SetActive(false);
            }

        }

    }

    public void ResetPosition()
    {
        ShowAll();
        for(int i = 0; i< objectList.Count; i++)
        {
            objectList[i].transform.position = oriObjectVecPos[i];
        }
    }

    public void ShowAll()
    {
        foreach (GameObject go in objectList)
        {
            if (go.GetComponent<Rigidbody>() != null)
            {
                go.GetComponent<Rigidbody>().useGravity = false;
                go.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }
            if (go.GetComponent<MeshRenderer>() != null) 
                go.GetComponent<MeshRenderer>().enabled = true;
            if (go.GetComponent<Canvas>() && go.tag == "ui")
            {
                go.gameObject.SetActive(true);
            }

        }
    }

    //importance, colorval
    public void changeterrain(int importance, int color_val1)
    {
        terrainchangescript.changeTerrain(importance, color_val1);
    }

    public void changeterrain(GameObject zone, int importance, int color_val1)
    {
        terrainchangescript.changeTerrain(zone, importance, color_val1);
    }

    public void UpdateQuestion(int questNum)
    {
        int numQuestions = questionlist.QList.Count;
        int ansIndex = 0;

        Debug.Log(questionlist.QList[questNum].ansLeft);


        //Play Question Audio
        //audiomanagerscript.playQuestionAudio(questNum);

        //Update Answer Descriptions
        leftAnswerPanel.GetComponentInChildren<Text>().text = questionlist.QList[questNum].ansLeft;


        rightAnswerPanel.GetComponentInChildren<Text>().text = questionlist.QList[questNum].ansRight;
        //Update AnswerBall Properties
        foreach (GameObject ball in answerBalls){
            //get reference of the ball's answer script
            AnswerBallScript answerballscript = ball.GetComponent<AnswerBallScript>();

            answerballscript.targetZone = "Zone" + (questNum).ToString();
            Debug.Log(questionlist.QList[questNum].answerList[ansIndex].answer);
            Debug.Log(questionlist.QList[questNum].answerList[ansIndex].color);
            //Debug.Log(questionlist.QList[questNum].answerList);
            //Debug.Log(questionlist.QList[questNum].color);
            //Debug.Log(questionlist.QList[questNum].ques);



            //call the script's 
            answerballscript.UpdateBallQuestion(questionlist.QList[questNum].answerList[ansIndex]);

            //callresetPositionScript
            answerballscript.ResetBallPosition();
            ansIndex++;
        }

        

        //increment question number one each UpdateQuestion
        ++currentQuestionNum;
        ansIndex = 0;

        if (currentQuestionNum == 9) {
            leftAnswerPanel.SetActive(false);
            rightAnswerPanel.SetActive(false);
            risescript.state = true;
        }
            
    }


}
