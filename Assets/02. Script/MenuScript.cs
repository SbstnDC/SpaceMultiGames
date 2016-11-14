using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
    GameObject spaceship;
    //float timer = 0.0f;
    public float speedRotation = 10.0f;
   
	// Use this for initialization
	void Start () 
    {
        spaceship = GameObject.Find("SpaceShip");
        
        Debug.Log("HOla, este mensaje aparece una vez");
        //Debug.Warning("HOla, este mensaje aparece una vez, es un warning");
        //Debug.Error("HOla, este mensaje aparece una vez, es un error");

        Debug.Log("MenuScript_start");

	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Rotate(0.0f, Time.deltaTime*speedRotation, 0.0f); //transformar la rotacion en cada grame
	    if( Input.GetKey ( KeyCode.A))
        {
            spaceship.SetActive(false);
        }
            
	}

    void SayHi()
    {
        Debug.Log("HOla");
    }
}
