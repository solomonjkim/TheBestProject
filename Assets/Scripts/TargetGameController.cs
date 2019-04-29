using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGameController : MonoBehaviour
{
    public GameObject target;
    private int starting;
    public delegate void OnSolved();
    public Light light;
    public static event OnSolved onPuzzleSolved;

    // Start is called before the first frame update
    void Start()
    {
        starting = 0;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ball")
        {

            Destroy(col.gameObject);
            starting += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (starting == 4)
        {
            Destroy(light);
            target.GetComponent<Renderer>().material.color = Color.blue;
            onPuzzleSolved?.Invoke();
        }
    }
}
