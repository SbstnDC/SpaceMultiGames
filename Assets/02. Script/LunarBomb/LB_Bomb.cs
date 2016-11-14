using UnityEngine;
using System.Collections;


public class LB_Bomb : MonoBehaviour
{
    public AudioClip deactivate;
    public AudioClip booom;

    AudioSource camAudioSource;
    LB_GameLogic logic; // prefab
    public Transform Bomb;
    public GameObject prefab_Explotion;// prefab particle system effect
    
    public float timeToDestroy = 3.0f;
    public float timer = 0.0f;
    // Use this for initialization
    void Start()
    {
        camAudioSource = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>();

        GameObject o = GameObject.FindGameObjectWithTag("GameLogic");

        if (o == null)
        {
            Debug.LogError("ERROR!!!");
        }
        else
        {
            logic = o.GetComponent<LB_GameLogic>();// prefab
        }

        timer = 0.0f;
        Invoke("DestroyBomb", timeToDestroy);
        
        //Destroy(this, 3.0f);
    }

    void Awake()
    {
        //Explotion.Play();
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Color col = Color.Lerp(Color.green, Color.red, timer / timeToDestroy);
        GetComponent<MeshRenderer>().material.color = col;
    }

    void DestroyBomb()
    {
        Vector3 randPosE = Random.onUnitSphere;
        //Upcasting, dale una variable game object, y asignarle una instancia de un projeto.
        GameObject ExplotionE = (GameObject)Instantiate(prefab_Explotion, Bomb.position + randPosE * 0.1f, Quaternion.identity);

        camAudioSource.PlayOneShot(booom);
        logic.lifes--;//descontar vidas

        Destroy(ExplotionE, ExplotionE.GetComponent<ParticleSystem>().duration); //

        Destroy(this.gameObject);
    }

    void OnMouseDown()
    {
        camAudioSource.PlayOneShot(deactivate);
        Destroy(this.gameObject);
    }
}


