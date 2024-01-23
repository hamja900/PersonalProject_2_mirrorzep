using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NamePlate : MonoBehaviour
{

    public Text txt;
    public string playerName;

    public InputField playerNameInput;
    private PlayerNameSetting playerNameSetting;

    private void Awake()
    {
        playerNameSetting = playerNameInput.GetComponent<PlayerNameSetting>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NamePlateUp();
    }

    void NamePlateUp()
    {
        playerName = playerNameSetting.PlayerName;
        txt.text = playerName;
    }
}
