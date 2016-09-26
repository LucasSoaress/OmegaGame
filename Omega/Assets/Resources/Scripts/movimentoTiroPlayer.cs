using UnityEngine;
using System.Collections;

public class movimentoTiroPlayer : MonoBehaviour
{

    void Update()
    {
        if (escMenu.menuFechado == true)
        {
            transform.Translate(0.5f, 0, Time.deltaTime);
        }

        if (transform.position.x > 40)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.gameObject.tag == "GameControllerAmigo")
        {
            Destroy(gameObject);
        }
    }
}
