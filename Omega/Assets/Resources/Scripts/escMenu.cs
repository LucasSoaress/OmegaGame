using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class escMenu : MonoBehaviour
{
    public Canvas Menu;
    private bool MenuAtivo;
    public static bool menuFechado;

    void Start ()
    {
        Menu = Menu.GetComponent<Canvas>();
        Menu.enabled = false;
        menuFechado = true;
        Time.timeScale = 1f;
        Cursor.visible = false;
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))

        {
            if (MenuAtivo == true)
            {
                MenuAtivo = false;
                menuFechado = true;
                Time.timeScale = 1f;
                Cursor.visible = false;
            }

            else if (MenuAtivo == false)
            {
                MenuAtivo = true;
                menuFechado = false;
                Time.timeScale = 0f;
                Cursor.visible = true;
            }
        }

        if (MenuAtivo == true)
        {
            Menu.enabled = true;
        }

        else
        {
            Menu.enabled = false;
        }
    }

    public void Fechar()
    {
        Application.Quit();
    }

    public void MenuPrincipal()
    {
        Application.LoadLevel("mainMenu");
    }
}
