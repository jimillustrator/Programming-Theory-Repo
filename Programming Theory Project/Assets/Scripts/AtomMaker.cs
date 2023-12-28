using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomMaker : MonoBehaviour
{
    public GameObject proton;
    public GameObject electron;

    private BoxCollider protonCollider;

    private void Start()
    {
        protonCollider = proton.GetComponent<BoxCollider>();
        float offsetX = protonCollider.size.x;
    }

    public virtual void ProtonCreator()
    {

        {
            Instantiate(proton, transform.position, transform.rotation);
        }
    }

    public virtual void ElectronCreator()
    {
        Instantiate(electron, transform.position, transform.rotation);
    }

}
