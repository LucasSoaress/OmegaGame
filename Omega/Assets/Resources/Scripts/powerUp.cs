using UnityEngine;
using System.Collections;

public class powerUp : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.gameObject.tag == "GameController") 
        {
            Destroy(gameObject);
            instanciarTiro.pontos += 30;
            instanciarTiro.tresTiros = true;
            instanciarTiro.tempoTirosDiagonal = 0;
        }

        if (Col.gameObject.tag == "GameControllerAmigo")
        {
            Destroy(gameObject);
            instanciarTiroAmigo.pontos += 30;
            instanciarTiroAmigo.tresTiros = true;
            instanciarTiroAmigo.tempoTirosDiagonal = 0;
        }

            if (Col.gameObject.tag == "Tiro" || Col.gameObject.tag == "Finish" || Col.gameObject.tag == "TiroAmigo")
        {
            Destroy(gameObject);
        }
    }
}
