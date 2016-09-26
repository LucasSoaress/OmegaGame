using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class instanciarTiro : MonoBehaviour 
{
    public Transform [] Hordas;
    public Transform tiro;
    public Transform nave;
    public Transform Boss;
    private float tempoBoss;
    private float tempo;
    private float tempoHorda;
    public static float pontos;
    public Text Pontos;
    private GameObject[] tiros;
    public static int inimigosInstanciados;
    public static bool tresTiros;
    public static float tempoTirosDiagonal;
    private bool bossInstanciado;

    void Start()
    {
        Pontos = Pontos.GetComponent<Text>();
        pontos = 0;
        tresTiros = false;
        inimigosInstanciados = 0;
        bossInstanciado = false;
    }

	void Update () 
    {
        tiros = GameObject.FindGameObjectsWithTag("Tiro");

        tempo = tempo + 1 * Time.deltaTime;
        tempoHorda = tempoHorda + 1 * Time.deltaTime;
        tempoTirosDiagonal = tempoTirosDiagonal + 1 * Time.deltaTime;
        tempoBoss = tempoBoss + 1 * Time.deltaTime;


        if (tempoBoss >= 60 && bossInstanciado == false) // instancia o boss
        {
            Instantiate(Boss, new Vector3(transform.position.x + 40f, 0, 0), Quaternion.identity);
            bossInstanciado = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && tiros.Length < 5 && escMenu.menuFechado == true) // instancia tiro e faz o som
        {
            GetComponent<AudioSource>().Play();
            Instantiate(tiro, new Vector3(transform.position.x + 0.5f, transform.position.y, 0), Quaternion.identity);
        }

         if (Input.GetKeyDown(KeyCode.Space) && tresTiros == true && tempoTirosDiagonal <= 20 && tiros.Length < 15) // instancia os tiros na diagonal
        {
            GetComponent<AudioSource>().Play();
            Instantiate(tiro, new Vector3(transform.position.x + 0.5f, transform.position.y, 0), Quaternion.identity);
            Instantiate(tiro, new Vector3(transform.position.x + 0.5f, transform.position.y, 0), Quaternion.Euler(new Vector3(337.8273f, 40.21981f, 24.05018f)));
            Instantiate(tiro, new Vector3(transform.position.x + 0.5f, transform.position.y, 0), Quaternion.Euler(new Vector3(17.05888f, 42.29848f, 342.1302f)));
        }

        if (tempo > 1)  // instancia o inimigo 
        {
            Instantiate(nave, new Vector3(transform.position.x + 20f, (Random.Range(-4.5f, 4.8f)), 0),Quaternion.identity);
            tempo = 0;
            inimigosInstanciados += 1;
        }

        if (tempoHorda > 10) // instancia a horda de inimigos
        {
            Instantiate(Hordas[Random.Range(0, 5)], new Vector3(transform.position.x + 20f , 3.96f ,0), Quaternion.identity);
            tempoHorda = 0;
        }

        if (PlayerPrefs.GetString("playerOneName") == "")
        {
            Pontos.text = "player: " + pontos.ToString(); 
        }

        else
        {
            Pontos.text = PlayerPrefs.GetString("playerOneName") + ": " + pontos.ToString();
        }


    }
}
