using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float speed = 5f;
    private Rigidbody rigidbody;

    Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void FixedUpdate()
    {
       

        movePlayer();

        
    }

    void movePlayer()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        movement = new Vector3(h, 0, v);
        rigidbody.AddForce(movement * speed);
    }
}
