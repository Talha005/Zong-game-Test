using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    
    public AudioSource BGmusic, iconmusic, selectmusic, treasuremusic;
    public GameObject menuPanel, weaponpanel, pointspanel, instrumentspanel;
    public GameObject player, spawnPos, CameraMain;
    public Crouch PlayerCam;
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

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "pickobject")
        {
            PlayerPrefs.SetInt("Diamond", 1);
            PlayerCam.Cam.SetActive(false);
            CameraMain.SetActive(true);
        }
        if (other.gameObject.tag == "Box3")
        {
            Instantiate(player, spawnPos.transform.position,spawnPos.transform.rotation);
        }
    }
}
