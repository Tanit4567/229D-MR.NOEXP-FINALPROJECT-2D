using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Collider2D c;
        if (!GetComponent<Collider2D>())
        {
            c = gameObject.AddComponent<BoxCollider2D>();
        }
        else
        {
            c = GetComponent<Collider2D>();
        }
        c.isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Text txt;
        txt = GameObject.Find("/Canvas/Text").GetComponent<Text>();
        GameManager.nScore++;
        txt.text = "" + GameManager.nScore;
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}