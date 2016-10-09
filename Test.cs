using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        QuestionList test = new QuestionList();
        //Question q1 = new Question(2);


        //q1.num = 5;
        //test.QList.Add(q1);

        Debug.Log(test.QList[0].num);
        //Debug.Log(test.predefinedQ1);


    }

    // Update is called once per frame
    void Update () {
	
	}
}
