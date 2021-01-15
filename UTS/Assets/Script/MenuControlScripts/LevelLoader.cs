using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour
{



    public Animator Transition;
    public float transitionTime = 1f;

    

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex));

    }



    IEnumerator LoadLevel(int levelIndex)
    {
        //Play animation
        Transition.SetTrigger("Start");

        //Wait
        yield return new WaitForSeconds(transitionTime);


        //Load scene
        SceneManager.LoadScene(levelIndex);
    }
}
