using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject parti;
    public GameObject collideparticle;
    private void OnTriggerEnter(Collider other)
    {
        if (parti != null)
        {
            Instantiate(parti, this.transform.position, this.transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collideparticle != null)
        {
            Instantiate(collideparticle, this.transform.position, this.transform.rotation);
        }
    }
}
