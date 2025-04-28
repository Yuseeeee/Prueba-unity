using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudanza : MonoBehaviour
{
    public float pesoAMudar;
    public float distanciaALlevar;
    int capUtiliario = 2000;
    int capPickup = 5000;
    int capCamion = 10000;
    int precioUt = 3000;
    int precioPi = 4500;
    int precioCa = 7000;
    int distanciaXHora = 25;
    // Start is called before the first frame update
    void Start()
    {
        if (pesoAMudar > 10000)
        {
            Debug.Log("Desmasiado pesado, ingrese otro peso");
            return;
        }
        
        if (distanciaALlevar < 1)
        {
            Debug.Log("Ingrese una distancia valida");
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
