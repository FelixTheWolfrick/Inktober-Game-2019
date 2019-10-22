using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //Variables
    public float damage = 1;

    public float speed;

    public GameObject effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move Obstacle
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        //Check Location
        if (transform.position.x <= -10.39)
        {
            Destroy(gameObject);
        }
    }

    //Collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //Create particle effect
            Instantiate(effect, transform.position, Quaternion.identity);

            other.GetComponent<PlayerMovement>().health -= damage;
            Debug.Log("Health: " + other.GetComponent<PlayerMovement>().health);
            Destroy(gameObject);
        }
    }
}
