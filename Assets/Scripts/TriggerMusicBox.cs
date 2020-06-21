using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerMusicBox : MonoBehaviour
{
    public PlayableDirector Timeline;
    public GameObject Door;
    public bool doorIsOpening;
    public bool isPlaying;

    // Update is called once per frame
    void Update()
    {
        if (doorIsOpening == true)
        {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 5);
        }
        if (Door.transform.position.y > 3f)
        {
            doorIsOpening = false;
        }
    }

    private void OnMouseDown()
    {
        doorIsOpening = true;
        isPlaying = true;
        Timeline.Play();
    }
}
