using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tesztkamera : MonoBehaviour
{
    public bool border;

    public float minX;
    public float minY;
    public float maxX;
    public float maxY;

    public void Update()
    {
        if(border == true)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x,minX,maxX), Mathf.Clamp(transform.position.y,minY,maxY), transform.position.z);
        }

//        if(GetComponent<Renderer>().isVisible)
        {
            
        }
    }
}
