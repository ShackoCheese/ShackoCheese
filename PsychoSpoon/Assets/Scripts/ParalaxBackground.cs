using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxBackground : MonoBehaviour
{
    public Transform cameraTransform;
    public Vector3 lastCameraPosition;
    public Vector2 offset;
    private float TextureSize;
    public bool infinite;
    void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        Texture2D texture = sprite.texture;
        TextureSize = texture.width / sprite.pixelsPerUnit;
    }
    
    void LateUpdate()
    {
         Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
         transform.position -= new Vector3(deltaMovement.x * offset.x, deltaMovement.y * offset.y);
         lastCameraPosition = cameraTransform.position;

        //if(infinite == true)
        //{
        //    if(cameraTransform.position.x - transform.position.x >= TextureSize)
        //    {
        //        float Offsetposition = (cameraTransform.position.x - transform.position.x) % TextureSize;
        //        transform.position = new Vector3(cameraTransform.position.x + Offsetposition, transform.position.y, 0);
        //    }
        //}
    }
}
