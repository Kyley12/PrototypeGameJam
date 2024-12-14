using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceDetector : MonoBehaviour
{
    public Dice dice;

    private void OnTriggerStay(Collider other)
    {
        if(dice != null)
        {
            if(dice.GetComponent<Rigidbody>().velocity == Vector3.zero)
            {
                dice.diceFaceNum = int.Parse(other.name);
                dice.isRollable = true;
            }
        }
    }
}
