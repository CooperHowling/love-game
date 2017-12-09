using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hints : MonoBehaviour {


    public Button answer2;
    public Button answer3;
    public Button answer4;
    int checkbtn1;
    int checkbtn2;
    int checkbtn3;
    public GameObject timeHintPanel;
    public GameObject fastHintPanel;
    float timePassed;

	// Update is called once per frame
	void Update () {



         if(checkbtn1 == 1 && checkbtn2 == 1 && checkbtn3 == 1) // trying random stuff
        {
            print("wuddup");
        }

        timePassed += Time.deltaTime;
        if (timePassed < 5 && checkbtn1 == 1 && checkbtn2 == 1 && checkbtn3 == 1)
        {
            fastHintPanel.SetActive(true);
            StartCoroutine(fastTimer());
            print("hmmmmm");
        }
        print(timePassed);

    }

    void Start()
    {

        StartCoroutine(hintTimer());

        timePassed = 0;

        checkbtn1 = 0;
        checkbtn2 = 0;
        checkbtn3 = 0;

        print(checkbtn1);
        print(checkbtn2);
        print(checkbtn3);
        print(timePassed);

        Button btnFail = answer2.GetComponent<Button>();
        btnFail.onClick.AddListener(check1);

        Button btnFail1 = answer3.GetComponent<Button>();
        btnFail1.onClick.AddListener(check2);

        Button btnFail2 = answer4.GetComponent<Button>();
        btnFail2.onClick.AddListener(check3);



    }

    void check1() 
    {

        checkbtn1 = checkbtn1 + 1;
        print(checkbtn1);

    }

    void check2()
    {

        checkbtn2 = checkbtn2 + 1;
        print(checkbtn2);

    }

    void check3()
    {

        checkbtn3 = checkbtn3 + 1;
        print(checkbtn3);

    }

    IEnumerator hintTimer()
    {
        yield return new WaitForSeconds(30);
        timeHintPanel.SetActive(true);

    }

    IEnumerator fastTimer()
    {
        yield return new WaitForSeconds(10);
        fastHintPanel.SetActive(false);

    }

}
