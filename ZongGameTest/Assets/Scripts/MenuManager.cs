using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public AudioSource BGmusic, iconmusic, selectmusic, treasuremusic, Alert;
    public GameObject menuPanel, weaponpanel, pointspanel, instrumentspanel, restartbtn, menubtn;
    public GameObject player, CameraMain, gemMain;
    public Transform spawnPos;
    private Crouch PlayerCam;
    private PlayerScript PS;
    public GameObject objCollider, Chest1collider, Chest2collider,  chest3collider;
    public Animator Chest1, Chest2, Chest3, diamond1, diamond2;
    public GameObject particle1, particle2, Diamondimg;
    public GameObject Chest1text, Chest2Text, Chext3Text;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCam = FindObjectOfType<Crouch>();
        PS = FindObjectOfType<PlayerScript>();
        BGmusic.Play();
        PlayerPrefs.SetInt("Diamond", 0);
        //Instantiate(player, spawnPos.transform.position, spawnPos.transform.rotation);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btnClickSound()
    {
        iconmusic.Play();
    }
     public void instrumentAdd()
    {
        if(PlayerPrefs.GetInt("Diamond") == 1)
        {
            Diamondimg.SetActive(true);
           
        }
    }

     public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
        selectmusic.Play();

    }
    public void Menu()
    {
        player.SetActive(false);        
        PlayerCam.Cam.SetActive(false);
        CameraMain.SetActive(true);
        menuPanel.SetActive(true);
        Alert.Play();
    }
    public void Exit()
    {
        //if (PlayerPrefs.GetInt("spawn") == 0)
        //{
            PlayerCam.Cam.SetActive(true);
            CameraMain.SetActive(false);
            player.SetActive(true);
            menuPanel.SetActive(false);
            restartbtn.SetActive(true);
            menubtn.SetActive(true);
            PS.Handback.SetActive(false);
            PS.Handhold1.SetActive(true);
            objCollider.SetActive(false);
       // }
        
        
    }
}
