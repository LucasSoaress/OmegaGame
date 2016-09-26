using UnityEngine;
using System.Collections;

public class movimentoTiro2PlayerVirado : MonoBehaviour
{

	void Update ()
    {
        if (escMenu.menuFechado == true)
        {
            transform.Translate(-0.5f, 0, Time.deltaTime);
        }

        if (transform.position.x <= -20f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D Col)
    {
       if(Col.gameObject.tag == "GameController")
        {
            Destroy(gameObject);
        }
    }
}
