using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    Rigidbody2D playerRigidbody;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float inputX = Input.GetAxis("Horizontal");

        float fallSpeed = playerRigidbody.velocity.y;
        //Rigidbody의 중력 영향을 받는 속도를 fallSpeed에 대입

        Vector2 velocity = new Vector2(inputX, 0);

        velocity = velocity * speed;

        velocity.y = fallSpeed;

        playerRigidbody.velocity = velocity;

    }

}
