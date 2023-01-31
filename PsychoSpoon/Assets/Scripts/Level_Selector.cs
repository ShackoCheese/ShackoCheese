using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level_Selector : MonoBehaviour
{
    public Slider volume_slider;
    [SerializeField]
    public Button Level1;
    [SerializeField]
    public Button Level2;
    [SerializeField]
    public Button Level3;
    [SerializeField]
    public Button Level4;
    [SerializeField]
    public Button Level5;
    [SerializeField]
    public Button Level6;
    [SerializeField]
    public Button Level7;
    [SerializeField]
    public Button Level8;
    [SerializeField]
    private Button World2Level1;
    [SerializeField]
    private Button World2Level2;
    [SerializeField]
    private Button World2Level3;
    [SerializeField]
    private Button World2Level4;
    [SerializeField]
    private Button World3Level1;
    [SerializeField]
    private Button World3Level2;
    [SerializeField]
    private Button World3Level3;
    [SerializeField]
    private Button World3Level4;
    [SerializeField]
    private Button World3Level5;
    [SerializeField]
    private Button World3Level6;
    [SerializeField]
    private Button World3Level7;
    [SerializeField]
    private Button World3Level8;
    [SerializeField]
    public int Unlocked_Levels;
    public static int Scene = 0;

    void Awake()
    {
        Unlocked_Levels = PlayerPrefs.GetInt("Unlockedlvl");
    }
    public void Start()
    {
        Level1.interactable = true;
        Level2.interactable = false;
        Level3.interactable = false;
        Level4.interactable = false;
        Level5.interactable = false;
        Level6.interactable = false;
        Level7.interactable = false;
        Level8.interactable = false;
        World2Level1.interactable = false;
        World2Level2.interactable = false;
        World2Level3.interactable = false;
        World2Level4.interactable = false;
        World3Level1.interactable = false;
        World3Level2.interactable = false;
        World3Level3.interactable = false;
        World3Level4.interactable = false;
        World3Level5.interactable = false;
        World3Level6.interactable = false;
        World3Level7.interactable = false;
        World3Level8.interactable = false;
        if(Unlocked_Levels <= Scene + 1)
        {
            Unlocked_Levels = Scene + 1;
        }
    }

    public void Update()
    {
        if(Unlocked_Levels >= 1)
        {
            Level1.interactable = true;
        }

        if(Unlocked_Levels >= 2)
        {
            Level2.interactable = true;
        }

        if(Unlocked_Levels >= 3)
        {
            Level3.interactable = true;
        }

        if(Unlocked_Levels >= 4)
        {
            Level4.interactable = true;
        }

        if(Unlocked_Levels >= 5)
        {
            Level5.interactable = true;
        }

        if(Unlocked_Levels >= 6)
        {
            Level6.interactable = true;
        }

        if(Unlocked_Levels >= 7)
        {
            Level7.interactable = true;
        }

        if(Unlocked_Levels >= 8)
        {
            Level8.interactable = true;
        }

        if(Unlocked_Levels >= 9)
        {
            World2Level1.interactable = true;
        }

        if(Unlocked_Levels >= 10)
        {
            World2Level2.interactable = true;
        }

        if(Unlocked_Levels >= 11)
        {
            World2Level3.interactable = true;
        }

        if(Unlocked_Levels >= 12)
        {
            World2Level4.interactable = true;
        }

        if(Unlocked_Levels >= 13)
        {
            World3Level1.interactable = true;
        }

        if(Unlocked_Levels >= 14)
        {
            World3Level2.interactable = true;
        }

        if(Unlocked_Levels >= 15)
        {
            World3Level3.interactable = true;
        }

        if(Unlocked_Levels >= 16)
        {
            World3Level4.interactable = true;
        }

        if(Unlocked_Levels >= 17)
        {
            World3Level5.interactable = true;
        }

        if(Unlocked_Levels >= 18)
        {
            World3Level6.interactable = true;
        }

        if(Unlocked_Levels >= 19)
        {
            World3Level7.interactable = true;
        }

        if(Unlocked_Levels >= 20)
        {
            World3Level8.interactable = true;
        }
    }

    public void Start_Tutorial()
    {
        SceneManager.LoadScene(1);
    }

    public void StartLevel2()
    {
        SceneManager.LoadScene(2);
    }
    public void StartLevel3()
    {
        SceneManager.LoadScene(3);
    }
    public void StartLevel4()
    {
        SceneManager.LoadScene(4);
    }
    public void StartLevel5()
    {
        SceneManager.LoadScene(5);
    }
    public void StartLevel6()
    {
        SceneManager.LoadScene(6);
    }
    public void StartLevel7()
    {
        SceneManager.LoadScene(7);
    }
    public void StartLevel8()
    {
        SceneManager.LoadScene(8);
    }

    public void StartWorld2Level1()
    {
        SceneManager.LoadScene(9);
    }

    public void StartWorld2Level2()
    {
        SceneManager.LoadScene(10);
    }

    public void StartWorld2Level3()
    {
        SceneManager.LoadScene(11);
    }

    public void StartWorld2Level4()
    {
        SceneManager.LoadScene(12);
    }

    public void StartWorld3Level1()
    {
        SceneManager.LoadScene(13);
    }

    public void StartWorld3Level2()
    {
        SceneManager.LoadScene(14);
    }

    public void StartWorld3Level3()
    {
        SceneManager.LoadScene(15);
    }

    public void StartWorld3Level4()
    {
        SceneManager.LoadScene(16);
    }

    public void StartWorld3Level5()
    {
        SceneManager.LoadScene(17);
    }

    public void StartWorld3Level6()
    {
        SceneManager.LoadScene(18);
    }

    public void StartWorld3Level7()
    {
        SceneManager.LoadScene(19);
    }
    
    public void StartWorld3Level8()
    {
        SceneManager.LoadScene(20);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Set_Volume()
    {
        AudioListener.volume = volume_slider.value;
    }
}
