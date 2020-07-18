using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    BoxCollider2D boxCollider2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        if(boxCollider2D == null)
        {
            boxCollider2D = GetComponent<BoxCollider2D>();
        }
        //StartCoroutine(DestoryObstacle());
    }

    IEnumerator DestoryObstacle()
    {
        yield return new WaitForSeconds(0.5f);
        Debug.Log("destroy obstacle");
        GameManager.instance.InsertQueue(gameObject);
    }
}
