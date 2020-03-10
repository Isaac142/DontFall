using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeThrow : MonoBehaviour
{

    public float throwForce = 40f;
    public GameObject grenadePrefab;
    public bool canThrow = true; 

    // Start is called before the first frame update
    void Start()
    {
        canThrow = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canThrow && Input.GetButtonDown("Fire1"))
        {
            ThrowGrenade();
        }
    }

    void ThrowGrenade()
    {
       GameObject grenade = Instantiate(grenadePrefab, transform.position, transform.rotation);
        Rigidbody rb = grenade.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
    }

    public IEnumerator WaitCoroutine()
    {
        yield return new WaitForSeconds(2f);
    }
}
