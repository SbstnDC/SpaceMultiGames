
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour 
{
    [SerializeField]Button [] button;
    [Header("Color Order")]
    [SerializeField]List<int> colorOrder;
    [SerializeField]float pickDelay = .4f;
    [SerializeField]int pickNumber = 0;


	// Use this for initialization
	void Start () 
	{
		ResetGame();
        SetButtonIndex();
		StartCoroutine ("PlayGame");
		
	}

	void SetButtonIndex() 
	{
		//for (int cnt = 0; cnt < button.Length; cnt++)
			//button [cnt].ButtonIndex = cnt;
	}

	IEnumerator PlayGame()
	{
        pickNumber = 0;

		yield return new WaitForSeconds (pickDelay);
        //play the colors that are stored
        foreach(int colorIndex in colorOrder)
        {
            //button[colorIndex].PressButton();
            yield return new WaitForSeconds(pickDelay);
        }
		PickRandomColor();

	}

	void PickRandomColor()
	{
		int rnd = Random.Range (0, button.Length);
	//	button [rnd].PressButton ();
		colorOrder.Add (rnd);
	}
		
    public void PlayerRandomColor()
    {
		//int rnd = Random.Range (0,button.Length);
		///button [rnd].PressButton();
	//	colorOrder.Add (rnd);
    }

	public void PlayersPick(int pick)
	{
		Debug.Log("Player Clicked A Button>" + pick);

		if(pick== colorOrder[0])
		{

			Debug.Log("Correct");
			pickNumber++;
			if(pickNumber==colorOrder.Count)
			{
				//update the players score
				StartCoroutine("PlayGame");
			}
		}
		else
		{
			Debug.Log("Fail");
			ResetGame();

			StartCoroutine("PlayGame");

		}	
	}


    void ResetGame()
    {
		Debug.Log("Resetting");
		//Verificar si nosotros tenemos un nuevo score
		//cambiar el score actual de los jugadores a cero
        colorOrder.Clear();
    }
}
