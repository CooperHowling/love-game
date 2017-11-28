using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checklevel3 : MonoBehaviour
{

    public int check3Win;
    public int verifyStageC;
    public GameObject level2C;
    public GameObject level3C;
    public GameObject Level4C;
    public Button button2C;
    public Button button3C;
    public Button button4C;



    // Use this for initialization
    void Start()
    {

        check3Win = passLevel.Level3Win;
        verifyStageC = passLevel.BossWin;

        // Check levels in stage 1 to see if beat 

        if (verifyStageC >= 2)
        {

            if (check3Win >= 1)
            {
                level2C.SetActive(false);
                button2C.interactable = true;
            }
            else
            {
                button2C.interactable = false;
                level2C.SetActive(true);
            }

            if (check3Win >= 2)
            {
                level3C.SetActive(false);
                button3C.interactable = true;
            }
            else
            {
                button3C.interactable = false;
                level3C.SetActive(true);
            }

            if (check3Win >= 3)
            {
                Level4C.SetActive(false);
                button4C.interactable = true;
            }
            else
            {
                button4C.interactable = false;
                Level4C.SetActive(true);
            }
        }

    }
}