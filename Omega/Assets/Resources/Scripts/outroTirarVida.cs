using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class outroTirarVida : MonoBehaviour
{
    public Text Vida;
    public static float vida;
    public string Tag;

    void Start()
    {
        Vida = Vida.GetComponent<Text>();
        vida = 100;
    }

    void Update()
    {
        if (vida < 0)
        {
            Vida.text = "DEAD";
        }

        else
        {
            if (PlayerPrefs.GetString("playerTwoName") == "")
            {
                Vida.text = "player2: " + vida.ToString();
            }

            else
            {
                Vida.text = PlayerPrefs.GetString("playerTwoName") + ": " + vida.ToString();
            }  
        }
        
        
        if (vida <= 0)
        {
            Destroy(gameObject);
            Application.LoadLevel("winVersus"); 
        }

      
    }

    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.gameObject.tag == Tag)
        {
            vida -= 5;
        }

    }
}
