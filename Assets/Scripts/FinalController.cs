using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalController : MonoBehaviour
{
    public int tracker;
    public GameObject finalChest;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FinishedBowlGame()
    {
        tracker += 1;
    }

    void OnEnable()
    {
        BowlGameController.onPuzzleSolved += FinishedBowlGame;
    }

    // Update is called once per frame
    void Update()
    {
        if (tracker == 2)
        {
            Destroy(finalChest);
       
        }
    }
}
