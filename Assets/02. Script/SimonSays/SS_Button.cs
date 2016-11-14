using UnityEngine;
using System.Collections;


public class SS_Button : MonoBehaviour
{
    public int index;
    public SS_GameController controller;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnMouseDown()
    {
        logicGame.ClickOnButton(index);
    }


}