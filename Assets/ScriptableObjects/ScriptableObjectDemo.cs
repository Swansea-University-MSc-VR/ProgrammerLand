using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ScriptableObjectDemo", order = 1)]
public class ScriptableObjectDemo: ScriptableObject
{
    public string exampleString;

    public int exampleInt;
    
    public Vector3[] examplePositions;
}