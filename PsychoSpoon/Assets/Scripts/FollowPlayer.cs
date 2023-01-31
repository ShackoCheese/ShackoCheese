using UnityEngine;

public class FollowPlayer : MonoBehaviour
{   
    public GameObject followed;
    public Vector3 offset;

    void Start()
    {
        followed = GameObject.FindWithTag("Player");
    }
    
    void Update()
    {
        transform.position = followed.transform.position + offset;
    }

    public void setFollowPlayer()
    {
        followed = GameObject.FindWithTag("Player");
    }

    public void setFollowPlarform()
    {
        followed = GameObject.FindWithTag("Platform");
    }
}