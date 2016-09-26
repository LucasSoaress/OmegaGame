using UnityEngine;
using System.Collections;

public class movimentoTiro : MonoBehaviour 
{

	void Update () 
    {
        if (escMenu.menuFechado == true)
        {
            transform.Translate(0.5f, 0, Time.deltaTime);
        }
        if (transform.position.x > 40 || transform.position.y > 5)
        {
            Destroy(gameObject);
        }
        
    }

        void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.gameObject.tag == "Inimigo" || Col.gameObject.tag == "Boss")
        {
            Destroy(gameObject);
        }
    }

	

    
}
