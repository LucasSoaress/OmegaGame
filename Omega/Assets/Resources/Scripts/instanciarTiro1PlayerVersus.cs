using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class instanciarTiro1PlayerVersus : MonoBehaviour
{
    public Transform tiro;
    public static float tempoTirosDiagonal;
    public static bool tresTiros;
    private GameObject[] tiros;

    void Start()
    {
        tresTiros = false;
    }

    void Update()
    {
        tiros = GameObject.FindGameObjectsWithTag("Tiro");
        tempoTirosDiagonal = tempoTirosDiagonal + 1 * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && tiros.Length < 5 && escMenu.menuFechado == true) 
        {
            GetComponent<AudioSource>().Play();
            Instantiate(tiro, new Vector3(transform.position.x + 0.5f, transform.position.y, 0), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Space) && tresTiros == true && tempoTirosDiagonal <= 20 && tiros.Length < 15) 
        {
            GetComponent<AudioSource>().Play();
            Instantiate(tiro, new Vector3(transform.position.x + 0.5f, transform.position.y, 0), Quaternion.identity);
            Instantiate(tiro, new Vector3(transform.position.x + 0.5f, transform.position.y, 0), Quaternion.Euler(new Vector3(337.8273f, 40.21981f, 24.05018f)));
            Instantiate(tiro, new Vector3(transform.position.x + 0.5f, transform.position.y, 0), Quaternion.Euler(new Vector3(17.05888f, 42.29848f, 342.1302f)));
        }
    }

}
