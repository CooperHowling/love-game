using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkLevel4 : MonoBehaviour
{

    public int check4Win;
    public int verifyStageD;
    public GameObject level2D;
    public GameObject level3D;
    public GameObject Level4D;
    public Button button2D;
    public Button button3D;
    public Button button4D;



    // Use this for initialization
    void Start()
    {

        check4Win = passLevel.Level4Win;
        verifyStageD = passLevel.BossWin;

        // Check levels in stage 1 to see if beat 

        if (verifyStageD >= 3)
        {

            if (check4Win >= 1)
            {
                level2D.SetActive(false);
                button2D.interactable = true;
            }
            else
            {
                button2D.interactable = false;
                level2D.SetActive(true);
            }

            if (check4Win >= 2)
            {
                level3D.SetActive(false);
                button3D.interactable = true;
            }
            else
            {
                button3D.interactable = false;
                level3D.SetActive(true);
            }

            if (check4Win >= 3)
            {
                Level4D.SetActive(false);
                button4D.interactable = true;
            }
            else
            {
                button4D.interactable = false;
                Level4D.SetActive(true);
            }
        }

    }
}