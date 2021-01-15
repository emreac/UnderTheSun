using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuControl : MonoBehaviour
{

    public Text HStext;
    void Start()
    {
        HStext.text = " " + PlayerPrefs.GetInt("highscore");

        

    }

    void Update()
    {
    }



    public void LoadScene(string SceneName)
    {

        SceneManager.LoadScene(SceneName);

    }

}
