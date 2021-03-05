using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraShot : MonoBehaviour
{
    private bool takePhoto;
    private Sprite newSprite;
    private SpriteRenderer sr;
    private Collider coll;

    public GameObject camDevice;
    public Image m_display;
    public static List<GameObject> itemsObj = new List<GameObject>();
    public int maxItems;

    void Start()
    {
        coll = gameObject.GetComponent<Collider>();
    }
    void Update()
    {
        if (camDevice == null)
        {
            coll.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.K) && camDevice == null)
        {
            if (coll.enabled == true)
            {
                takePhoto = true;
                coll.enabled = false;
            }
        }

        Debug.Log("Collider.Enabled = " + coll.enabled);

        if (itemsObj.Count >= maxItems)
        {
            SceneManager.LoadScene("EvidenceFinalChoice");
        }
    }

    void OnPostRender()
    {
        if (takePhoto)
        {
            Texture2D text = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
            text.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0, false);
            text.Apply();
            newSprite = Sprite.Create(text, new Rect(0, 0, Screen.width, Screen.height), new Vector2(0.5f, 0.5f));
            sr = GetComponent<SpriteRenderer>();
            sr.sprite = newSprite;
            if (m_display != null)
            {
                m_display.sprite = newSprite;

                takePhoto = false;
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        GameObject list = GameObject.FindGameObjectWithTag("EvidenceItems");
        GameObject obj = collision.collider.gameObject;
        string tagIgnore = "Untagged";

        while (collision.collider == true)
        {
            if (obj.tag == tagIgnore)
            {
                Physics.IgnoreCollision(collision.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
            }

            if (obj.tag == list.tag)
            {
                itemsObj.Add(collision.collider.gameObject);
                Destroy(collision.collider.gameObject);
            }

            break;
        }
    }
}
