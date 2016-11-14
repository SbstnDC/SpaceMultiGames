using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;


public class ClickExit : MonoBehaviour
{

#if UNITY_EDITOR
    // set the PlayMode to stop
    public void Quit()
    {
        Debug.Log("Click Quit");
        Application.Quit();
    }
#else

   
#endif
}

