using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LB_GameLogic : MonoBehaviour
{
    AudioSource camAudioSource;
    public GameObject prefab_Bomb; // presab boom, no objeto de jerarquia, se llama desde proyecto
    public Transform Moon;
    public Text lblTime;//totaltime
    public Text lblLife;//lifes
    //[HideInspector] oculta variables del inspector
    public float timer = 0.0f;
    public float totalTimer = 0.0f;
    public int lifes = 5;
    //score< usar el playerpreb
    public GameObject panelGameOver;

    // Use this for initialization
    void Start()
    {
        // coger un componente de un game object determinado
        camAudioSource = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>();
        panelGameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        lblLife.text = "Lifes:  " + lifes;
        if (lifes <= 0)
        {
            panelGameOver.SetActive(true);
            return;
        }
        totalTimer += Time.deltaTime;
        lblTime.text = "Time: " + (int)totalTimer;

        timer += Time.deltaTime;
        if (timer >= 2.0f)
        {
            // onUnitSphere>obtiene la posicion de una esfera de radiox, alinea opjetos con el borde
            Vector3 randPos = Random.onUnitSphere;
            //
            Instantiate(prefab_Bomb, Moon.position + randPos * 0.35f, Quaternion.identity);
            //
            timer = 0.0f;
        }
    }
}
