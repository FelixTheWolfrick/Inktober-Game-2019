using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBK : MonoBehaviour
{
    //Variables
    public float speed;
    public float xEnd;
    public float xStart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move BK
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        //Respawn once reaches end of screen

        if (transform.position.x < xEnd)
        {
            Vector2 pos = new Vector2(xStart, transform.position.y);
            transform.position = pos;
        }
    }
}
