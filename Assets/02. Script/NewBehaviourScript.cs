using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RandomLight : MonoBehaviour
{
    public KeyCode key = KeyCode.A;
    public GameObject [] cubes;
    // Use this for initialization
    void Start()
    {
        //cubes = GameObject.FindGameObjectsWithTag("MyCube");
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            foreach (GameObject cube in cubes)
            {
                MeshRenderer cubeMeshR = cube.GetComponent<MeshRenderer>();
                cubeMeshR.material.color = Color.red;
            }
        }
    }
}
