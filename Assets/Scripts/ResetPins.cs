using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPins : MonoBehaviour
{

    private NewPins newPins;

    private GameObject BowlingPinsPrefab;

    private void Start()
    {
        newPins = GameObject.Find("Bowling Lane").GetComponent<NewPins>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BowlingBall")
        {
            StartCoroutine(ResetBowlingPins());
        }
    }

    IEnumerator ResetBowlingPins()
    {
        BowlingPinsPrefab = GameObject.FindGameObjectWithTag("PinsContainer");
        yield return new WaitForSeconds(5);
        Destroy(BowlingPinsPrefab);
        yield return new WaitForSeconds(2);
        newPins.RerackPins();
    }
}
