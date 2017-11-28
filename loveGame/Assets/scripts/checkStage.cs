using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkStage : MonoBehaviour
{

    public int winStage;
    public GameObject Stage2;
    public GameObject Stage3;
    public GameObject Stage4;
    public GameObject Stage5;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;

    // Use this for initialization
    void Start()
    {

        winStage = passLevel.BossWin;
        print(winStage);

        if (winStage >= 1)
        {
            Stage2.SetActive(false);
            button2.interactable = true;

        }
        else
        {
            button2.interactable = false;
            Stage2.SetActive(true);
        }

        if (winStage >= 2)
        {
            Stage3.SetActive(false);
            button3.interactable = true;
        }
        else
        {
            button3.interactable = false;
            Stage3.SetActive(true);
        }

        if (winStage >= 3)
        {
            Stage4.SetActive(false);
            button4.interactable = true;
        }
        else
        {
            button4.interactable = false;
            Stage4.SetActive(true);
        }

        if (winStage >= 4)
        {
            Stage5.SetActive(false);
            button5.interactable = true;
        }
        else
        {
            button5.interactable = false;
            Stage5.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
