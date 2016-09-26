using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class mostrarScoreGameOver : MonoBehaviour
{
    public Text exibirScore;

	void Start ()
    {
        exibirScore = exibirScore.GetComponent<Text>();

        if (PlayerPrefs.GetString("playerOneName") == "")
        {
            exibirScore.text = "player: " + instanciarTiro.pontos.ToString();
        }

        else
        {
            exibirScore.text = PlayerPrefs.GetString("playerOneName") + ": " + instanciarTiro.pontos.ToString();
        }
    }
}
