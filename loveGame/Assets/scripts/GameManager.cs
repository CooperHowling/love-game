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

    public void nextSpeech()
    {
        convo.text = conversations[i++].speech;
    }

    void Start()
    {
        i = 0;
        convo.text = conversations[i++].speech;
  
    }
}
