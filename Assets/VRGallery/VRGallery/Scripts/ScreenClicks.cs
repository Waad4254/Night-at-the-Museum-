using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ScreenClicks : MonoBehaviour {

    public VideoControler videoControler;

public void ScreenClick()
    {
        Debug.Log("EnterScreenClicks");
        videoControler.Clicked();
    }
}
