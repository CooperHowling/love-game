using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class failLevel : MonoBehaviour
{

    public bool ButtonOn = false;
    public Button MyButton;
    public GameObject hintPanel;


    public void BeenClicked()
    {
          
        ButtonOn = !ButtonOn;
        if (ButtonOn)
        {

            MyButton.image.color = Color.red;
            MyButton.interactable = false;
            
        }
        else
        {
            MyButton.image.color = Color.white;
        }
    }

}