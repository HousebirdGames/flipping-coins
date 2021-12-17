using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public Rigidbody rb;
    public float strength;
    public bool headIsUp;

    [ContextMenu("Flip Coin")]
    public void FlipCoin()
    {
        rb.AddForce(Vector3.up * strength, ForceMode.Impulse);
        rb.AddTorque(Vector3.left * (Random.Range(200f, 400f)));
    }

    private void OnCollisionEnter(Collision collision)
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up), out hit))
        {
            Debug.Log("Ray: " + hit.transform.gameObject.name);
            headIsUp = false;
        }
        else
        {
            headIsUp = true;
        }
    }
}
