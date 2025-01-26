using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField, Header("移動速度")]
    private float speed = 0.1f;

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
        Vector2 current_pos = transform.position;

        if(Input.GetKey(KeyCode.W)){
            current_pos.y += speed;
        }else if(Input.GetKey(KeyCode.S)){
            current_pos.y -= speed;
        }else if(Input.GetKey(KeyCode.A)){
            current_pos.x -= speed;
        }else if(Input.GetKey(KeyCode.D)){
            current_pos.x += speed;
        }

        transform.position = current_pos;
    }
}


