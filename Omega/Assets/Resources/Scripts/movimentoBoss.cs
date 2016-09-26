using UnityEngine;
using System.Collections;

public class movimentoBoss : MonoBehaviour
{
    public Transform tiroBoss;   //recebe o tiro do boss
    
    private float tempoTiroBoss;

	void Start ()
    {
        tempoTiroBoss = 0;
	}
	
	void Update ()
    {
        tempoTiroBoss = tempoTiroBoss + 1 * Time.deltaTime;

        if (escMenu.menuFechado == true && transform.position.x >= 4) // movimento do bos até o player
        {
            transform.Translate(-0.03f, 0, 0 * Time.deltaTime);
        }

        if (tempoTiroBoss >= 1.5f) //  instanciar tiros do boss
        {
            GetComponent<AudioSource>().Play();
            Instantiate(tiroBoss, new Vector3(transform.position.x -4f, transform.position.y, 0), Quaternion.identity);
            Instantiate(tiroBoss, new Vector3(transform.position.x - 0.30f, 2.9f, 0), Quaternion.identity);
            Instantiate(tiroBoss, new Vector3(transform.position.x - 0.30f, -3.25f, 0), Quaternion.identity);
            tempoTiroBoss = 0;
        }
    }


    void OnTriggerEnter2D(Collider2D Col) // como matar o boss
    {
        if (Col.gameObject.tag == "Tiro" && transform.position.x <= 4 || Col.gameObject.tag == "TiroAmigo" && transform.position.x <= 4) 
        {
            abrirTelaVitoria.vidaBoss -= 1;
        }
    }
}

