using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OuputName : MonoBehaviour
{
    
    public GameObject player;
    public Text playerNameText;
    public SpriteRenderer playerSprite1;
    public SpriteRenderer playerSprite2;
    private TopDownAimRotation aimRotation;
    private void Awake()
    {
        aimRotation = GetComponent<TopDownAimRotation>();
    }
    void Start()
    {
        

        string playerName = PlayerPrefs.GetString("PlayerName", "NoName");
        int PlayerType = PlayerPrefs.GetInt("PlayerType", 1);

        SetPlayerName(playerName);
        SetPlayerType(PlayerType);        
    }

    private void SetPlayerName(string name)
    {
        playerNameText.text = name;
    }

    private void SetPlayerType(int playerType)
    {

        Transform player1 = player.transform.Find("Player1Sprite");
        Transform player2 = player.transform.Find("Player2Sprite");
        switch (playerType)
        {
            case 1:
                player1.gameObject.SetActive(true);
                player2.gameObject.SetActive(false);
                aimRotation.PlayerRenderer = playerSprite1;
                break;
            case 2:
                player2.gameObject.SetActive(true);
                player1.gameObject.SetActive(false);
                aimRotation.PlayerRenderer = playerSprite2;
                break;
        }
    }

}
