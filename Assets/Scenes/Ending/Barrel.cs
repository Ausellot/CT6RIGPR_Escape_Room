using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Barrel : MonoBehaviour
{
    public static List<GameObject> itemsObj = new List<GameObject>();
    public int maxItems;

    void Start()
    {
        itemsObj = new List<GameObject>();
    }

    void Update()
    {
        if(itemsObj.Count >= maxItems)
        {
            SceneManager.LoadScene("DestroyFinalChoice");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
       GameObject list = GameObject.FindGameObjectWithTag("EvidenceItems");
       GameObject obj = collision.collider.gameObject;

       while (collision.collider == true)
        {
            if(obj.tag == list.tag)
            {
                itemsObj.Add(collision.collider.gameObject);
                Destroy(collision.collider.gameObject);
            }
            break;
        }
    }

}
