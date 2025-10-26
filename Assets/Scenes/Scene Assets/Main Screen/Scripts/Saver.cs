using UnityEngine;

public class Saver : MonoBehaviour
{
    public void saveGame(){

    PlayerPrefs.SetInt("Count", PlayerPrefs.GetInt("toCount"));

    }
}
