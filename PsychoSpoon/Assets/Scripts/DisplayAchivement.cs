using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayAchivement : MonoBehaviour
{
    public Achivement Collector;
    public Achivement Death20;
    public Achivement Death100;
    public Achivement Completed;
    public Achivement Spoonflip;
    public Achivement FirstLevelDeath;
    public Achivement Levitate;
    public Achivement UnlimitedPower;
    public Achivement Gamer;
    
    public Image img;
    public TextMeshProUGUI name;
    public TextMeshProUGUI description;

    public Image AchivementUnlocked;

    void Start()
    {
        AchivementUnlocked.gameObject.SetActive(false);
    }

    public void Achivement_Unlocked(string Achivementname)
    {
        if(Achivementname == "Collector")
        {
            AchivementUnlocked.gameObject.SetActive(true);
            img.sprite = Collector.Image;
            name.text = Collector.name;
            description.text = Collector.description;
        }

        else if(Achivementname == "Death20")
        {
            AchivementUnlocked.gameObject.SetActive(true);
            img.sprite = Death20.Image;
            name.text = Death20.name;
            description.text = Death20.description;
        }

        else if(Achivementname == "Death100")
        {
            AchivementUnlocked.gameObject.SetActive(true);
            img.sprite = Death100.Image;
            name.text = Death100.name;
            description.text = Death100.description;
        }

        else if(Achivementname == "Completed")
        {
            AchivementUnlocked.gameObject.SetActive(true);
            img.sprite = Completed.Image;
            name.text = Completed.name;
            description.text = Completed.description;
        }

        else if(Achivementname == "Spoonflip")
        {
            AchivementUnlocked.gameObject.SetActive(true);
            img.sprite = Spoonflip.Image;
            name.text = Spoonflip.name;
            description.text = Spoonflip.description;
        }

        else if(Achivementname == "FirstLevelDeath")
        {
            AchivementUnlocked.gameObject.SetActive(true);
            img.sprite = FirstLevelDeath.Image;
            name.text = FirstLevelDeath.name;
            description.text = FirstLevelDeath.description;
        }

        else if(Achivementname == "Levitate")
        {
            AchivementUnlocked.gameObject.SetActive(true);
            img.sprite = Levitate.Image;
            name.text = Levitate.name;
            description.text = Levitate.description;
        }

        else if(Achivementname == "UnlimitedPower")
        {
            AchivementUnlocked.gameObject.SetActive(true);
            img.sprite = UnlimitedPower.Image;
            name.text = UnlimitedPower.name;
            description.text = UnlimitedPower.description;
        }

        else if(Achivementname == "Gamer")
        {
            AchivementUnlocked.gameObject.SetActive(true);
            img.sprite = Gamer.Image;
            name.text = Gamer.name;
            description.text = Gamer.description;
        }

        StartCoroutine(Display());
    }

    IEnumerator Display()
    {
        AchivementUnlocked.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        AchivementUnlocked.gameObject.SetActive(false);
    }
}
