using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    public InputField inputField;
    public GameObject masege;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject PlayerSelect;

    // Start is called before the first frame update

    public void StartButton()
    {
        string playerName = inputField.text;


        if (playerName.Length >= 2 && 10 >= playerName.Length)
        {
            PlayerPrefs.SetString("PlayerName", playerName);

            SceneManager.LoadScene("MainScene");
        }
        else
        {
            masege.SetActive(true);
            Debug.Log("2 ~ 10 글자로 입력해주세요.");
        }

    }

    public void SelectButton()
    {
        PlayerSelect.SetActive(true);
    }

    public void SelectPlayer1()
    {
        Player1.SetActive(true);
        Player2.SetActive(false);
        PlayerSelect.SetActive(false);

        PlayerPrefs.SetInt("PlayerType", 1);

    }
    public void SelectPlayer2()
    {
        Player2.SetActive(true);
        Player1.SetActive(false);
        PlayerSelect.SetActive(false);

        PlayerPrefs.SetInt("PlayerType", 2);
    }
}
