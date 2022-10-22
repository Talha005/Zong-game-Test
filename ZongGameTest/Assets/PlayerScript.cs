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
        }
        if (other.gameObject.tag == "Box2")
        {
            MM.treasuremusic.Play();
            MM.Chest2.enabled = true;
        }
        if (other.gameObject.tag == "Box3")
        {
            MM.treasuremusic.Play();
            MM.Chest3.enabled = true;
            Invoke("spawn", 2f);
        }
    }
}
            