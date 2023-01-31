using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public Rigidbody2D playerRigidbody2D;
    public Rigidbody2D platformRigidbody2D;
    public bool playerMovementEnabled;
    public bool platformMovementEnabled;
    public bool platfromCameraEnabled;
    public int Activated_Checkpoint_id;
    private Brainpower brainpowerscript;
    public Vector3 offset;
    public float TeleportOffsetY;
    public float TeleportOffsetX;
    public GameObject Player;
    public int spongeCollected;
    public int MaxSponge = 60;
    [SerializeField]
    private GameObject Start_GameObject;
    [SerializeField]
    public GameObject Checkpoint_GameObject;
    public Vector3 Checkpoint;
    public int Score;
    private GameObject Current_Checkpoint;
    [SerializeField]
    public bool Achivement_completegame;
    public bool Achivement_feedback;
    public bool Achivement_spoonflip;
    public bool Achivement_Allsponge;
    public int Deaths;
    
    [SerializeField]
    public int PlayerScore;
    public int pickedup;

    public GameObject moveAble;
    public bool isPlateUsed = false;

    void Start()
    {
        enablePlayerMovement();
        disablePlatformMovement();
        platfromCameraEnabled = false;
        platformRigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
        Activated_Checkpoint_id = 0;
        Checkpoint = Start_GameObject.transform.position;
        Checkpoint = Start_GameObject.transform.position;
        Activated_Checkpoint_id = 0;
        Player.transform.position = Checkpoint;
        Deaths = PlayerPrefs.GetInt("Deaths");
        Deaths -= 1;
        PlayerPrefs.SetInt("Deaths", Deaths);
    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            isPlateUsed = true;
            if(playerMovementEnabled == true){
                disablePlayerMovement();
            }
            else{
                enablePlayerMovement();
                    GameObject varGameObject = GameObject.FindWithTag("MainCamera");
                    varGameObject.GetComponent<FollowPlayer>().setFollowPlayer();
            }
            if(platformMovementEnabled == true){
                disablePlatformMovement();
            }
            else{
                enablePlatformMovement();
                if(platfromCameraEnabled == true)
                {
                    GameObject varGameObject = GameObject.FindWithTag("MainCamera");
                    varGameObject.GetComponent<FollowPlayer>().setFollowPlarform();
                }
            }
        }

        checklevitate();

        if (Input.GetKeyDown("f") || Input.GetKeyDown("r"))
        {
            GameObject Player = GameObject.Find("Player");
            if(Player.GetComponent<Brainpower>().brainpower > 25)
            {
                moveAble.transform.position = new Vector2(Player.transform.position.x + TeleportOffsetX, Player.transform.position.y + TeleportOffsetY);
                Player.GetComponent<Brainpower>().brainpower -= 25;
            }
        }

        //Achivement Management
        if (SceneManager.GetActiveScene().name == "End" && PlayerPrefs.GetInt("Achivement_completegame") == 0)
        {
            PlayerPrefs.SetInt("Achivement_completegame", 1);
            GameObject.Find("Canvas_1").GetComponent<DisplayAchivement>().Achivement_Unlocked("Completed");
        }

        if(playerRigidbody2D.velocity.y == 0 && playerMovementEnabled == false)
        {
            playerRigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
        }

        //Checkpoint position set
        if(Activated_Checkpoint_id == 0)
        {
            Checkpoint = Start_GameObject.transform.position;
        }

        if(Activated_Checkpoint_id == 1)
        {
            Checkpoint = Checkpoint_GameObject.transform.position;
        }

        if(Activated_Checkpoint_id == 2)
        {
            Current_Checkpoint = GameObject.Find("Checkpoint_2");
            Checkpoint = Current_Checkpoint.transform.position;
        }

        if(Activated_Checkpoint_id == 3)
        {
            Current_Checkpoint = GameObject.Find("Checkpoint_3");
            Checkpoint = Current_Checkpoint.transform.position;
        }
    }

    public void disablePlayerMovement()
    {
            GameObject varGameObject = GameObject.FindWithTag("Player");
            varGameObject.GetComponent<PlayerMovement>().enabled = false; 
            playerRigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation & RigidbodyConstraints2D.FreezePositionX & RigidbodyConstraints2D.FreezePositionY;
            playerMovementEnabled = false;
    }

    public void enablePlayerMovement()
    {
            GameObject varGameObject = GameObject.FindWithTag("Player");
            varGameObject.GetComponent<PlayerMovement>().enabled = true;
            playerMovementEnabled = true;
            playerRigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    public void disablePlatformMovement()
    {
            GameObject varGameObject = GameObject.FindWithTag("Platform");
            varGameObject.GetComponent<PlatformMovement>().enabled = false;
            platformMovementEnabled = false;
            platformRigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    public void enablePlatformMovement()
    {
            GameObject varGameObject = GameObject.FindWithTag("Platform");
            varGameObject.GetComponent<PlatformMovement>().enabled = true;
            platformMovementEnabled = true;
            platformRigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    public void enebleJumpBoost()
    {   

        GameObject varGameObject = GameObject.FindWithTag("Player");
        varGameObject.GetComponent<CharacterController2D>().JumpBoostEnabled = true;

    }

    public void disableJumpBoost()
    {
            GameObject varGameObject = GameObject.FindWithTag("Player");
            varGameObject.GetComponent<CharacterController2D>().JumpBoostEnabled = false;
    }

        public void enebleSpeedBoost()
    {   

        GameObject varGameObject = GameObject.FindWithTag("Player");
        varGameObject.GetComponent<CharacterController2D>().SpeedBoostEnabled = true;
    }

    public void disableSpeedBoost()
    {
            GameObject varGameObject = GameObject.FindWithTag("Player");
            varGameObject.GetComponent<CharacterController2D>().SpeedBoostEnabled = false;
    }


    public void Respawn()
    {
        GameObject Player = GameObject.FindWithTag("Player");
        GameObject Start_GameObject = GameObject.Find("Start");
        GameObject Checkpoint_GameObject = GameObject.Find("Checkpoint");
        brainpowerscript = Player.GetComponent<Brainpower>();
        brainpowerscript.brainpower = 100f;
        brainpowerscript.timer = 0f;
        GameObject varGameObject = GameObject.FindWithTag("Player");
        varGameObject.GetComponent<CharacterController2D>().StopAllCoroutines();
        varGameObject.GetComponent<CharacterController2D>().speed = 10f;
        Transform SpbI = Player.transform.GetChild(0);
        SpbI.GetComponent<Animator>().SetInteger("SpbActive", 0);
        disablePlatformMovement();
        enablePlayerMovement();
        Player.transform.position = Checkpoint + offset;
        Deaths += 1;
        PlayerPrefs.SetInt("Deaths", Deaths);

        //Respawn related achivements
        if(PlayerPrefs.GetInt("Deaths") >= 20 && PlayerPrefs.GetInt("Achivement_Death20") == 0)
        {
            PlayerPrefs.SetInt("Achivement_Death20", 1);
            GameObject.Find("Canvas_1").GetComponent<DisplayAchivement>().Achivement_Unlocked("Death20");
            GameObject.Find("NGHelper").GetComponent<NGHelper>().unlockMedal(70040);
        }

        if(PlayerPrefs.GetInt("Deaths") >= 100 && PlayerPrefs.GetInt("Achivement_Death100") == 0)
        {
            PlayerPrefs.SetInt("Achivement_Death100", 1);
            GameObject.Find("Canvas_1").GetComponent<DisplayAchivement>().Achivement_Unlocked("Death100");
            GameObject.Find("NGHelper").GetComponent<NGHelper>().unlockMedal(70041);
        }


    }
    
    public void ScoreUp()
    {
        Score += 1;
        pickedup = 1;
        PlayerScore += 1;
        checkScore();
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("score", PlayerScore);
        PlayerPrefs.SetInt("lvlscore", Score);
        
    }
    void OnEnable()
    {
        PlayerScore = PlayerPrefs.GetInt("score");
        Score = 0;
        PlayerPrefs.SetInt("lvlscore", 0);
    }
    void checklevitate()
    {
        if(Player.GetComponent<Rigidbody2D>().velocity.y != 0 && platformMovementEnabled == true && PlayerPrefs.GetInt("Achivement_Levitate") == 0)
        {
            PlayerPrefs.SetInt("Achivement_Levitate", 1);
            GameObject.Find("Canvas_1").GetComponent<DisplayAchivement>().Achivement_Unlocked("Levitate");
            GameObject.Find("NGHelper").GetComponent<NGHelper>().unlockMedal(70044);
        }
    }
    void checkScore()
    {
        spongeCollected = PlayerPrefs.GetInt("score");
        if (spongeCollected == MaxSponge && PlayerPrefs.GetInt("Achivement_ALLsponge") == 0)
        {
            PlayerPrefs.SetInt("Achivement_ALLsponge", 1);
            GameObject.Find("Canvas_1").GetComponent<DisplayAchivement>().Achivement_Unlocked("Collector");
            GameObject.Find("NGHelper").GetComponent<NGHelper>().unlockMedal(70702);
        }
    }
}