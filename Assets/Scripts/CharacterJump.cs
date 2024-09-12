using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    private float jumpAmount = 50f;
    public CircleCollider2D circleCollider;
    private float x, y;


    // Start is called before the first frame update
    void Start()
    {
        myRigidbody.gravityScale = 0;

    }

    // Update is called once per frame  
    void Update()
    {
       
        gameObject.transform.position = new Vector2(x,y);
        x += 0.01f;
        y += 0.01f;

        //transform.position += new Vector3(2 * Time.deltaTime, 0, 0);



    }



}
