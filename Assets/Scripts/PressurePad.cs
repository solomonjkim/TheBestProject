using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePad : MonoBehaviour
{
    private int counter;
    public GameObject pad;
    public delegate void OnSolved();
    public static event OnSolved onPuzzleSolved;
    public Light light;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter.Equals(5))
        {
            onPuzzleSolved?.Invoke();
            Destroy(light);
            pad.GetComponent<Renderer>().material.color = Color.blue;
        } else
        {
            pad.GetComponent<Renderer>().material.color = Color.green;
        }

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "oneBlock")
        {
            counter += 1;
        }
        if (col.gameObject.name == "twoBlock")
        {
            counter += 2;
        }
        if (col.gameObject.name == "threeBlock")
        {
            counter += 3;
        }
        if (col.gameObject.name == "fourBlock")
        {
            counter += 4;
        }
        if (col.gameObject.name == "fiveBlock")
        {
            counter += 5;
        }
    }

     bool IsSolved()
    {
        if (counter.Equals(5))
        {
            onPuzzleSolved?.Invoke();
            pad.GetComponent<Renderer>().material.color = Color.blue;
            return true;
        }
        return false;
    }

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "oneBlock")
        {
            counter -= 1;
        }
        if (col.gameObject.name == "twoBlock")
        {
            counter -= 2;
        }
        if (col.gameObject.name == "threeBlock")
        {
            counter -= 3;
        }
        if (col.gameObject.name == "fourBlock")
        {
            counter -= 4;
        }
        if (col.gameObject.name == "fiveBlock")
        {
            counter -= 5;
        }
    }
}
