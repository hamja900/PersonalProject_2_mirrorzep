using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBtn : MonoBehaviour
{
    public GameObject selectPopUp;
    public GameObject SelectedPlayer;
    private CharacterSelect characterSelect;

    private void Awake()
    {
        characterSelect = SelectedPlayer.GetComponent<CharacterSelect>();
    }

    public void SelectPlayer1()
    {
        characterSelect.isPlayer1 = true;
        ClosePopUp();
    }
    public void SelectPlayer2()
    {
        characterSelect.isPlayer1 = false;
        ClosePopUp();
    }

    private void ClosePopUp()
    {
        selectPopUp.SetActive(false);
    }
}
