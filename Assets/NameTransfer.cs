using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NameTransfer : MonoBehaviour
{
    public static string playerName;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreName()
    {
        playerName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = playerName;
    }

    public void SavePlayerName()
    {
        PlayerPrefs.SetString("playerName", playerName);
    }

}
