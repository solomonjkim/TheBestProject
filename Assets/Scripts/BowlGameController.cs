using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlGameController : MonoBehaviour
{
    public Vector3 axis = Vector3.up;
    public GameObject orbs;
    public delegate void OnSolved();
    public static event OnSolved onPuzzleSolved;
    public float value;
    public float multiplier;
    private float counter = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ball")
        {
            if (counter<=value+1)
            {
                orbs.transform.Translate(axis * multiplier);
                Destroy(col.gameObject);
                counter += multiplier;
            }
        }
    } 

    // Update is called once per frame
    void Update()
    {
        if (counter.Equals(value))
        {
            onPuzzleSolved?.Invoke();
            orbs.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
