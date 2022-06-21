using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObject : MonoBehaviour
{
   
    public GameObject objectToClone;
    public int cloneAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CloneObjeto()
    {
        int contador = 0;
        while(contador < cloneAmount)
        {
            Instantiate(objectToClone);
            contador++;
        }
    }

}
