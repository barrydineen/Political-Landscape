using System.Collections.Generic;


public class Question
{
    private List<Answer> _answerList;
    private int _num;
    private string _quest;
    private string _ansLeft;
    private string _ansRight;
    private float _color;


    public Question()
    {
        _num = 0;
        _quest = "";
        _color = .1f;
    }

    public Question(int numVal, string questStr, string ansRight, string ansLeft, float colorVal)
    {
        _answerList = new List<Answer>();
        _num = numVal;
        _quest = questStr;
        _ansLeft = ansLeft;
        _ansRight = ansRight;
        _color = colorVal;
    }

    public List<Answer> answerList { get { return _answerList; } set { _answerList = value; } }
    public int num { get { return _num; } set { _num = value; } }
    public string ques { get { return _quest; } set { _quest = value; } }
    public string ansLeft { get { return _ansLeft; } set { _ansLeft = value; } }
    public string ansRight { get { return _ansRight; } set { _ansRight = value; } }
    public float color { get { return _color; } set { _color = value; } }


}

public class QuestionList
{
    public List<Question> QList = new List<Question>();

    
  
}

public class Answer
{
    
    private float _answer;
    private float _color;

    public Answer(float answerVal, float colorVal)
    {
        _answer = answerVal;
        _color = colorVal;
    }

    public float answer { get { return _answer; } set { _answer = value; } }
    public float color { get { return _color; } set { _color = value; } }

}


