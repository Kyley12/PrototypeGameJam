using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Dice")]
public class DiceSideSO : ScriptableObject
{
    public int diceFaceNum;
    public List<int> currentFacesGot;
    public int avalibleDiceChoice = 3;

    public int GetCurrentFacesNum(int newDiceFace)
    {
        return currentFacesGot.Find(face => face == newDiceFace);
    }

    public void ModifyDiceFaceNum(int newDiceFace)
    {
        diceFaceNum = newDiceFace;
    }

    public void AddCurrentFacesGot(int newDiceFace)
    {
        if(GetCurrentFacesNum(newDiceFace) != 0)
        {
            Debug.LogWarning("The face already exists!");
        }
        else
        {
            currentFacesGot.Add(newDiceFace);
            avalibleDiceChoice--;
        }
    }
}
