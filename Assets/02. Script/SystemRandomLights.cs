using UnityEngine;
using System.Collections;

public class SystemRandomLights : MonoBehaviour
{
    public KeyCode key = KeyCode.Space  ; //variable publica para obtener una tecla
    public GameObject[] lights; // arreglo publico vector de luces definido por inspector 
    public float countTime = 0;

    // Use this for initialization
    void Start()
    {
        lights = GameObject.FindGameObjectsWithTag("Lights"); // arreglo se le asigna buscar todos aquellso gameobjecs con eriqueta Lights 
        Debug.Log("APAGADAS TODAS");
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("countTime \t" + countTime);

        if (  countTime > 0) // si los milisegundos acumulados en countime son superiores o iguales a 5 segundos en float, entonces...     Input.GetKeyDown(key) si, se preciona la tecla key(a) "flecha abajo"
        {
            foreach (GameObject Light in lights)// recorrer los objetos de light en arreglos lights
            {
                Light.SetActive(false); // desactivar todas las luces del arreglo
                Debug.Log("APAGADAS TODAS");
            }
            countTime -= Time.deltaTime ; // acumular milisegundos en counttime
            //countTime = 1f;
        }

        else
        {
            //foreach (GameObject Light in lights)//recorrer arreglo   
            //Light lighton = Light.GetComponent<Light>(); //variable que obtiene el componente de light            
            var onlight = lights[Random.Range(0, lights.Length)]; //en variable onlight, asignar escogiendo un elemento aleatorio de una matriz entre el min y max del arreglo
            onlight.SetActive(true); // segun lo ejegido aleatoriamente aen lo anterior entonces activar todas las luces del arreglo
            
            Debug.Log("PRENDIDA \t" + onlight + "\t" + countTime);
            countTime = 1f;
        }
    }
}