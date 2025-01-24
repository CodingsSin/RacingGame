using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    private Button btnStart;
    private GameObject lobby;

    private bool firstStart = true;
    
    
    void Start()
    {
        btnStart = GameObject.Find("BtnStart").GetComponent<Button>();
        btnStart.onClick.AddListener(GameStart);
        
        lobby = GameObject.Find("Lobby");
    }

    void GameStart()
    {
        if (firstStart)
        {
            GameObject.Find("TxtTitle").GetComponent<TMP_Text>().text = "Game Over";
            btnStart.transform.GetChild(0).GetComponent<TMP_Text>().text = "Restart";
            firstStart = false;
        }
        
        lobby.SetActive(false);
        GameManager.instance.StartGame();
    }

    public void GameOver()
    {
        StopAllCoroutines();
        lobby.SetActive(true);
    }
}
