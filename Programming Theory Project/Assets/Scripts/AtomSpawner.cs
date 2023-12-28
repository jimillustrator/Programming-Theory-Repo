using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomSpawner : MonoBehaviour
{
    public Helium heliumAtom;
    public Hydrogen hydrogenAtom;

    // Start is called before the first frame update
    void Start()
    {
        heliumAtom.ProtonCreator();
    }

}
