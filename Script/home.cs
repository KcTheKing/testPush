using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class home : MonoBehaviour
{
    
    public void btnHome()
    {
        SceneManager.LoadScene("R");
    }
    public void btnBack()
    {
        Application.Quit();
    }

}
