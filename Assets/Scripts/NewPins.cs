using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPins : MonoBehaviour
{
    [SerializeField]
    private GameObject bowlingPins;

    [SerializeField]
    private Transform pinsPos;

    [SerializeField]
    private GameObject bowlingBall;

    [SerializeField]
    private Transform ballPos;

    public void RerackPins()
    {
        Instantiate(bowlingPins, pinsPos.position, Quaternion.identity);

        Instantiate(bowlingBall, ballPos.position, Quaternion.identity);
    }
}
