using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class SceneLoader : MonoBehaviour{
    
    public void newGame(){
    PlayerPrefs.SetInt("Count", 0);
    

    SceneManager.LoadScene("SampleScene");

    }
    public void loadGame(){

    SceneManager.LoadScene("SampleScene");

    }

    public void quitGame(){

    SceneManager.LoadScene("Title Screen");

    }
}
