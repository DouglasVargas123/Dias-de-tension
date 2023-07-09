using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuInicio : MonoBehaviour
{
    public GameObject panelJugar;
    public GameObject panelOpciones;
    public GameObject panelTransicion;
    public GameObject panelComoseJuega;
    public GameObject panelVolumen;

    //Opciones
    public void TRANSICIONAOPCIONES()
    {
        StartCoroutine(OPCIONES());   
    }
    public void TRANSICIONVOLVER()
    {
        StartCoroutine(VOLVERAJUGAR());
    }

    public void TRANSICIONCOMOJUGAR()
    {
        StartCoroutine(COMOJUGAR());
    }

    public void VOLVERAOPCIONESDESPUESDEVERCOMOSEJUEGA()
    {
        StartCoroutine(VOLVERAOPCIONES());
    }

    public void BOTONVULUMEN()
    {
        StartCoroutine(VOLUMEN());
    }

    public void BOTONVOLVERDELAUDIO()
    {
        StartCoroutine(VOLVERDEVOLUMENAOPCIONES());
    }


    IEnumerator OPCIONES()
    {
        panelJugar.SetActive(false);
        panelTransicion.SetActive(true);
        AudioManager.instance.PlayAudio(AudioManager.instance.Estatica);
        yield return new WaitForSeconds(0.5f);
        panelTransicion.SetActive(false);
        panelOpciones.SetActive(true);
        yield return null;
    }
    IEnumerator VOLVERAJUGAR()
    {
        panelOpciones.SetActive(false);
        panelTransicion.SetActive(true);
        AudioManager.instance.PlayAudio(AudioManager.instance.Estatica);
        yield return new WaitForSeconds(0.5f);
        panelTransicion.SetActive(false);
        panelJugar.SetActive(true);
        yield return null;
    }

    IEnumerator VOLVERAOPCIONES()
    {
        panelComoseJuega.SetActive(false);
        panelTransicion.SetActive(true);
        AudioManager.instance.PlayAudio(AudioManager.instance.Estatica);
        yield return new WaitForSeconds(0.5f);
        panelTransicion.SetActive(false);
        panelOpciones.SetActive(true);
        yield return null;
    }

    IEnumerator COMOJUGAR()
    {
        panelOpciones.SetActive(false);
        panelTransicion.SetActive(true);
        AudioManager.instance.PlayAudio(AudioManager.instance.Estatica);
        yield return new WaitForSeconds(0.5f);
        panelTransicion.SetActive(false);
        panelComoseJuega.SetActive(true);
        yield return null;
    }

    IEnumerator VOLUMEN()
    {
        panelOpciones.SetActive(false);
        panelTransicion.SetActive(true);
        AudioManager.instance.PlayAudio(AudioManager.instance.Estatica);
        yield return new WaitForSeconds(0.5f);
        panelTransicion.SetActive(false);
        panelVolumen.SetActive(true);
        yield return null;
    }

    IEnumerator VOLVERDEVOLUMENAOPCIONES()
    {
        panelVolumen.SetActive(false);
        panelTransicion.SetActive(true);
        AudioManager.instance.PlayAudio(AudioManager.instance.Estatica);
        yield return new WaitForSeconds(0.5f);
        panelTransicion.SetActive(false);
        panelOpciones.SetActive(true);
        yield return null;
    }
}
