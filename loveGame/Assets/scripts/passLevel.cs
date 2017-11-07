using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class passLevel : MonoBehaviour
{

    public bool ButtonOn = false;
    public Button MyButton;

    public void BeenClicked()
    {
        ButtonOn = !ButtonOn;
        if (ButtonOn)
        {
            MyButton.image.color = Color.green;
            
        }
        else
        {
            MyButton.image.color = Color.white;
        }
        //analytics, when user passes level custom event is triggered
        Scene sceneName = SceneManager.GetActiveScene();
        Analytics.CustomEvent("passLevel"+ sceneName);

    }

}