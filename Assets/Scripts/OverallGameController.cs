using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverallGameController : MonoBehaviour
{
    public int tracker;
    public delegate void OnSolved();
    public static event OnSolved onPuzzleSolved;
    public GameObject finalChest;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Sphere is unlocked and may be grabbed
    void FinishedTargetGame()
    {
        tracker += 1;
    }

    void FinishedMazeGame()
    {
        tracker += 1;
    }
    // Called when object containing script is created or enabled
    void OnEnable()
    {
        TargetGameController.onPuzzleSolved += FinishedTargetGame;
        MazePuzzleController.onPuzzleSolved += FinishedMazeGame;
    }

    bool isSolved()
    {
        if (tracker == 3)
        {
            Destroy(finalChest);
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
