using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossInstruction : MonoBehaviour {

    public GameObject instruction;
    public Button closeIns;
    public Button openIns;


	// Use this for initialization


    public void closeInsPanel()
    {

        instruction.SetActive(false);
    }

    public void openInsPanel()
    {

        instruction.SetActive(true);
    }

}
