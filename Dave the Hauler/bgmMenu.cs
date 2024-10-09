using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmMenu : MonoBehaviour
{
    private static bgmMenu bgmMenuinstance;

    void Awake()
    {
        if (bgmMenuinstance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(transform.gameObject);
            bgmMenuinstance = this;
        }
    }
}
