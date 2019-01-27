using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

    private bool played = false;
    
	// Update is called once per frame
	public void PlayAudio () {
        if (!played)
        {
            played = true;
            this.GetComponent<AudioSource>().Play();
        }
	}
}
