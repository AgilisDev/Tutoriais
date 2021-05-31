using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBala : MonoBehaviour
{

    public float velocidade;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2 (velocidade * Time.deltaTime, 0));
        Destroy(this.gameObject, 5f);
    }
}
