using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudanza : MonoBehaviour
{
    public float pesoAMudar;
    public float distanciaALlevar;
    int horasNecesarias;
    int capUtiliario = 2000;
    int capPickup = 5000;
    int capCamion = 10000;
    int precioUt = 3000;
    int precioPi = 4500;
    int precioCa = 7000;
    int distanciaXHora = 25;
    string tipoVehiculo = "";
    int precioXHora = 0;
    int precioTotal= 0;
    // Start is called before the first frame update
    void Start()
    {
        if (pesoAMudar > 10000)
        {
            Debug.Log("Desmasiado pesado, ingrese otro peso");
            
        }if (pesoAMudar < 1000)
        {
            Debug.Log("Desmasiado liviano, ingrese otro peso");
            return;
        }
        horasNecesarias = 2;
        if (distanciaALlevar < 1)
        {
            Debug.Log("Ingrese una distancia valida");
            return;
        }
        if (distanciaALlevar > 50)
        {
            horasNecesarias += 1;
        }
        if (pesoAMudar <= capUtiliario)
        {
            tipoVehiculo = "Utilitario";
            precioXHora = precioUt;
        }
        else if (pesoAMudar <= capPickup)
        {
            tipoVehiculo = "Pickup";
            precioXHora = precioPi;
        }
        else if (pesoAMudar <= capCamion)
        {
            tipoVehiculo = "Camión";
            precioXHora = precioCa;
        }
        int precioTotal = horasNecesarias * precioXHora;

        Debug.Log("Precio total por " + horasNecesarias + " horas a " + precioXHora + ": $" + precioTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
