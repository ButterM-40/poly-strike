using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleButtons : MonoBehaviour
{
    public AudioSource audioData;
    public GameObject SelectCanvas;
    // Start is called before the first frame update
    public void Play()
    {
        audioData.Play();
        this.transform.parent.gameObject.SetActive(false);
        //GameObject.Find("Select Mode").SetActive(false);
        SelectCanvas.SetActive(true);
    }

    // Update is called once per frame
    public void Exit()
    {
        //audioData.Play();  
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
