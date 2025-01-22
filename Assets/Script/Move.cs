using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    const float speed = 0.1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        if(Input.GetKey(KeyCode.W)){
            Vector2 pos = new Vector2(transform.position.x, transform.position.y + speed);
            transform.position = pos;
        }else if(Input.GetKey(KeyCode.D)){
            Vector2 pos = new Vector2(transform.position.x, transform.position.y - speed);
            transform.position = pos;
        }
    }
}


