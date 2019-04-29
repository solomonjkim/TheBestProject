using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endpoint : MonoBehaviour
{
    public GameObject Sphere;
    public Light light;
    public delegate void OnSolved();
    public static event OnSolved onPuzzleSolved;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere")
        {
            Sphere.GetComponent<Renderer>().material.color = Color.blue;
            Destroy(light);
            onPuzzleSolved?.Invoke();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
