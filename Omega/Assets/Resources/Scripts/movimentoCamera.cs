using UnityEngine;
using System.Collections;

public class movimentoCamera : MonoBehaviour 
{
    public Transform Boneco;
	
	void Update () 
    {
        transform.position = new Vector3(Boneco.position.x, transform.position.y , transform.position.z);
    }
}
