using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InputData", menuName = "ScriptableObjects/InputData")]
public sealed class InputData : ScriptableObject
{
    public KeyCode SaveGame = KeyCode.C;
    public KeyCode LoadGame = KeyCode.V;
}
