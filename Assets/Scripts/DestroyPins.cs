using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPins : MonoBehaviour
{
    private Vector3 startingPosition;

    private void Start()
    {
        //startingPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BowlingBall" || collision.gameObject.tag == "Pin")
        {
            StartCoroutine(DestroyPin());
        }


        IEnumerator DestroyPin()
        {
            yield return new WaitForSeconds(5);
            Destroy(this.gameObject);
            //transform.position = startingPosition;
            //transform.rotation = Quaternion.identity;

        }
    }


}
