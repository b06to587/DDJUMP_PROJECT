using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleController : MonoBehaviour
{
    Vector2 reduece;
    Color myColor;
    SpriteRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("sss");
        renderer=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        swipeColor();
    }

    //

    public void swipeColor()
    { 
        if(Input.GetMouseButtonDown(0))
        {
             Debug.Log("스와이프 시작");
            renderer.color=Color.black;
 
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("스와이프 종료");
            
            renderer.color=Color.red;
            myColor=renderer.color;
        }
    }

void OnTriggerEnter (Collider other)
{
 Debug.Log("버블충돌 콜라이더");
}
public Color whatColor()
{
    
    return myColor;
}

}
