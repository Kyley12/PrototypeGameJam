using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Dice : MonoBehaviour
{
    public DiceSideSO diceSide;
    private Rigidbody body;

    public bool isRollable = true;

    [SerializeField] private float maxRandomForceValue, startRollingForce;

    public float forceX, forceY, forceZ;

    private void Awake()
    {
        Initialize();
        diceSide.avalibleDiceChoice = 3;
        diceSide.currentFacesGot.Clear();
    }

    public void OnButtonRoll()
    {
        if(body != null && isRollable)
        {
            RollDice();
            isRollable = false;
        }
    }
    
    private void RollDice()
    {
        body.isKinematic = false;

        forceX = Random.Range(0, maxRandomForceValue);
        forceY = Random.Range(0, maxRandomForceValue);
        forceZ = Random.Range(0, maxRandomForceValue);

        body.AddForce(Vector3.up * startRollingForce);
        body.AddTorque(forceX, forceY, forceZ);

        transform.position = new Vector3(0, 2.53f, 0);
        transform.rotation = new Quaternion(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360), 0);
    }

    private void Initialize()
    {
        body = GetComponent<Rigidbody>();
        body.isKinematic = true;
        transform.rotation = new Quaternion(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360), 0);
    }

}
