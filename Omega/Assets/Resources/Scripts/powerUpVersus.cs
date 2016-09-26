using UnityEngine;
using System.Collections;

public class powerUpVersus : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.gameObject.tag == "GameController")
        {
            Destroy(gameObject);
            outroTirarVida.vida += 5;
            instanciarTiro1PlayerVersus.tresTiros = true;
            instanciarTiro1PlayerVersus.tempoTirosDiagonal = 0;
        }

        if (Col.gameObject.tag == "GameControllerAmigo")
        {
            Destroy(gameObject);
            tirarVida.vida += 5;
            instanciarTiro2PlayerVersus.tresTiros = true;
            instanciarTiro2PlayerVersus.tempoTirosDiagonal = 0;
        }

        if (Col.gameObject.tag == "Tiro" || Col.gameObject.tag == "TiroAmigoVersus")
        {
            Destroy(gameObject);
        }
    }
}
