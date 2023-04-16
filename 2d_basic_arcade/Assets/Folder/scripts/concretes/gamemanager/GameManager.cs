using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int score;
   public static GameManager Instance { get; private set; }

    public event System.Action<int> OnScoreChange;
    private void Awake()
    {
        SingletonThisGameObject();
    }

    internal void ExitGame()
    {
        Application.Quit();
    }

    private void SingletonThisGameObject()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);

        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void IncreaseScore()
    {
        score += 10;
        OnScoreChange?.Invoke(score);
    }
    public void StartGame()
    {
        score = 0;
        Time.timeScale = 1f;
        StartCoroutine(StartGameAsync());
    }

    private IEnumerator StartGameAsync()
    {
        yield return SceneManager.LoadSceneAsync("Game");
    }

    public void ReturnMenu()
    {


        StartCoroutine(ReturnMenuAsync());
    }
    public IEnumerator ReturnMenuAsync()
    {

        yield return SceneManager.LoadSceneAsync("Start");
    }

}
