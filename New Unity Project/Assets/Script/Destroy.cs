using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger");
        GameManager.instance.InsertQueue(collision.gameObject);
        var obj = GameManager.instance.GetQueue();
        obj.transform.position = GameManager.instance.RandomPostion();
    }
}
