using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float score;
    public int scoreInteger;
    public float movementSpeed;
    public DeathMenu deathMenu;
    public Text HSText;

    private bool movingLeft;
    private float rotationSpeed;

    public Text scoreText;


    private void Start()
    {
        score = 0;
        movingLeft = true;
        HSText.text = "S  C  O  R  E: " + PlayerPrefs.GetInt("highscore");


    }

    private void Update()
    {
        
        score +=  Time.deltaTime;
        scoreInteger = Mathf.RoundToInt(score) * 100;

        transform.Translate(Vector3.down * Time.deltaTime * movementSpeed);

        //Player Movement
        if (Input.GetMouseButtonDown(0))
        {

            rotationSpeed = .5f;
            movingLeft = !movingLeft;

        }

        if (Input.GetMouseButton(0))
        {
            rotationSpeed += .5f * Time.deltaTime;
        }


        if (movingLeft)
            transform.Rotate(0, 0, rotationSpeed);
        else
        {
            transform.Rotate(0, 0, -rotationSpeed);
        }

   
    }


    private void FixedUpdate()
    {
        scoreText.GetComponent < Text>().text = "" + scoreInteger;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
            Die();


        if (other.tag == "Kill Zone")
            Die();


        if (other.tag == "Kill Zone2")
            Die();


   
    }


    public void RestartGame()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene

    }







    void Die()
    {
      
        Destroy(this.gameObject);
        PlayerPrefs.SetInt("highscore", scoreInteger);

        SceneManager.LoadScene(2);

        //deathMenu.ToggleEndMenu(score);
        //When finish the death menu, delete it!
        //RestartGame();


    }


}
