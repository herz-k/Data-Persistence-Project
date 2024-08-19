using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    public string playerName;
    public TextMeshProUGUI warningText;
    public void StartGame()
    {
        if (playerName == "")
        {
            StartCoroutine(WarningText());
        }
        else
        {
            SceneManager.LoadScene(1);
            GameManager.instance.StoreCurrentPlayer(playerName);
        }
    }
    IEnumerator WarningText()
    {
        warningText.gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        warningText.gameObject.SetActive(false);
    }
    public void CurrentPlayer(string name)
    {
        playerName = name;
        Debug.Log(playerName);
    }
}
