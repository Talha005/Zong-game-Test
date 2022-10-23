using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Crouch PlayerCam;
    private MenuManager MM;
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
        Instantiate(MM.player, MM.spawnPos.transform.position, MM.spawnPos.transform.rotation);
        MM.player.SetActive(false);
        PlayerPrefs.SetInt("Diamond", 0);
        PlayerCam.Cam.SetActive(false);
        MM.CameraMain.SetActive(true);
        MM.menuPanel.SetActive(true);
        MM.Alert.Play();
        MM.objCollider.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pickobject")
        {
            MM.player.SetActive(false);
            PlayerPrefs.SetInt("Diamond", 1);
            PlayerCam.Cam.SetActive(false);
            MM.CameraMain.SetActive(true);
            MM.menuPanel.SetActive(true);
            MM.Alert.Play();            
        }
        if(other.gameObject.tag == "Box1")
        {
            MM.treasuremusic.Play();
            MM.Chest1.enabled = true;
            MM.particle1.SetActive(true);
            MM.Chest1collider.SetActive(false);
            MM.Chest1text.SetActive(true);
            MM.diamond1.enabled = true;
            Invoke("TextBox", 2f);
        }
        if (other.gameObject.tag == "Box2")
        {
            MM.treasuremusic.Play();
            MM.Chest2.enabled = true;
            MM.particle2.SetActive(true);
            MM.Chest2collider.SetActive(false);
            MM.Chest2Text.SetActive(true);
            MM.diamond2.enabled = true;
            Invoke("TextBox", 2f);
        }
        if (other.gameObject.tag == "Box3")
        {
            MM.treasuremusic.Play();
            MM.Chest3.enabled = true;
            MM.chest3collider.SetActive(false);
            MM.Chest2Text.SetActive(true);
            Invoke("spawn", 2f);
            Invoke("TextBox", 2f);
        }
    }

    void TextBox()
    {
        MM.Chest1text.SetActive(false);
        MM.Chest2Text.SetActive(false);
        MM.Chest2Text.SetActive(false);
    }
}
            