using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePad : MonoBehaviour
{
    bool isSolved;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        isSolved = true;
        print("solved");
    }
}
