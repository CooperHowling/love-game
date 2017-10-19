using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class passLevel : MonoBehaviour
{

    public bool ButtonOn = false;
    public Button MyButton;

    public void BeenClicked()
    {
        ButtonOn = !ButtonOn;
        if (ButtonOn)
        {
            MyButton.image.color = Color.green;
        }
        else
        {
            MyButton.image.color = Color.white;
        }
    }

}