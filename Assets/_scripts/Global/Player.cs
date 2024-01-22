using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string Name;
    public string PlayerNum;
    
    public Player(string name,string playerNum)
    {
        this.Name = name;
        this.PlayerNum = playerNum;
    }
}
