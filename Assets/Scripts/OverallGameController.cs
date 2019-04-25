using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverallGameController : MonoBehaviour
{
    private int tracker;
    public delegate void OnSolved();
    public static event OnSolved onPuzzleSolved;
    public Light light;
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
    void FinishedPressurePadGame()
    {
        tracker += 1;
    }
    // Called when object containing script is created or enabled
    void OnEnable()
    {
        TargetGameController.onPuzzleSolved += FinishedTargetGame;
        PressurePad.onPuzzleSolved += FinishedPressurePadGame;
        Endpoint.onPuzzleSolved += FinishedMazeGame;
    }

    // Update is called once per frame
    void Update()
    {
        if (tracker == 3)
        {
            //activate a light
            light.range = 3;
            onPuzzleSolved?.Invoke();
        }
    }
}
