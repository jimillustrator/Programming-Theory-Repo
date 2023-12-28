using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helium : AtomMaker
{
    public int atomicNumber;
    private BoxCollider protonCollider;
    private float m_OffsetX;
    public float OffsetX
    {
        get{return m_OffsetX;}
        set { m_OffsetX = value;}
    }

    private void Start()
    {
        protonCollider = proton.GetComponent<BoxCollider>();
    }

    public override void ProtonCreator()
    {
        OffsetX = (protonCollider.size.x * atomicNumber) / 2;

        for (int i = 0; i < atomicNumber; i++)
        {
            Instantiate(proton, transform.position, transform.rotation);
        }
    }

    


    
}
