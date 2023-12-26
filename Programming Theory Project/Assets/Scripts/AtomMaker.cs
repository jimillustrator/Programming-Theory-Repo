using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomMaker : MonoBehaviour
{
    public GameObject proton;
    public GameObject electron;

    public virtual void ProtonCreator()
    {
        Instantiate(proton, transform.position, transform.rotation);
    }

    public virtual void ElectronCreator()
    {
        Instantiate(electron, transform.position, transform.rotation);
    }
}
