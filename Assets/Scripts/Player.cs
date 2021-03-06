using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private string playerName;
    private int damage;
    public float movementSpeed = 5;
    public float mouseSensitivity = 2;

    public string GetPlayerName()
    {
        return playerName;
    }
    public void SetPlayerName(string playerName)
    {
        this.playerName = playerName;
    }
    public int GetDamage()
    {
        return damage;
    }
    public void SetDamage(int amount)
    {
        damage += amount;
    }
}
