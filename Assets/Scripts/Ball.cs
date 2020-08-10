using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 8f;
        Movement();      
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Movement()
    {
        float speedX = Random.Range(0, 2) == 0 ? -1 : 1;
        float speedY = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().velocity = new Vector3(speed * speedX, speed * speedY, 0f);
    }
}
