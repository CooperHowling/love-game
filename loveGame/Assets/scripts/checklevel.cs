﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checklevel : MonoBehaviour {

    public int check1Win;
    public int check2Win;
    public int check3Win;
    public int check4Win;
    public int check5Win;
    public int verifyStage;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public Button button2;
    public Button button3;
    public Button button4;

    // Use this for initialization
    void Start () {
        
        check1Win = passLevel.Level1Win;
        check2Win = passLevel.Level2Win;
        check3Win = passLevel.Level3Win;
        check4Win = passLevel.Level4Win;
        check5Win = passLevel.Level5Win;
        verifyStage = passLevel.BossWin;

        // Check levels in stage 1 to see if beat 
        if (verifyStage >= 0)
        {
            if (check1Win >= 1)
            {
                level2.SetActive(false);
                button2.interactable = true;

            }
            else
            {
                button2.interactable = false;
                level2.SetActive(true);
            }

            if (check1Win >= 2)
            {
                level3.SetActive(false);
                button3.interactable = true;
            }
            else
            {
                button3.interactable = false;
                level3.SetActive(true);
            }

            if (check1Win >= 3)
            {
                level4.SetActive(false);
                button4.interactable = true;
            }
            else
            {
                button4.interactable = false;
                level4.SetActive(true);
            }
        }
        
        // Check levels in stage 2 to see if beat
        if (verifyStage >= 1)
        {
            if (check2Win >= 1)
            {
                level2.SetActive(false);
                button2.interactable = true;

            }
            else
            {
                button2.interactable = false;
                level2.SetActive(true);
            }

            if (check2Win >= 2)
            {
                level3.SetActive(false);
                button3.interactable = true;
            }
            else
            {
                button3.interactable = false;
                level3.SetActive(true);
            }

            if (check2Win >= 3)
            {
                level4.SetActive(false);
                button4.interactable = true;
            }
            else
            {
                button4.interactable = false;
                level4.SetActive(true);
            }
        }

        // Check levels in stage 3 to see if beat
        if (verifyStage >= 2)
        {
            if (check3Win >= 1)
            {
                level2.SetActive(false);
                button2.interactable = true;

            }
            else
            {
                button2.interactable = false;
                level2.SetActive(true);
            }

            if (check3Win >= 2)
            {
                level3.SetActive(false);
                button3.interactable = true;
            }
            else
            {
                button3.interactable = false;
                level3.SetActive(true);
            }

            if (check3Win >= 3)
            {
                level4.SetActive(false);
                button4.interactable = true;
            }
            else
            {
                button4.interactable = false;
                level4.SetActive(true);
            }
        }

        // Check levels in stage 4 to see if beat
        if (verifyStage >= 3)
        {
            if (check4Win >= 1)
            {
                level2.SetActive(false);
                button2.interactable = true;

            }
            else
            {
                button2.interactable = false;
                level2.SetActive(true);
            }

            if (check4Win >= 2)
            {
                level3.SetActive(false);
                button3.interactable = true;
            }
            else
            {
                button3.interactable = false;
                level3.SetActive(true);
            }

            if (check4Win >= 3)
            {
                level4.SetActive(false);
                button4.interactable = true;
            }
            else
            {
                button4.interactable = false;
                level4.SetActive(true);
            }
        }

        // Check levels in stage 5 to see if beat
        if (verifyStage >= 4)
        {
            if (check5Win >= 1)
            {
                level2.SetActive(false);
                button2.interactable = true;

            }
            else
            {
                button2.interactable = false;
                level2.SetActive(true);
            }

            if (check5Win >= 2)
            {
                level3.SetActive(false);
                button3.interactable = true;
            }
            else
            {
                button3.interactable = false;
                level3.SetActive(true);
            }

            if (check5Win >= 3)
            {
                level4.SetActive(false);
                button4.interactable = true;
            }
            else
            {
                button4.interactable = false;
                level4.SetActive(true);
            }
        }


    }

    // Update is called once per frame
    void Update () {
		
	}
}
