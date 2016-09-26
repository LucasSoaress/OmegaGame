using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class mostrarScoreGameOverTwoPlayers : MonoBehaviour
{
    public Text Score1;
    public Text Score2;

	void Start ()
    {
        Score1 = Score1.GetComponent<Text>();
        Score2 = Score2.GetComponent<Text>();
        
        if (PlayerPrefs.GetString("playerOneName") == "")
        {
            Score1.text = "player: " + instanciarTiro.pontos.ToString();
        }

        else
        {
            Score1.text = PlayerPrefs.GetString("playerOneName") + ": " + instanciarTiro.pontos.ToString();
        }

        if (PlayerPrefs.GetString("playerTwoName") == "")
        {
            Score2.text = "player2: " + instanciarTiroAmigo.pontos.ToString();
        }

        else
        {
            Score2.text = PlayerPrefs.GetString("playerTwoName") + ": " + instanciarTiroAmigo.pontos.ToString();
        }

        if (movimentoNave.morreu == true)
        {
            Score1.text = "DEAD";
        }

        if (movimentoAmigo.morreu == true)
        {
            Score2.text = "DEAD";
        }
    }
}
