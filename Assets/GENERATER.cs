using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GENERATER : MonoBehaviour
{
    public int life;
    public GameObject ballPrefab;
    public Text textGameOver;
    private int score;
    private float leftTime;
    private Text textScore;
    private Text textLife;
    private Text textTimer;
    private bool inGame;
    public Text textClear;
    // Start is called before the first frame update
    private AudioSource audioSource;

    public AudioClip overSound;
    public AudioClip killSound;
    public AudioClip clearSound;
    void Start()
    {
        life = 9;
        textGameOver.enabled = false;
        textClear.enabled = false;
        score = 0;
        leftTime = 120;
        audioSource = gameObject.AddComponent<AudioSource>();
        textScore = GameObject.Find("Score").GetComponent<Text>();
        textLife = GameObject.Find("BallLife").GetComponent<Text>();
        textTimer = GameObject.Find("TimerText").GetComponent<Text>();
        SetScoreText(score);
        SetLifeText(life);
        inGame = true;
    }
    private void SetScoreText(int score)
    {
        textScore.text = "Score:" + score.ToString();
    }
    private void SetLifeText(int life)
    {
        textLife.text = "Ball:" + life.ToString();
    }
    public void AddScore(int point)
    {
        if (inGame)
        {

            score += point;
            SetScoreText(score);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (inGame)
        {
            leftTime -= Time.deltaTime;
            textTimer.text = "Time:" + (leftTime > 0f ? leftTime.ToString("0.00"):"0.00")+"seconds";
            if(leftTime < 0f)
            {
                audioSource.PlayOneShot(overSound);
                textGameOver.enabled = true;
                inGame = false;
            }
        }
        GameObject ballObj = GameObject.Find("Ball");
        if (ballObj == null)
        {
            --life;
            SetLifeText(life);
            if (life > 0)
            {
                audioSource.PlayOneShot(killSound);
                GameObject newBall = Instantiate(ballPrefab);
                newBall.name = ballPrefab.name;
            }
            else
            {
                life = 0;
                audioSource.PlayOneShot(overSound);
                textGameOver.enabled = true;
                inGame = false;
            }
        }
        GameObject targetObj = GameObject.FindWithTag("A");
        if(targetObj == null)
        {
            audioSource.PlayOneShot(clearSound);
            textClear.enabled = true;
            inGame = false;
        }
    }
    
}
