using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helium : AtomMaker
{
    [SerializeField] private int m_atomicNumber;
    public int atomicNumber
    {
        get { return m_atomicNumber; }
        set
        {
            if (value > 0 && value < 5)
            {
                m_atomicNumber = value;
            }
            else
            {
                Debug.Log("Please pick an integer between 1 and 5");
            }
        }
    }

    //private BoxCollider protonCollider;
    //public float OffsetX;

    private void Start()
    {
        ProtonCreator();
    }

    public override void ProtonCreator()
    {
        //OffsetX = (protonCollider.size.x * atomicNumber) / 2;

        for (int i = 0; i < atomicNumber; i++)
        {
            Instantiate(proton, new Vector3((transform.position.x + i), transform.position.y, transform.position.z), transform.rotation);
        }
    }

    


    
}
