using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayback : MonoBehaviour
{
    public VideoClip[] videoclips;
    private VideoPlayer videoplayer;
    private int videoClipIndex;
    
    private void Awake()
    {
        videoplayer = GetComponent<VideoPlayer>();
    }

    void Start()
    {
        videoplayer.clip = videoclips[0];
    }

    public void playNext()
    {
        videoClipIndex++;
        if (videoClipIndex >= videoclips.Length)
        {
            videoClipIndex = videoClipIndex % videoclips.Length;
        }
        videoplayer.clip = videoclips[videoClipIndex];
    }

    public void playPrevious()
    {
        videoClipIndex--;
        if (videoClipIndex < 0)
        {
            videoClipIndex = videoclips.Length + videoClipIndex;
        }
        videoplayer.clip = videoclips[videoClipIndex];
    }
}
