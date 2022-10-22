using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    public AudioSource BGmusic, iconmusic, selectmusic, treasuremusic, Alert;
    public GameObject menuPanel, weaponpanel, pointspanel, instrumentspanel;
    public GameObject player, spawnPos, CameraMain;
    private Crouch PlayerCam;
    
    public Animator Chest1, Chest2, Chest3;
    public GameObject particle1, particle2, Diamondimg;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCam = FindObjectOfType<Crouch>();
        BGmusic.Play();
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
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "pickobject")
        {
            PlayerPrefs.SetInt("Diamond", 1);
            PlayerCam.Cam.SetActive(false);
            CameraMain.SetActive(true);
        }
       
    }

    public void Exit()
    {
        CameraMain.SetActive(false);
        player.SetActive(true);
        menuPanel.SetActive(false);
    }
}
