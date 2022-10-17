using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayAgain : MonoBehaviour
{
    // Start is called before the first frame update
    public void playAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PlayerHealth.currentHealth = 100;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
