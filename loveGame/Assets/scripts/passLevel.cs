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
    public GameObject Rhyme2;
    public GameObject Rhyme3;
    public static int Level1Win = 0;
    public static int Level2Win = 0;
    public static int Level3Win = 0;
    public static int Level4Win = 0;
    public static int Level5Win = 0;
    public static int BossWin = 0;

public void BeenClicked()
    {
        ButtonOn = !ButtonOn;
        if (ButtonOn)
        {
            MyButton.image.color = Color.green;
            Level1Win = Level1Win + 1;
   
            print("this is the number -> " + Level1Win + " beat level 1");
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

    public void BeenClicked2()
    {
        ButtonOn = !ButtonOn;
        if (ButtonOn)
        {
            MyButton.image.color = Color.green;
            Level2Win = Level2Win + 1;

            print("this is the number -> " + Level2Win + " beat level 1");
            WinPanel.SetActive(true);
        }
        else
        {
            MyButton.image.color = Color.white;
        }
        //analytics, when user passes level custom event is triggered
        Scene sceneName = SceneManager.GetActiveScene();
        Analytics.CustomEvent("passLevel" + sceneName);

    }

    public void BeenClicked3()
    {
        ButtonOn = !ButtonOn;
        if (ButtonOn)
        {
            MyButton.image.color = Color.green;
            Level3Win = Level3Win + 1;

            print("this is the number -> " + Level3Win + " beat level 1");
            WinPanel.SetActive(true);
        }
        else
        {
            MyButton.image.color = Color.white;
        }
        //analytics, when user passes level custom event is triggered
        Scene sceneName = SceneManager.GetActiveScene();
        Analytics.CustomEvent("passLevel" + sceneName);

    }

    public void BeenClicked4()
    {
        ButtonOn = !ButtonOn;
        if (ButtonOn)
        {
            MyButton.image.color = Color.green;
            Level4Win = Level4Win + 1;

            print("this is the number -> " + Level4Win + " beat level 1");
            WinPanel.SetActive(true);
        }
        else
        {
            MyButton.image.color = Color.white;
        }
        //analytics, when user passes level custom event is triggered
        Scene sceneName = SceneManager.GetActiveScene();
        Analytics.CustomEvent("passLevel" + sceneName);

    }

    public void BeenClicked5()
    {
        ButtonOn = !ButtonOn;
        if (ButtonOn)
        {
            MyButton.image.color = Color.green;
            Level5Win = Level5Win + 1;

            print("this is the number -> " + Level5Win + " beat level 1");
            WinPanel.SetActive(true);
        }
        else
        {
            MyButton.image.color = Color.white;
        }
        //analytics, when user passes level custom event is triggered
        Scene sceneName = SceneManager.GetActiveScene();
        Analytics.CustomEvent("passLevel" + sceneName);

    }

    public void StageWin()
    {
        ButtonOn = !ButtonOn;
        if (ButtonOn)
        {
            MyButton.image.color = Color.green;
            BossWin = BossWin + 1;
            WinPanel.SetActive(true);
        }
        else
        {
            MyButton.image.color = Color.white;
        }
        //analytics, when user passes level custom event is triggered
        Scene sceneName = SceneManager.GetActiveScene();
        Analytics.CustomEvent("passLevel" + sceneName);

    }



    public void BossClicked()
    {
        ButtonOn = !ButtonOn;
        if (ButtonOn)
        {
            MyButton.image.color = Color.green;
            StartCoroutine(WaitRhyme1());
            WaitRhyme1();

        }
        else
        {
            MyButton.image.color = Color.white;
        }
        //analytics, when user passes level custom event is triggered
        Scene sceneName = SceneManager.GetActiveScene();
        Analytics.CustomEvent("passLevel" + sceneName);

    }

    public void BossClicked2()
    {
        ButtonOn = !ButtonOn;
        if (ButtonOn)
        {
            MyButton.image.color = Color.green;
            StartCoroutine(WaitRhyme2());
            WaitRhyme2();

        }
        else
        {
            MyButton.image.color = Color.white;
        }
        //analytics, when user passes level custom event is triggered
        Scene sceneName = SceneManager.GetActiveScene();
        Analytics.CustomEvent("passLevel" + sceneName);

    }

    IEnumerator WaitRhyme1()
    {
        yield return new WaitForSeconds(5);
        Button1.SetActive(false);
        Button2.SetActive(true);
        Rhyme2.SetActive(true);
    
  
    }

    IEnumerator WaitRhyme2()
    {
        yield return new WaitForSeconds(5);
        Button1.SetActive(false);
        Button2.SetActive(true);

    }
}





