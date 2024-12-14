using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DiceScore : MonoBehaviour
{
    private Dice dice;
    public DiceSideSO diceSide;

    [SerializeField]
    private TextMeshProUGUI sideText;

    private void Awake()
    {
        dice = FindObjectOfType<Dice>();
    }
    private void Update()
    {
        if(dice != null && diceSide.diceFaceNum != 0 && dice.isRollable)
        {
            sideText.text = "Side: " + diceSide.diceFaceNum.ToString();
        }
    }
}
