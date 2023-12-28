using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helium : AtomMaker
{
    public int atomicNumber;
    private BoxCollider protonCollider;
    private float offsetX;

    private void Start()
    {
        protonCollider = GetComponent<BoxCollider>();
    }

    public override void ProtonCreator()
    {
        //offsetX = (protonCollider.size.x * atomicNumber)/2;

        for (int i = 0; i < atomicNumber; i++)
        {
            Instantiate(proton, transform.position, transform.rotation);
        }
    }

    


    
}
