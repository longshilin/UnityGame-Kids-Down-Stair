using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CompleteGameManager : MonoBehaviour {

    public Button restartButton;
    public GameObject player;
    void Start () {
        restartButton.gameObject.SetActive(false);
    }
 
    void Update () {
        if (CompletePlayer.isDead)
        {
            player.SetActive(false);
            restartButton.gameObject.SetActive(true);
        }
    }

    public void ReloadScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}