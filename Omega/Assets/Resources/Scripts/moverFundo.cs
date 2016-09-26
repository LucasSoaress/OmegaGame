using UnityEngine;
using System.Collections;

public class moverFundo : MonoBehaviour
{
    public float velocidade;

	void Update ()
    {
        Vector2 offset = new Vector2(velocidade * Time.time, 0);
        this.GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
