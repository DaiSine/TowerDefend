using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void LoadStart()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadNextScence()
    {
        int nxtIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nxtIndex);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
