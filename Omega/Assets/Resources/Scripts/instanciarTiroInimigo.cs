using UnityEngine;
using System.Collections;

public class instanciarTiroInimigo : MonoBehaviour
{
    public Transform tiro;
    private float tempo;
    
	void Update ()
    {
        tempo = tempo + 1 * Time.deltaTime;

        if (tempo > 0.8f && transform.position.x <= 8)
        {
            GetComponent<AudioSource>().Play();
            Instantiate(tiro, new Vector3(transform.position.x - 0.5f, transform.position.y, 0), Quaternion.identity);
            tempo = 0;
        }
       
    }
}
