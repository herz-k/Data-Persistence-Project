using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public string playerName;
    public void StartGame()
    {
        if (playerName == null)
        {
            Debug.Log("Type player name!");
        }
        else
        {
            SceneManager.LoadScene(1);
            GameManager.instance.StoreCurrentPlayer(playerName);
        }
    }
    public void CurrentPlayer(string name)
    {
        playerName = name;
        Debug.Log(playerName);
    }
}
