using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed;
    public bool isRight;
    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if(isRight)
        {
            transform.Translate(0f, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0f);
        }
        else
        {
            transform.Translate(0f, Input.GetAxis("Vertical 2") * speed * Time.deltaTime, 0f);
        }
    }
}
