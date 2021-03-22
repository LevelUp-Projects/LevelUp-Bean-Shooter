using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text playerStatsText;

    private Player data;

    public void Init(Player data)
    {
        this.data = data;
        ShowStats();
    }
    private void ShowStats()
    {
        playerStatsText.text = $"NAME: {data.GetPlayerName()} \n DMG: {data.GetDamage()}";
    }
}
