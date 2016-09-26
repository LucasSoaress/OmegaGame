using UnityEngine;
using System.Collections;

public class instanciarPowerUp : MonoBehaviour
{
    private float tempoPower;
    public Transform Power;

	void Start ()
    {
        tempoPower = 0;
	}
	
	void Update ()
    {
        tempoPower = tempoPower + 1 * Time.deltaTime;

        if (tempoPower >= 20)
        {
            Instantiate(Power, new Vector3((Random.Range(-8.5f,8.5f)),(Random.Range(-4.5f, 4.8f)), 0), Quaternion.identity);
            tempoPower = 0;
        }
	}
}
