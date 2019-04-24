using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlGameController : MonoBehaviour
{
    public Vector3 axis = Vector3.up;
    public GameObject mSphere;
    public delegate void OnSolved();
    public static event OnSolved onPuzzleSolved;
    public int value;
    public int multiplier;

    // Start is called before the first frame update
    void Start()
    {
        
    }
     
    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.name == "Ball")
        {
            mSphere.transform.Translate(axis * multiplier);
        }
    }

    bool IsSolved()
    {
        if(axis.Equals(value))
        {
            onPuzzleSolved?.Invoke();
            mSphere.GetComponent<Renderer>().material.color = Color.yellow;
            return true;
        }
        return false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
