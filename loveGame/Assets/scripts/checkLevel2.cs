using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkLevel2 : MonoBehaviour
{

    public static int check2Win;
    public static int verifyStageB;
    public GameObject level2B;
    public GameObject level3B;
    public GameObject Level4B;
    public Button button2B;
    public Button button3B;
    public Button button4B;



    // Use this for initialization
    void Start()
    {

        check2Win = passLevel.Level2Win;
        verifyStageB = passLevel.BossWin;

        // Check levels in stage 1 to see if beat 

        if (verifyStageB >= 1)
        {

            if (check2Win >= 1)
            {
                level2B.SetActive(false);
                button2B.interactable = true;
            }
            else
            {
                button2B.interactable = false;
                level2B.SetActive(true);
            }

            if (check2Win >= 2)
            {
                level3B.SetActive(false);
                button3B.interactable = true;
            }
            else
            {
                button3B.interactable = false;
                level3B.SetActive(true);
            }

            if (check2Win >= 3)
            {
                Level4B.SetActive(false);
                button4B.interactable = true;
            }
            else
            {
                button4B.interactable = false;
                Level4B.SetActive(true);
            }
        }

    }
}
