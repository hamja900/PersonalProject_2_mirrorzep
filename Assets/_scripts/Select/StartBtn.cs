using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class StartBtn : MonoBehaviour
{
    public GameObject selectedPlayer;
    public GameObject characterSelectPopUp;
    public InputField playerNameInput;
    private CharacterSelect characterSelect;
    private PlayerNameSetting playerNameSetting;
    

    public GameObject player1;
    public GameObject player2;
    public Transform spawnPoint;
    public GameObject canvas;
    public GameObject UICanvas;
    public GameObject namePlease;

    private void Awake()
    {
        playerNameSetting = playerNameInput.GetComponent<PlayerNameSetting>();
        characterSelect = selectedPlayer.GetComponent<CharacterSelect>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        if (characterSelect.isPlayer1==true && playerNameInput.text.Length>0)
        {
            GameObject instance = Instantiate(player1, spawnPoint, transform);
            instance.transform.parent = spawnPoint;
            canvas.SetActive(false);
            UICanvas.SetActive(true);
        }
        else if (characterSelect.isPlayer1==false && playerNameInput.text.Length>0)
        {
            GameObject instance = Instantiate(player2, spawnPoint, transform);
            instance.transform.parent = spawnPoint;
            canvas.SetActive(false) ;
            UICanvas.SetActive(true) ;
        }

        else
        {
            namePlease.SetActive(true);
        }
    }
}
