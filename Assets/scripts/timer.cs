using UnityEngine;
using System.Collections;
using TMPro;

public class timer : MonoBehaviour
{
    public float startingTime = 60f; // 1 minute
    public TextMeshProUGUI timerHUD;
    public GameObject Player;
    

    public string gameOverTrigger = "GameOver";
    public float delayBefore = 2f;

    private float curTime;
    private bool isGameOver;

    void Start()
    {
        curTime = startingTime;
        UpdateText();
    }

    void Update()
    {
        if (isGameOver)
            return;

        curTime -= Time.deltaTime;

        if (curTime <= 0f)
        {
            curTime = 0f;
            UpdateText();
           
            Destroy(Player);
            
            return;
        }

        UpdateText();
    }

    private void UpdateText()
    {
        int minutes = Mathf.FloorToInt(curTime / 60f);
        int seconds = Mathf.FloorToInt(curTime % 60f);
        timerHUD.text = $"{minutes:00}:{seconds:00}";
    }

}