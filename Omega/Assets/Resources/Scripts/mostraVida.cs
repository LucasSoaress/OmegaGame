using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class mostraVida : MonoBehaviour
{
    public Text Vida;
    public Text Vida2;
	
	void Start ()
    {
        Vida = Vida.GetComponent<Text>();
        Vida2 = Vida2.GetComponent<Text>();

        if (tirarVida.vida <= 0)
        {
            if (PlayerPrefs.GetString("playerOneName") == "")
            {
                Vida.text = "player: DEAD";
            }

            else
            {
                Vida.text = PlayerPrefs.GetString("playerOneName") + ": " + "DEAD";
            }
        }

        else
        {
            if (PlayerPrefs.GetString("playerOneName") == "")
            {
                Vida.text = "player: " + tirarVida.vida.ToString(); ;
            }

            else
            {
                Vida.text = PlayerPrefs.GetString("playerOneName") + ": " + tirarVida.vida.ToString();
            }
            
        }

        if (outroTirarVida.vida <= 0)
        {
            if (PlayerPrefs.GetString("playerTwoName") == "")
            {
                Vida2.text = "player2: DEAD";
            }

            else
            {
                Vida2.text = PlayerPrefs.GetString("playerTwoName") + ": " + "DEAD";
            }
        }

        else
        {
            if (PlayerPrefs.GetString("playerTwoName") == "")
            {
                Vida2.text = "player2: " + outroTirarVida.vida.ToString();
            }

            else
            {
                Vida2.text = PlayerPrefs.GetString("playerTwoName") + ": " + outroTirarVida.vida.ToString();
            }    
        }
	}
	
	
}
