using UnityEngine;
using System.Collections;

[DisallowMultipleComponent]
[RequireComponent(typeof(AudioSource))]
public class Button : MonoBehaviour
{
    [SerializeField]Light lightOff;
    [SerializeField]Light lightOn;
    [SerializeField]float resetDelay = .25f;
    // Use this for initialization
    AudioSource sound;
    void Awake()
    {
        sound = GetComponent<AudioSource>();
    }

    void Start()
    {
        ResetButton();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        Debug.Log("BUTTON");
        sound.Play();

        //GetComponent<MeshRenderer>().material.color = hightlightColor;
        lightOn = GetComponent<Light>();
        lightOn.enabled = true;
        Invoke("ResetButton", resetDelay);
    }

    void ResetButton()
    {
        //GetComponent<MeshRenderer>().material.color = defaultColor;
        lightOff = GetComponent<Light>();
        lightOff.enabled = false;
    }
}
