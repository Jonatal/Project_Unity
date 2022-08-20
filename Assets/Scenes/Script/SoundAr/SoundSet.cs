using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;

public class SoundSet : MonoBehaviour
{
    // Start is called before the first frame update
    // public AudioSource src;
    // public AudioClip sound1, sound2, sound3;

    // public void ButtonUtama(){
    //     src.clip = sound1;
    //     src.play();
    // }

    // [SerializeField] Image soundOnIcon;
    // [SerializeField] Image soundOffIcon;
    // private bool muted = false;


    // void Start()
    // {
    //     if(!PlayerPrefs.HasKey("muted"))
    //     {
    //         PlayerPrefs.SetInt("muted", 0);
    //         Load();
    //     }
    //     else
    //     {
    //         Load();
    //     }

    //     UpdateButtonIcon();
    //     AudioListener.pause = muted;
    // }

    // public void OnButtonPlay()
    // {
    //     if (muted == false){
    //         muted = true;
    //         AudioListener.pause = true;
    //     }
    //     else
    //     {
    //         muted = false;
    //         AudioListener.pause = false;
    //     }

    //     Save();
    //     UpdateButtonIcon();
    // }

    // private void UpdateButtonIcon()
    // {
    //     if(muted == false)
    //     {
    //         soundOnIcon.enabled = true;
    //         soundOffIcon.enabled = false;
    //     }
    //     else
    //     {
    //         soundOnIcon.enabled = false;
    //         soundOffIcon.enabled = true;
    //     }
    // }

    // private void Load()
    // {
    //     muted = PlayerPrefs.GetInt("muted") == 1;
    // }

    // private void Save()
    // {
    //     PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    // }

    public AudioSource src;

    void Start()
    {

    }

    void update()
    {

    }

    public void OnPlay()
    {
        src.Play();
        Debug.Log("Play");
    }

    public void OffPlay()
    {
        src.Stop();
        Debug.Log("stop");
    }
}
