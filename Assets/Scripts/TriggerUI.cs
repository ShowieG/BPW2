using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerUI : MonoBehaviour
{
    public GameObject UIObject;
    public TriggerMusicBox musicBox;

    // Start is called before the first frame update
    void Start()
    {
        UIObject.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && musicBox.isPlaying == false)
        {
            UIObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        UIObject.SetActive(false);
    }

    private void Update()
    {
        if (musicBox.isPlaying == true)
        {
            UIObject.SetActive(false);
        }
    }
}
