using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

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


    public void LeaderBoardMenu()
    {
        SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
