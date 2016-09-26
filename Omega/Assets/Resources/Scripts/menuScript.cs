using UnityEngine;
using System.Collections;

public class menuScript : MonoBehaviour 
{

    void Start()
    {
        Cursor.visible = true;
    }

    public void FirstLevel()
    {
        Application.LoadLevel("FirstLevel");
    }

    public void Credits()
    {
        Application.LoadLevel("Credits");
    }

    public void More()
    {
        Application.LoadLevel("more");
    }

    public void Sair()
    {
        Application.Quit();
    }

    public void SecondLevel()
    {
        Application.LoadLevel("secondLevel");
    }

    public void SecondMenu()
    {
        Application.LoadLevel("secondMenu");
    }

    public void Versus()
    {
        Application.LoadLevel("versus");
    }

    public void MainMenu()
    {
        Application.LoadLevel("mainMenu");
    }

    public void Facebook()
    {
        Application.OpenURL("https://www.facebook.com/OMEGA-GAME-122928068134856/");
    }

    public void namesConfig()
    {
        Application.LoadLevel("namesConfig");
    }

    public void aboutGradius()
    {
        Application.LoadLevel("about");
    }

    public void mostrarScore()
    {
        Application.LoadLevel("scores");
    }

}
