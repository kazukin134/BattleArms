﻿using UnityEngine;
using UnityEngine.Networking;

public class ModeUIChanger : MonoBehaviour
{
    bool is_online_ = false;

    [SerializeField]
    GameObject online_ui_ = null;

    [SerializeField]
    GameObject offline_ui_ = null;

    public void ChangeOnlineUI()
    {
        Debug.Log("OK");
        online_ui_.SetActive(true);
        offline_ui_.SetActive(false);
        FindObjectOfType<SoundManager>().PlaySE(4);
    }

    public void ChangeOfflineUI()
    {
        Debug.Log("OK");
        online_ui_.SetActive(false);
        offline_ui_.SetActive(true);
        FindObjectOfType<SoundManager>().PlaySE(4);
    }
}
