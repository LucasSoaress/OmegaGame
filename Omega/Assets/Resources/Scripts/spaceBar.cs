using UnityEngine;
using System.Collections;

public class spaceBar : MonoBehaviour
{
    public string qualJogo;

	void Update ()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            Application.LoadLevel(qualJogo);
        }
    }
}
