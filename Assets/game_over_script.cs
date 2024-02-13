using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class game_over_script : MonoBehaviour
{
    //public Text pointsText;

    //public void Setup(int score) {
    //    gameObject.SetActive(true);
    //    pointsText.text = score.ToString() + " POINTS";
    //}
    // Start is called before the first frame update

    //public class ButtonActions : MonoBehaviour
    //{
    public void OnButtonClick(){
        Debug.Log("Button Clicked!");
        RestartGame();
    }

    public void BacktoMenu()
    {
        Debug.Log("loading to startmenu...");
        // loading GameOver scene
        SceneManager.LoadScene("StartMenu");
    }

    public void RestartGame()
    {
        Debug.Log("Restart game directly...");
        // loading GameOver scene
        SceneManager.LoadScene("StartMenu");
    }

}