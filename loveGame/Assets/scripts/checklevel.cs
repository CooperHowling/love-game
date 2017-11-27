using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checklevel : MonoBehaviour {

    public int checkWin;
    public GameObject Stage2;
    public GameObject Stage3;
    public GameObject Stage4;
    public GameObject Stage5;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;



    // Use this for initialization
    void Start () {
        
        button3.interactable = false;
        button4.interactable = false;
        button5.interactable = false;

        checkWin = passLevel.LevelWin;
        print(checkWin);
        
        if(checkWin >= 1)
        {
            Stage2.SetActive(false);
            button2.interactable = true;

        }else
        {
          button2.interactable = false;
        }

        if (checkWin >= 2)
        {
            Stage3.SetActive(false);
        }
        else
        {
            button3.interactable = false;
        }

        if (checkWin >= 3)
        {
            Stage4.SetActive(false);
        }
        else
        {
            button4.interactable = false;
        }

        if (checkWin >= 4)
        {
            Stage5.SetActive(false);
        }
        else
        {
            button5.interactable = false;
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
