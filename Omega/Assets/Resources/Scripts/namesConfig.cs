using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class namesConfig : MonoBehaviour
{
    public InputField playerOne;
    public InputField playerTwo;

	void Start ()
    {
        playerOne.text = PlayerPrefs.GetString("playerOneName");
        playerTwo.text = PlayerPrefs.GetString("playerTwoName");   
	}
	
	void Update ()
    {
        PlayerPrefs.SetString("playerOneName", playerOne.text);
        PlayerPrefs.SetString("playerTwoName", playerTwo.text);
	}

    public void verificaNomes()
    {
        Application.LoadLevel("mainMenu");
    }
}
