using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRampSupport : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    public string inputAxis; 
    private float verticalInput;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Test");
        rigidbody = GetComponent<Rigidbody2D>();
       // transform.Translate(5,0,0);
    }
    private void Update()
    {
        verticalInput = Input.GetAxis(inputAxis);
    }

    // Update is called once per frame
    void FixedUpdate()
    { /*if the player presses up arrow,
        we move the square up and vise versa*/
        if (!GameOver.IsGameOver)
        {

        rigidbody.velocity = new Vector2(0, verticalInput * moveSpeed);
        }
    }
}
