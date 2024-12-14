using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Dice : MonoBehaviour
{
    private Rigidbody body;

    [SerializeField] private float maxRandomForceValue, startRollingForce;

    public float forceX, forceY, forceZ;

    public int diceFaceNum;

    private void Awake()
    {
        Initialize();
    }

    public void OnButtonRoll()
    {
        if(body != null)
        {
            RollDice();
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
    }

    private void Initialize()
    {
        body = GetComponent<Rigidbody>();
        body.isKinematic = true;
    }

}
