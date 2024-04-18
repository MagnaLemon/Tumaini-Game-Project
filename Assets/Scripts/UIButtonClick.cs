using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class UIButtonClick : MonoBehaviour
{
    string ClickedButtonName="A";

    public VideoClip[] videoclips;
    private VideoPlayer videoplayer;
    
    public KeyCode jumpKey; // Variable to store the key for jumping
    public float jumpForce = 10f; // The force applied when jumping
    private Rigidbody rb; // Rigidbody component of the object

    public void CheckLetter()
    {
        ClickedButtonName = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(ClickedButtonName + " is selected");
    }

}

