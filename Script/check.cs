using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ManageGame;

public class check : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "over")
        {
            ManageGame.isStart = false;
            Time.timeScale = 0f;
            FindAnyObjectByType<ManageGame>().GameLose();
        }
    }
}
