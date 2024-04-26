using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static moveBar;

public class ManageGame : MonoBehaviour
{

    public Transform spawnItem, min,max;
    public GameObject item;
    public Text txtScore,txtOver;
    float Score,spawnRate=0.1f,rate=1f;
    public static bool isStart;
    public GameObject[] panel;
    public Text txtLevel,txtLevelOver;
    int level = 1;
    public GameObject[] sound;
    public AudioSource music;
    private void Awake()
    {
        Time.timeScale = 0;
    }

    void Start()
    {
        spawning();
    }

    // Update is called once per frame
    void Update()
    {
        if (isStart)
        {
            txtScore.text = Score.ToString("0");
            txtOver.text = Score.ToString("0");
            Score += 0.01f;
        }
        txtLevel.text = level.ToString();
        txtLevelOver.text = level.ToString();
        if (Score >= 0 && Score<20)
        {
            level = 1;
            spawnRate = 0.1f;
            rate = 1f;
            moveBar.speed = 2f;
        }
        if (Score > 20 && Score<70)
        {
            level = 2;
            spawnRate = 0.01f;
            rate = 0.5f;
            moveBar.speed = 2.5f;
        } 
        if (Score > 70 && Score<140)
        {
            level = 3;
            spawnRate = 0.01f;
            rate = 0.5f;
            moveBar.speed = 3f;
        }   
        if (Score > 140 && Score<240)
        {
            level = 4;
            spawnRate = 0.01f;
            rate = 0.5f;
            moveBar.speed = 3.5f;
        }   
        if (Score > 240 && Score<350)
        {
            level = 5;
            spawnRate = 0.01f;
            rate = 0.5f;
            moveBar.speed = 4.5f;
        }    
        if (Score > 350 && Score<460)
        {
            level = 6;
            spawnRate = 0.01f;
            rate = 0.5f;
            moveBar.speed = 5.5f;
        }    
        if (Score > 460 && Score<570)
        {
            level = 7;
            spawnRate = 0.01f;
            rate = 0.5f;
            moveBar.speed = 6.5f;
        }
        if (Score > 570 && Score<680)
        {
            level = 8;
            moveBar.speed = 7.5f;
        }

    }

    void spawning()
    {
        InvokeRepeating("spawnGame", spawnRate, rate);
    }

    void spawnGame()
    {
        Vector3 pos = spawnItem.position;
        pos.x = Random.Range(min.position.x,max.position.x);
        Instantiate(item, pos, Quaternion.identity);
    }

    public void GameLose()
    {
        panel[2].SetActive(true);
    }

    public void btnPause()
    {
        isStart = false;
        Time.timeScale = 0;
        panel[1].SetActive(true);
    }
    public void btnPlay()
    {
        Time.timeScale = 1;
        isStart = true;
        foreach (var i in panel)
        {
            i.SetActive(false);
        }
    }
    public void btnRestart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("R");
    }
    public void btnHome()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("T");
    }

    public void btnSound()
    {
        music.Stop();
        sound[0].SetActive(false); sound[1].SetActive(true);
    } 
    public void btnSoundMute()
    {
        music.Play();
        sound[1].SetActive(false); sound[0].SetActive(true);
    }
}
