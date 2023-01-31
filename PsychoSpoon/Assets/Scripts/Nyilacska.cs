using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nyilacska : MonoBehaviour
{
    public GameObject tanyer;
    public GameObject player;
    public GameObject kamera;

    void Update()
    {
        Vector3 screenCenter = new Vector3(kamera.transform.position.x, kamera.transform.position.y, 0) / 2;

        Vector3 targetPositionScreenPoint = Camera.main.WorldToScreenPoint(tanyer.transform.position);

        Vector3 dir = (targetPositionScreenPoint - screenCenter).normalized;

        float angle = Mathf.Atan2(dir.y,dir.x);

        transform.position = screenCenter + new Vector3(Mathf.Cos(angle) * screenCenter.x * 0.9f, Mathf.Sin(angle) * screenCenter.y * 0.9f, 0);

        transform.rotation = Quaternion.Euler(0, 0, angle * Mathf.Rad2Deg);
    }
}
