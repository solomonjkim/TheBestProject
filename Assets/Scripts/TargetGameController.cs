using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGameController : MonoBehaviour
{
    public GameObject target;
    private int starting;
    public delegate void OnSolved();
    public static event OnSolved onPuzzleSolved;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ball")
        {
            target.GetComponent<Renderer>().material.color = Color.blue;
            Destroy(col.gameObject);
            starting += 1;
        }
    }

    bool IsSolved()
    {
        if (starting == 4)
        {
            onPuzzleSolved?.Invoke();
            return true;
        }
        return false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
