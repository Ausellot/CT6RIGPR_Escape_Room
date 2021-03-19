using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Barrel : MonoBehaviour
{
    public static List<GameObject> itemsObj = new List<GameObject>();
    public int maxItems;
    public GameObject otherObj;
    public string otherScr;
    public static bool destroyEnding = false;

    void Start()
    {
        itemsObj = new List<GameObject>();
    }

    void Update()
    {
        if (itemsObj.Count >= maxItems)
        {
            destroyEnding = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject list = GameObject.FindGameObjectWithTag("EvidenceItems");
        GameObject obj = collision.collider.gameObject;

        while ((collision.collider == true) && gameObject.GetComponent<Barrel>().enabled == true)
        {
            if (obj.tag == list.tag)
            {
                itemsObj.Add(collision.collider.gameObject);
                (otherObj.GetComponent(otherScr) as MonoBehaviour).enabled = false;
                Destroy(collision.collider.gameObject);
            }
            break;
        }
    }

}

