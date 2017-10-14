
using UnityEngine.SceneManagement;

[System.Serializable]
public class Conversation
{
    //for story telling, Game Manager holds an array, each element
    //can have input(speech), a bool indicating if next scene should come
    //and the next scene name if that bool is set true
    public string speech;
    public bool nextScene;
    public string nextSceneName;
   
}
