using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour
{

        float zAxis = 2f;
        Vector3 mousePosition;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var v3 = Input.mousePosition;
        v3.z = 10f;
        v3 = Camera.main.ScreenToWorldPoint(v3);
        transform.position = v3;

        if (Time.timeScale == 1)
        {
            Cursor.visible = false;
        }
        else
        {
            Cursor.visible = true;
        }
    }
}
