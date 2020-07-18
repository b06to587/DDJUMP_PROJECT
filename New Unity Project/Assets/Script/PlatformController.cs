using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
   
    public GameObject bubble;
    SpriteRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer=GetComponent<SpriteRenderer>();
        renderer.color=Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //방울을 줄어들게한다
    public void reduceBubble(Collision2D collision)
    {
        Debug.Log("충돌");
    }

    //충돌체크
    private void OnCollisionEnter2D(Collision2D Collision)
    {
        Debug.Log("충돌2");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
         Vector3 reduce=new Vector3(0.5f,0.5f,0.5f);
         Debug.Log(bubble.GetComponent<BubbleController>().whatColor());
       if(renderer.color !=bubble.GetComponent<BubbleController>().whatColor() )
       {
           Debug.Log("색깔다름");
            other.transform.localScale-=reduce;
       }else
        {
            Debug.Log("색같음");
        }
       

         
       
    }
}
