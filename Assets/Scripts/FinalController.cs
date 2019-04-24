using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalController : MonoBehaviour
{
    public int tracker;

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

    bool isSolved()
    {
        if (tracker == 2)
        {

            return true;
        }
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
