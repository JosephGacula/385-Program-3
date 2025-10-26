using UnityEngine;
using TMPro;
using System.IO;

public class ClickCounter : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    public int count;

    void Start(){
        count = PlayerPrefs.GetInt("Count");
        counterText.text = "Clicks: " + count;
    }


    public void OnSpriteClicked()
    {
        count++;
        counterText.text = "Clicks: " + count;
        PlayerPrefs.SetInt("toCount", count);
    }

}
