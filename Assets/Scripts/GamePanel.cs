using System;
using System.Collections.Generic;
using RenderHeads.Media.AVProVideo;
using UnityEngine;
using UnityEngine.UI;

public class GamePanel : MonoBehaviour
{
    public Button mapBtn;
    public GameObject mapPanel;
    private MediaPlayer m_MediaPlayer;

    private void Awake()
    {
        m_MediaPlayer = FindObjectOfType<MediaPlayer>();
        m_MediaPlayer.Loop = false;
        mapBtn.onClick.AddListener(() => { mapPanel.SetActive(true); });
    }
}