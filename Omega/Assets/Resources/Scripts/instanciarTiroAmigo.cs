using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class instanciarTiroAmigo : MonoBehaviour
{
    public Transform tiro;
    private GameObject[] tiros;
    public static float tempoTirosDiagonal;
    private float tempo;
    public Transform nave;
    public static float pontos;
    public Text Pontos;
    public static bool tresTiros;
    public static int inimigosInstanciados;

    void Start ()
    {
        Pontos = Pontos.GetComponent<Text>();
        pontos = 0;
        inimigosInstanciados = 0;
    }
	
	
	void Update ()
    {
        tempoTirosDiagonal = tempoTirosDiagonal + 1 * Time.deltaTime;
        tiros = GameObject.FindGameObjectsWithTag("TiroAmigo");
        tempo = tempo + 1 * Time.deltaTime;

        // instancia o tiro do amigo
        if (Input.GetKeyDown(KeyCode.KeypadEnter) && tiros.Length < 5 && escMenu.menuFechado == true)
        {
            GetComponent<AudioSource>().Play();
            Instantiate(tiro, new Vector3(transform.position.x + 0.5f, transform.position.y, 0), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter) && tresTiros == true && tempoTirosDiagonal <= 20 && tiros.Length < 15) // instancia os tiros na diagonal
        {
            GetComponent<AudioSource>().Play();
            Instantiate(tiro, new Vector3(transform.position.x + 0.5f, transform.position.y, 0), Quaternion.identity);
            Instantiate(tiro, new Vector3(transform.position.x + 0.5f, transform.position.y, 0), Quaternion.Euler(new Vector3(337.8273f, 40.21981f, 24.05018f)));
            Instantiate(tiro, new Vector3(transform.position.x + 0.5f, transform.position.y, 0), Quaternion.Euler(new Vector3(17.05888f, 42.29848f, 342.1302f)));
        }

        if (tempo > 1)  // instancia o inimigo 
        {
            Instantiate(nave, new Vector3(transform.position.x + 20f, (Random.Range(-4.5f, 4.8f)), 0), Quaternion.identity);
            tempo = 0;
            inimigosInstanciados += 1;
        }

        if (PlayerPrefs.GetString("playerTwoName") == "")
        {
            Pontos.text = "player2: " + pontos.ToString();
        }

        else
        {
            Pontos.text = PlayerPrefs.GetString("playerTwoName") + ": " + pontos.ToString();
        }
    }
}
