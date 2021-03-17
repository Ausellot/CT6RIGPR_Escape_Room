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
    private Collider shotCollider;
    private Camera cam;

    public GameObject camDevice;
    public Image m_display;
    public static List<GameObject> itemsObj = new List<GameObject>();
    public int maxItems;
    public bool tookPhoto;

    void Start()
    {
        itemsObj = new List<GameObject>();
        tookPhoto = false;
        shotCollider = gameObject.GetComponent<Collider>();
        cam = gameObject.GetComponent<Camera>();
    }

    void Update()
    {
        if(camDevice == null)
        {
            shotCollider.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.K) && camDevice == null)
        {
            shotCollider.enabled = true;
            Physics.IgnoreLayerCollision(0, 11, false);
            if (shotCollider.enabled == true)
            {
                GameObject.Find("FireBarrel").GetComponent<Barrel>().enabled = false;
                tookPhoto = true;
                takePhoto = true;
            }
        }

       // Debug.Log("Collider.Enabled = " + shotCollider.enabled);

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

    void OnCollisionEnter(Collision col)
    {
        GameObject list = GameObject.FindGameObjectWithTag("EvidenceItems");
        GameObject obj = col.collider.gameObject;

        while (col.collider == true)
        {
            Physics.IgnoreLayerCollision(0, 11, true);
            if ((obj.tag == list.tag) && tookPhoto == true && shotCollider.enabled == true && (list.transform.gameObject.tag != "Untagged"))
            {
                itemsObj.Add(col.gameObject);
                obj.gameObject.tag = "Untagged";
                shotCollider.enabled = false;
                tookPhoto = false;
            }
            break;
        }
    }
}
