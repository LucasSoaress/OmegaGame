using UnityEngine;
using System.Collections;

public class abrirTelaVitoria : MonoBehaviour
{
    public string qualVitoria;
    public static int vidaBoss;

    void Start()
    {
        vidaBoss = 20;
    }

    void Update ()
    {
	    if (vidaBoss <= 0)
        {
            Application.LoadLevel(qualVitoria);
        }
	}
}
