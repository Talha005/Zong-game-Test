using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Crouch PlayerCam;
    private MenuManager MM;
    public GameObject Handback,Handhold1, gem1, gem2, Diamond3;
    public Animator Handgetdiamond, Box1diamond, Box2Diamond;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCam = FindObjectOfType<Crouch>();
        MM = FindObjectOfType<MenuManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void spawn()
    {
        //Instantiate(MM.player, MM.spawnPos.transform.position, MM.spawnPos.transform.rotation);      
        MM.player.transform.position = MM.spawnPos.position;
        PlayerPrefs.SetInt("Diamond", 0);
        PlayerCam.Cam.SetActive(false);
        MM.restartbtn.SetActive(false);
        MM.menubtn.SetActive(false);
        
        MM.menuPanel.SetActive(true);
        MM.Alert.Play();
        MM.objCollider.SetActive(true);
        PlayerPrefs.SetInt("spawn", 1);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pickobject")
        {
            Handgetdiamond.enabled = true;   
            Invoke("gethand", 2f);
           
        }
        if (other.gameObject.tag == "object")
        {
            MM.player.SetActive(false);
            MM.restartbtn.SetActive(false);
            MM.menubtn.SetActive(false);
            PlayerPrefs.SetInt("Diamond", 1);
            PlayerCam.Cam.SetActive(false);
            MM.CameraMain.SetActive(true);
            MM.menuPanel.SetActive(true);
            MM.Alert.Play();
        }
        if (other.gameObject.tag == "Box1")
        {
            if (PlayerPrefs.GetInt("Diamond") == 1)
            {
                Diamond3.SetActive(false);
                MM.treasuremusic.Play();
                MM.Chest1.enabled = true;
                MM.particle1.SetActive(true);
                MM.Chest1collider.SetActive(false);
                MM.Chest1text.SetActive(true);
                MM.Chest2Text.SetActive(false);
                MM.Chext3Text.SetActive(false);               
                gem1.SetActive(true);
                Box1diamond.enabled = true;
                Invoke("TextBox", 1f);
            }
        }
        if (other.gameObject.tag == "Box2")
        {
            if (PlayerPrefs.GetInt("Diamond") == 1)
            {
                Diamond3.SetActive(false);
                MM.treasuremusic.Play();
                MM.Chest2.enabled = true;
                MM.particle2.SetActive(true);
                MM.Chest2collider.SetActive(false);                
                MM.Chest1text.SetActive(false);
                MM.Chest2Text.SetActive(true);
                MM.Chext3Text.SetActive(false);
                gem2.SetActive(true);
                Box2Diamond.enabled = true;
              
                Invoke("TextBox", 1f);
            }
        }
        if (other.gameObject.tag == "Box3")
        {
            MM.treasuremusic.Play();
            MM.Chest3.enabled = true;
            MM.chest3collider.SetActive(false);
            MM.Chest1text.SetActive(false);
            MM.Chest2Text.SetActive(false);
            MM.Chext3Text.SetActive(true);
            MM.player.SetActive(false);
            MM.CameraMain.SetActive(true);
            MM.player.SetActive(false);
            Invoke("spawn", 2f);
            Invoke("TextBox", 1f);
        }
    }

    void TextBox()
    {
        MM.Chest1text.SetActive(false);
        MM.Chest2Text.SetActive(false);
        MM.Chext3Text.SetActive(false);
        gem1.SetActive(false);
        gem2.SetActive(false);
    }
    void gethand()
    {
        MM.gemMain.SetActive(false);
       
    }
    void UIbox()
    {
        MM.player.SetActive(false);
        MM.restartbtn.SetActive(false);
        MM.menubtn.SetActive(false);
        PlayerPrefs.SetInt("Diamond", 1);
        PlayerCam.Cam.SetActive(false);
        MM.CameraMain.SetActive(true);
        MM.menuPanel.SetActive(true);
        MM.Alert.Play();
    }
}
            