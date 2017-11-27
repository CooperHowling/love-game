using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class passLevel : MonoBehaviour
{

    public bool ButtonOn = false;
    public Button MyButton;
    public GameObject WinPanel;
    public GameObject Button1;
    public GameObject Button2;
    public static int LevelWin = 0;

public void BeenClicked()
    {
        ButtonOn = !ButtonOn;
        if (ButtonOn)
        {
            MyButton.image.color = Color.green;
            LevelWin = LevelWin + 1;
            print("this is the number -> " + LevelWin + " beat level 1");
            WinPanel.SetActive(true);
        }
        else
        {
            MyButton.image.color = Color.white;
        }
        //analytics, when user passes level custom event is triggered
        Scene sceneName = SceneManager.GetActiveScene();
        Analytics.CustomEvent("passLevel"+ sceneName);

    }



public void BossClicked()
    {
        ButtonOn = !ButtonOn;
        if (ButtonOn)
        {
            MyButton.image.color = Color.green;
            StartCoroutine(Wait());
            Wait();

        }
        else
        {
            MyButton.image.color = Color.white;
        }
        //analytics, when user passes level custom event is triggered
        Scene sceneName = SceneManager.GetActiveScene();
        Analytics.CustomEvent("passLevel" + sceneName);

    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        Button1.SetActive(false);
        Button2.SetActive(true);

    }
}





