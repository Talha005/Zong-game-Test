using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    
    public AudioSource BGmusic, iconmusic, selectmusic, treasuremusic;
    public GameObject menuPanel, weaponpanel, pointspanel, instrumentspanel;
    
    // Start is called before the first frame update
    void Start()
    {
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
}
