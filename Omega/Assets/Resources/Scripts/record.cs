using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class record : MonoBehaviour
{
    public Text playerName;
    private float pontosRecebidos;
    private float recordGuardado;
    private string nomeRecord;
    private string nomeFinal;


	void Start ()
    {
        
        playerName = playerName.GetComponent<Text>();

        recordGuardado = PlayerPrefs.GetFloat("playerOnePontos");
        nomeRecord = PlayerPrefs.GetString("playerOneName");
        nomeFinal = PlayerPrefs.GetString("nomeFinal");
        
        if (instanciarTiro.pontos > recordGuardado)
            {
                recordGuardado = instanciarTiro.pontos;
                nomeFinal = nomeRecord;
            }
    }
	
	void Update ()
    {
        playerName.text = nomeFinal + ": " + recordGuardado.ToString();
        PlayerPrefs.SetFloat("playerOnePontos", recordGuardado);
        PlayerPrefs.SetString("nomeFinal", nomeFinal);
    }
}
