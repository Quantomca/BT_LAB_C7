using UnityEngine;

public class ButtonLogger : MonoBehaviour
{
    public void StartClicked()
    {
        Debug.Log("Start Game");
    }

    public void OptionsClicked()
    {
        Debug.Log("Options Clicked");
    }

    public void ExitClicked()
    {
        Debug.Log("Exit Clicked");
    }
}