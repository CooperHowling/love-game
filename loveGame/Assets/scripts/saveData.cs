using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveData : MonoBehaviour {

    public int s1L = checklevel.check1Win;
    public int s1b = checklevel.verifyStageA;


    public int s2L = checkLevel2.check2Win;
    public int s2b = checkLevel2.verifyStageB;

    public int s3L = checklevel3.check3Win;
    public int s3b = checklevel3.verifyStageC;

    void OnApplicationQuit () {

        PlayerPrefs.SetInt("stage1Levels", s1L);
        PlayerPrefs.SetInt("stage1Bosses", s1b);

        PlayerPrefs.SetInt("stage2Levels", s2L);
        PlayerPrefs.SetInt("stage2Bosses", s2b);

        PlayerPrefs.SetInt("stage3Levels", s3L);
        PlayerPrefs.SetInt("stage3Bosses", s3b);

    }
	
	void Awake () {

        checklevel.check1Win = PlayerPrefs.GetInt("stage1Levels", 0);
        checklevel.verifyStageA = PlayerPrefs.GetInt("stage1Bosses", 0);

        checkLevel2.check2Win = PlayerPrefs.GetInt("stage2Levels", 0);
        checkLevel2.verifyStageB = PlayerPrefs.GetInt("stage2Bosses", 0);

        checklevel3.check3Win = PlayerPrefs.GetInt("stage2Levels", 0);
        checklevel3.verifyStageC = PlayerPrefs.GetInt("stage2Bosses", 0);

    }

}
