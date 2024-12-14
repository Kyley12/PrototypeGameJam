using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceDetector : MonoBehaviour
{
    public DiceSideSO diceSide;
    public Dice dice;

    private void OnTriggerStay(Collider other)
    {
        if(dice != null)
        {
            if(dice.GetComponent<Rigidbody>().velocity == Vector3.zero)
            {
                diceSide.ModifyDiceFaceNum(int.Parse(other.name));
                if(diceSide.avalibleDiceChoice > 0 && diceSide.avalibleDiceChoice <= 3)
                { 
                    diceSide.AddCurrentFacesGot(int.Parse(other.name));
                    dice.isRollable = true;
                }
                else
                {
                    dice.isRollable = false;
                }
            }
        }
    }
}
