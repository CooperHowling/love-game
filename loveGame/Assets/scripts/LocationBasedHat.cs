using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationBasedHat : MonoBehaviour {

    public GameObject CanadaHat;
    public GameObject USAHat;
    public GameObject MexicoHat;

    void Start()
    {
        Debug.Log("1");
        // Turn on location services, if avialable
        Input.location.Start();
        Debug.Log("2");
    }

    public void Main()
    {
        WaitForLocation();
        Debug.Log("3");
    }

    public void WaitForLocation()
    {
        Debug.Log("4");
       
        string country = GetLocation();
        Debug.Log(country);
        switch (country)
        {
            case "Canada":
                CanadaHat.SetActive(true);
                break;
            case "USA":
                USAHat.SetActive(true);
                break;
            case "Mexico":
                MexicoHat.SetActive(true);
                break;
            default:
                //no hat!
                break;
        }
    }

    private string GetLocation()
    {
        //initialize latitude and longitide to zero (defualt, no hat)
        float lat = 0;
        float lon = 0;

        // Do nothing if location services are not available
        if (Input.location.isEnabledByUser)
        {
            lat = Input.location.lastData.latitude;
            lon = Input.location.lastData.longitude;
        }
        Debug.Log("5");

        if ((lat > 49.9 && lon > -140) || (lat > 42 && lon < -52))
        {
            return "Canada";
        }else if ((lat < 49.9 && lon > -140 && lat >32.5) || (lat < 42 && lon < -52 && lat > 27))
        {
            return "USA";
        }else if (lat < 27 && lon > -120 && lat > 14)
        {
            return "Mexico";
        }else{
            return "Default";
        }
      
    }
}
