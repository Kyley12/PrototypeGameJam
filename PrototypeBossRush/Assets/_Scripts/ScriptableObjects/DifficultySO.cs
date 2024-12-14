using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DifficultyType
{
    Easy,
    Normal,
    Hard,
    Nightmare,
    Insane,
    Impossible
}

[CreateAssetMenu(menuName = "ScriptableObjects/DifficultySelection")]
public class DifficultySO : ScriptableObject
{
    public DifficultyType currentDifficult;

    
}
