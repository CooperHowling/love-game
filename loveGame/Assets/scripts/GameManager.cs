using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Conversation[] conversations;
    [SerializeField]
    private Text convo;
    public int i;

    //since speech is initialized at the first one
    //nextSpeech() goes through the list, printing out the next line
    public void nextSpeech()
    {
        convo.text = conversations[i].speech;
        //if nextScene is true, go to that scene
        //if this is true, there should be no text associated
        //since it will be skipped
        if(conversations[i].nextScene)
        {
            //go to the next scene indicated
            changeScene(conversations[i].nextSceneName);
        }
        i++;
    }

    void Start()
    {
        i = 0;
        convo.text = conversations[i++].speech;
  
    }

    //change scene to sceneName
    public void changeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

    }
}
