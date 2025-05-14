using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapPanel : MonoBehaviour
{
    public Button closeBtn;
    public static List<string> mapList = new List<string>();
    private AudioSource audioSource;
    private Dictionary<string, string> clouds;

    void Awake()
    {
        closeBtn.onClick.AddListener(() => { gameObject.SetActive(false); });
        audioSource = GetComponent<AudioSource>();
        clouds = new Dictionary<string, string>();
        clouds["101"] = "101";
        clouds["101-201"] = "101-201";
        clouds["101-201-301"] = "101";
        clouds["101-201-302"] = "101";
        clouds["101-201-401"] = "101";
        clouds["101-201-301-403"] = "101";
        clouds["101-201-302-403"] = "101";
        clouds["101-202"] = "101-202";
        clouds["101-202-301"] = "101";
    }

    private void OnEnable()
    {
        if (audioSource)
            audioSource.Play();
    }

    private void OnDisable()
    {
        if (audioSource)
            audioSource.Stop();
    }

    public static void LoadedMap(string scene)
    {
        mapList.Add(scene);
    }
}