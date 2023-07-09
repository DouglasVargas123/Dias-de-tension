using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BottomBarController : MonoBehaviour
{
    public TextMeshProUGUI barText;
    public TextMeshProUGUI personNameText;
    public Image personImage;

    private int sentenceIndex = -1;
    public StoryScene currentScene;
    private State state = State.COMPLETED;

    public GameObject panelInicio;
    public GameObject panelTransicion;
    public GameObject panelPrimeraEscena;
    public GameObject UI;

    public GameController gameController;

    public GameObject FinTransmision;

    public bool Camara = false;

    public Reloj reloj;


    public void IniciarTexto()
    {
        Cursor.lockState = CursorLockMode.Locked;
        PlayScene(gameController.currentScene);
        StartCoroutine(Transicion());
        reloj.StartCoroutine(reloj.Tiempo());
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
        personImage.sprite = currentScene.sentences[sentenceIndex].speaker.Imagen;
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
        personImage.sprite = currentScene.sentences[sentenceIndex].speaker.Imagen;
    }

    public void SwitchImage()
    {

        if (personNameText.text == "Camara")
        {
            panelPrimeraEscena.SetActive(false);
            FinTransmision.SetActive(true);
            UI.SetActive(true);           
            Camara = true;            
        }
    }
}
