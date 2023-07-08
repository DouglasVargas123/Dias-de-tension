using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BottomBarController : MonoBehaviour
{
    public TextMeshProUGUI barText;
    public TextMeshProUGUI personNameText;

    private int sentenceIndex = -1;
    public StoryScene currentScene;
    private State state = State.COMPLETED;

    public GameObject panelInicio;
    public GameObject panelTransicion;
    public GameObject panelPrimeraEscena;

    public GameController gameController;

    public GameObject Kennedy;
    public GameObject Castro;
    public GameObject Nikita;
    public GameObject Barco;
    public GameObject CamaraImagen;

    public bool Camara = false;


    public void IniciarTexto()
    {
        PlayScene(gameController.currentScene);
        StartCoroutine(Transicion());
    }

    public void Update()
    {
        SwitchImage();
    }

    public void PlayScene(StoryScene scene)
    {
        currentScene = scene;
        sentenceIndex = -1;
    }

    public void PlayNextSentence()
    {
        StartCoroutine(TypeText(currentScene.sentences[++sentenceIndex].text));
        personNameText.text = currentScene.sentences[sentenceIndex].speaker.speakerName;
        personNameText.color = currentScene.sentences[sentenceIndex].speaker.textColor;
    }

    public bool IsCompleted()
    {
        return state == State.COMPLETED;
    }

    private enum State
    {
        PLAYING, COMPLETED
    }

    public bool IsLastSentence()
    {
        return sentenceIndex + 1 == currentScene.sentences.Count;
    }
    

    public IEnumerator TypeText(string text)
    {
        barText.text = "";
        state = State.PLAYING;
        int wordIndex = 0;

        while(state != State.COMPLETED)
        {
            barText.text += text[wordIndex];
            yield return new WaitForSeconds(0.05f);
            if(++wordIndex == text.Length)
            {
                state = State.COMPLETED;
                break;
            }
        }
    }

    public IEnumerator Transicion()
    {
        panelInicio.SetActive(false);
        panelTransicion.SetActive(true);
        AudioManager.instance.PlayAudio(AudioManager.instance.Estatica);
        yield return new WaitForSeconds(0.5f);
        panelTransicion.SetActive(false);
        panelPrimeraEscena.SetActive(true);
        StartCoroutine(TypeText(currentScene.sentences[++sentenceIndex].text));
        personNameText.text = currentScene.sentences[sentenceIndex].speaker.speakerName;
        personNameText.color = currentScene.sentences[sentenceIndex].speaker.textColor;
    }

    public void SwitchImage()
    {
        if (personNameText.text == "John F. Kennedy")
        {
            Kennedy.SetActive(true);
            Castro.SetActive(false);
            Nikita.SetActive(false);
            Barco.SetActive(false);
            CamaraImagen.SetActive(false);
        }
        else if(personNameText.text == "Fidel Castro")
        {
            Kennedy.SetActive(false);
            Castro.SetActive(true);
            Nikita.SetActive(false);
            Barco.SetActive(false);
            CamaraImagen.SetActive(false);
        }
        else if (personNameText.text == "Nikita Jrushchov")
        {
            Kennedy.SetActive(false);
            Castro.SetActive(false);
            Nikita.SetActive(true);
            Barco.SetActive(false);
            CamaraImagen.SetActive(false);
        }
        else if (personNameText.text == "Barco")
        {
            Kennedy.SetActive(false);
            Castro.SetActive(false);
            Nikita.SetActive(false);
            Barco.SetActive(true);
            CamaraImagen.SetActive(false);
        }
        else if (personNameText.text == "Camara")
        {
            Kennedy.SetActive(false);
            Castro.SetActive(false);
            Nikita.SetActive(false);
            Barco.SetActive(false);
            CamaraImagen.SetActive(true);
            Camara = true;
        }

    }
}
