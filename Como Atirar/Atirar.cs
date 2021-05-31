using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour
{
    public GameObject Bala; 

    public void atirar()
    {
        Instantiate(Bala, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }
}
