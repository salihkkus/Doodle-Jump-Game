using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
 public static GameManager Instance {get; private set;}
 public int Score { get => _score;
  set; }

 private int _score; 
    private void Awake()
    {
        Instance = this;
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        Time.timeScale = 0;
    }

}

