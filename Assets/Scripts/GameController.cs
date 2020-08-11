using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public Text rightScoreText;
    public Text leftScoreText;
    public int rightScore;
    public int leftScore;
    public static GameController instace;
    // Start is called before the first frame update
    void Start()
    {
        instace = this;
        rightScore = 0;
        leftScore = 0;
        CreateBall();
    }

    // Update is called once per frame
    void Update()
    { 
    }

    public void ScoreUpdate(string side)
    {
        Destroy(GameObject.FindWithTag("Ball"));
        if(side == "right")
        {
            rightScore++;
            rightScoreText.text = rightScore.ToString();
        }
        else if(side == "left")
        {
            leftScore++;
            leftScoreText.text = leftScore.ToString();
        }
        CreateBall();
    }

    private void CreateBall()
    {
        GameObject newBall = Instantiate(ball);
        newBall.transform.position = transform.position + new Vector3(0f, 0f, 0f);
    }
}
