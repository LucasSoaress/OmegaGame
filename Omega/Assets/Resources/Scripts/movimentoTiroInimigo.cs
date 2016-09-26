using UnityEngine;
using System.Collections;

public class movimentoTiroInimigo : MonoBehaviour
{

	void Update ()
    {
        if (escMenu.menuFechado == true)
        {
            transform.Translate(-0.6f, 0, Time.deltaTime);
        }

        if ( transform.position.x <= -11.17698f)
        {
            Destroy(gameObject);
        }
    }

   
}
