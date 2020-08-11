using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sides : MonoBehaviour
{
    public bool isRight;
    //private int leftScore;
    //private int rightScore;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Ball" && isRight)
        {
            GameController.instace.ScoreUpdate("left");
        }
        else
        {
            GameController.instace.ScoreUpdate("right");
        }
    }
}
