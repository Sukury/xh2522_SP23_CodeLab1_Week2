using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int score = 0;
    public int currentLevel = 0;
    public int targetScore = 3;

    private void Awake()
    {
        if (Instance==null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score==targetScore)
        {
            currentLevel++;
            targetScore = targetScore * 3;
            SceneManager.LoadScene(currentLevel);
        }
    }
}
