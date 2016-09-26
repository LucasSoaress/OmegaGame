using UnityEngine;
using System.Collections;

public class movimentoTiroBoss : MonoBehaviour 
{
	void Update () 
    {
        if (escMenu.menuFechado == true) // movimento do bos até o player
        {
            transform.Translate(-0.5f, 0, Time.deltaTime);
        }

        if (transform.position.x  <= -11.17698f)
        {
            Destroy(gameObject);
        }
	}


}
