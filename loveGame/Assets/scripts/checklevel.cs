using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checklevel : MonoBehaviour {

    public static int check1Win;
    public static int verifyStageA;
    public GameObject level2A;
    public GameObject level3A;
    public GameObject level4A;
    public Button button2A;
    public Button button3A;
    public Button button4A;



    // Use this for initialization
    void Start()
    {

        check1Win = passLevel.Level1Win;
        verifyStageA = passLevel.BossWin;

        // Check levels in stage 1 to see if beat 

        if (verifyStageA >= 0)
        {

            if (check1Win >= 1)
            {
                level2A.SetActive(false);
                button2A.interactable = true;
            }
            else
            {
                button2A.interactable = false;
                level2A.SetActive(true);
            }

            if (check1Win >= 2)
            {
                level3A.SetActive(false);
                button3A.interactable = true;
            }
            else
            {
                button3A.interactable = false;
                level3A.SetActive(true);
            }

            if (check1Win >= 3)
            {
                level4A.SetActive(false);
                button4A.interactable = true;
            }
            else
            {
                button4A.interactable = false;
                level4A.SetActive(true);
            }
        }

    }
}
