using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceUI : MonoBehaviour
{
    public Text playerNameTxt;
    // Start is called before the first frame update
    public GameObject attendListUI;

    private void Awake()
    {
        playerNameTxt.text =PlayerPrefs.GetString("PlayerName");
    }
    public void AttendButton()
    {
        attendListUI.SetActive(true);
    }

    public void ClosedUI()
    {
        attendListUI.SetActive(false);
    }
}
