using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CharacterSelect : MonoBehaviour
{
    public GameObject CharacterSelectPopUp;
    public GameObject SelectPlayer1Btn;
    public UnityEngine.UI.Image UiImage;


    public bool isPlayer1 = true;
    public Sprite player1;
    public Sprite player2;

    private void Awake()
    {
    }
    private void Start()
    {

    }

    private void Update()
    {
        if (isPlayer1)
        {
            UiImage.sprite = player1;
        }
        else
        {
            UiImage.sprite = player2;
        }
      
    }
    public void SelectPopUp()
    {
        CharacterSelectPopUp.SetActive(true);
    }


}
