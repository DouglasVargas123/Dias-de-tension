using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Carta : MonoBehaviour
{
    public Contactos[] contactos;
    public TextMeshProUGUI[] Nombres;
    public TextMeshProUGUI[] Numeros;
    public bool inCarta = false;
    public GameObject cartaUI;
    public GameObject UINormal;



    public void AbrirCarta()
    {
        Nombres[0].text = contactos[0].nombre;
        Numeros[0].text = contactos[0].numero;

        Nombres[1].text = contactos[1].nombre;
        Numeros[1].text = contactos[1].numero;

        Nombres[2].text = contactos[2].nombre;
        Numeros[2].text = contactos[2].numero;

        Nombres[3].text = contactos[3].nombre;
        Numeros[3].text = contactos[3].numero;

        Nombres[4].text = contactos[4].nombre;
        Numeros[4].text = contactos[4].numero;

        Nombres[5].text = contactos[5].nombre;
        Numeros[5].text = contactos[5].numero;
        Cursor.lockState = CursorLockMode.None;
        cartaUI.SetActive(true);
        UINormal.SetActive(false);
        inCarta = true;
    }

    public void CerrarCarta()
    {
        inCarta = false;
        UINormal.SetActive(true);
        cartaUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;

    }
}
