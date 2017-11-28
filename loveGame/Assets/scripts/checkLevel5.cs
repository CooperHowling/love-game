using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkLevel5 : MonoBehaviour
{

    public int check5Win;
    public int verifyStageE;
    public GameObject level2E;
    public GameObject level3E;
    public GameObject Level4E;
    public Button button2E;
    public Button button3E;
    public Button button4E;



    // Use this for initialization
    void Start()
    {

        check5Win = passLevel.Level5Win;
        verifyStageE = passLevel.BossWin;

        // Check levels in stage 1 to see if beat 

        if (verifyStageE >= 0)
        {

            if (check5Win >= 1)
            {
                level2E.SetActive(false);
                button2E.interactable = true;
            }
            else
            {
                button2E.interactable = false;
                level2E.SetActive(true);
            }

            if (check5Win >= 2)
            {
                level3E.SetActive(false);
                button3E.interactable = true;
            }
            else
            {
                button3E.interactable = false;
                level3E.SetActive(true);
            }

            if (check5Win >= 3)
            {
                Level4E.SetActive(false);
                button4E.interactable = true;
            }
            else
            {
                button4E.interactable = false;
                Level4E.SetActive(true);
            }
        }

    }
}