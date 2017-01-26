using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSelector : MonoBehaviour
{
    SpriteRenderer renderer;
    void Start()
    {
        renderer = gameObject.GetComponent<SpriteRenderer>();
    }
    void Update ()
    {
        //Debug.Log("Update!");
        if(Input.GetKeyDown(KeyCode.R))
        {
            renderer.color = Color.red;
        }
        //if (Input.GetKeyUp(KeyCode.R))
        //{
        //    gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        //}
        if (Input.GetKeyDown(KeyCode.G))
        {
            renderer.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            renderer.color = Color.blue;
        }
    }
}
