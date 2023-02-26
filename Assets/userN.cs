using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class userN : MonoBehaviour
{
    public string Text;
    public void LoadPlayerName()
        {
            PlayerPrefs.SetString("playerName", Text);
        }
}
