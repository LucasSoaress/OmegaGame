using UnityEngine;
using System.Collections;

public class movimentoInimigo : MonoBehaviour 
{
    public Transform powerUp;

    void Update()
    {
        if (escMenu.menuFechado == true)
        {
            transform.Translate(-0.2f, 0, Time.deltaTime);
        }
        
        if (transform.position.x <= -11.17698f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.gameObject.tag == "Tiro")
        {
            Destroy(gameObject);
            instanciarTiro.pontos += 10;

            if (instanciarTiro.inimigosInstanciados >= 5 && transform.position.x <= 7.0f) // instancia o power up
            {
                Instantiate(powerUp, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                instanciarTiro.inimigosInstanciados = 0;
            }
        }

        if (Col.gameObject.tag == "TiroAmigo")
        {
            Destroy(gameObject);
            instanciarTiroAmigo.pontos += 10;

            if (instanciarTiroAmigo.inimigosInstanciados >= 12 && transform.position.x <= 7.0f) // verifica se tem 12 inimigos sozinhos e instancia o power up
            {
                Instantiate(powerUp, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                instanciarTiroAmigo.inimigosInstanciados = 0;
            }
        }



    }
}
