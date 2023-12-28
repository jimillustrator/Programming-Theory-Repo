using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomMaker : MonoBehaviour
{
    public GameObject proton;
    public GameObject electron;

    private BoxCollider protonCollider;

    public int atomicNumber;

    private float offsetX;
    public float speed;


    private void Start()
    {
        protonCollider = proton.GetComponent<BoxCollider>();
        float offsetX = protonCollider.size.x;
        ProtonCreator();
    }

    public virtual void ProtonCreator()
    {
        for (int i = 0; i < atomicNumber; i++)
        {
            Instantiate(proton, new Vector3((transform.position.x + i)/2, transform.position.y, (transform.position.z + i)/2), transform.rotation);
            Debug.Log(i);
        }
    }

    public virtual void ElectronCreator()
    {
        Instantiate(electron, transform.position, transform.rotation);
    }

    public void AtomDrop()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

}
