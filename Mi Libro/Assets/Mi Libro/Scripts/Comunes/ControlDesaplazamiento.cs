using UnityEngine;
using System.Collections;

public class ControlDesaplazamiento : MonoBehaviour
{

    private float limitDespla = 170.0f;
    public GameObject desplazado;

    public void Update()
    {
        if (desplazado.transform.position.x >= limitDespla)
        {

        }
    }
}
