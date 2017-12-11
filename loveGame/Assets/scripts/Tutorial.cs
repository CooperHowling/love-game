using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour {


    public bool ButtonOn = false;
    public Button log;
    public GameObject next1;
    public GameObject next2;
    public GameObject next3;
    public GameObject next4;
    public GameObject next5;
    public GameObject next6;

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public GameObject panel6;


    public GameObject rhyme;
    public GameObject line1;




    public void nextPanel()
    {
        ButtonOn = !ButtonOn;
        if (ButtonOn)
        {

            panel1.SetActive(false);
            panel2.SetActive(true);
            line1.SetActive(true);

        }

    }


    public void nextPanel2()
    {
        
        if (ButtonOn)
        {

            panel2.SetActive(false);
            panel3.SetActive(true);
            line1.SetActive(true);
            rhyme.SetActive(true);

        }

    }



    public void nextPanel3()
    {
        
        if (ButtonOn)
        {

            panel3.SetActive(false);
            panel4.SetActive(true);
            line1.SetActive(true);
            rhyme.SetActive(true);

        }

    }



    public void nextPanel4()
    {
        
        if (ButtonOn)
        {

            panel4.SetActive(false);
            panel5.SetActive(true);
            line1.SetActive(true);
            rhyme.SetActive(true);

        }

    }



    public void nextPanel5()
    {
        
        if (ButtonOn)
        {

            panel5.SetActive(false);
            line1.SetActive(true);
            rhyme.SetActive(true);

        }

    }



    public void nextPanel6()
    {
        
        if (ButtonOn)
        {
            panel6.SetActive(false);
            line1.SetActive(true);
            rhyme.SetActive(true);

        }

    }

    public void logButton()
    {
        log.image.color = Color.green;
        panel6.SetActive(true);
    }




}
