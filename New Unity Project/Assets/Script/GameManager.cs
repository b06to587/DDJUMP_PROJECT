using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject m_goPrefab = null;
    public GameObject player;
    public Queue<GameObject> m_queue = new Queue<GameObject>();
    private int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        for(int i = 0; i < 20; i++)
        {
            GameObject t_object = Instantiate(m_goPrefab, Vector3.zero, Quaternion.identity);
            m_queue.Enqueue(t_object);
            t_object.SetActive(false);
        }

        StartCoroutine(CreateObstacle());
    }

    public Vector3 RandomPostion()
    {
       float xPos = Random.Range(-8, 8);
       float yPos = Random.Range(player.transform.position.y, player.transform.position.y - 20f);

        return new Vector3(xPos, yPos);
    }

    IEnumerator CreateObstacle()
    {
        while (i < 10)
        {
            //Debug.Log("start create");
            yield return null;
            GameObject obj = GetQueue();
            obj.transform.position = RandomPostion();
            i++;
        }
    }

    public void InsertQueue(GameObject obj)
    {
        m_queue.Enqueue(obj);
        obj.SetActive(false);
    }

    public GameObject GetQueue()
    {
        GameObject obj = m_queue.Dequeue();
        obj.SetActive(true);
        return obj;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
