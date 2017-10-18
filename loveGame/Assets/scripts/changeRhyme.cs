using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeRhyme : MonoBehaviour {


    public Text rhymeText = null;

    public void cRhyme(string rhyme)
    {
        rhymeText.text = rhyme;

    }


}
