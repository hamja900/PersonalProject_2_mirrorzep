using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNameSetting : MonoBehaviour
{
    public InputField NameSetting;
    public string PlayerName = null;

    private void Awake()
    {
        PlayerName = NameSetting.GetComponent<InputField>().text;
    }

    public void Update()
    {
        if(PlayerName != null)
        {
            DesideName();
        }

    }

    public void DesideName()
    {
        PlayerName = NameSetting.text;

    }
}
