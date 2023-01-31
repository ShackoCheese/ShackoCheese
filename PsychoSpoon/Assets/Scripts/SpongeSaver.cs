using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpongeSaver : MonoBehaviour
{
    public GameObject Sponge1;
    public PickupableItem p1;
    public GameObject Sponge2;
    public PickupableItem p2;
    public GameObject Sponge3;
    public PickupableItem p3;
    public int s1;
    public int s2;
    public int s3;
    public int CurrentLevel;

    
    
    //MLehívja a lementett értékeket
    void OnEnable()
    {
        s1 = PlayerPrefs.GetInt("lvl" +CurrentLevel + "s1");
        s2 = PlayerPrefs.GetInt("lvl" +CurrentLevel + "s2");
        s3 = PlayerPrefs.GetInt("lvl" +CurrentLevel + "s3");
        //Deaktiválja a pickupebleket ha már felvették egyszer
        if(s1 == 1)
        {
            Sponge1.SetActive(false);
        }
        
        if(s2 == 1)
        {
            Sponge2.SetActive(false);
        }
        
        if(s3 == 1)
        {
            Sponge3.SetActive(false);
        }
    }
    void Awake()
    {   
        p1 = Sponge1.GetComponent<PickupableItem>();
        p2 = Sponge2.GetComponent<PickupableItem>();
        p3 = Sponge3.GetComponent<PickupableItem>();
    }

    public void Update()
    {
        if(p1.pickedup == 1)
        {
            s1 = 1;
            PlayerPrefs.SetInt("lvl" + CurrentLevel + "s1", s1);
        } 
        
        if(p2.pickedup == 1)
        {
            s2 = 1;
            PlayerPrefs.SetInt("lvl" + CurrentLevel + "s2", s2);
        } 
        
        if(p3.pickedup == 1)
        {
            s3 = 1;
            PlayerPrefs.SetInt("lvl" + CurrentLevel + "s3", s3);
        } 
    }
    
}
