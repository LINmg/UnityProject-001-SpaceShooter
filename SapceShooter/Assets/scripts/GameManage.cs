using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour {
    //private GameObject startUI;
    private GameObject mainUI;
    private GameObject endUI;
    private GUIText scoreText;
    private int score;
    // Use this for initialization
    void Start () {
        //startUI = GameObject.Find("StartUI");
        mainUI = GameObject.Find("MainUI");
        endUI = GameObject.Find("EndUI");
        mainUI.SetActive(true);
        endUI.SetActive(false);
        scoreText = GameObject.Find("score").GetComponent<GUIText>();
        score = 0;
        scoreText.text = "Score : " + score;
    }
    void Update()
    {
        if (endUI.activeSelf&&Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("game");
        }
    }
    public void AddScore(int v)
    {
        score += v;
        scoreText.text = "Score : " + score;
    }
    public void End()
    {
        endUI.SetActive(true);
    }
}
