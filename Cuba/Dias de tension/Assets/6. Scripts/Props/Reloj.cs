using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Reloj : MonoBehaviour
{
    public int Intervalo;
    public TextMeshProUGUI UIHORA;


    [SerializeField] private float onScreanTimer;
    [SerializeField] private GameObject extraInfoBG;
    [HideInInspector] public bool startTImer;
    private float timer;
    public BottomBarController bottomBar;

    private void Update()
    {
        if (startTImer)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                timer = 0;
                ClearAdditionalInfo();
                startTImer = false;
            }
        }
    }
    public IEnumerator Tiempo()
    {
        yield return new WaitWhile(() => bottomBar.Camara == false);
        UIHORA.text = "12:30";
        yield return new WaitForSecondsRealtime(Intervalo);
        UIHORA.text = "13:00";
        yield return new WaitForSecondsRealtime(Intervalo);
        UIHORA.text = "13:30";
        yield return new WaitForSecondsRealtime(Intervalo);
        UIHORA.text = "14:00";
        yield return new WaitForSecondsRealtime(Intervalo);
        UIHORA.text = "14:30";
        yield return new WaitForSecondsRealtime(Intervalo);
        UIHORA.text = "15:00";
        yield return new WaitForSecondsRealtime(Intervalo);
        UIHORA.text = "15:30";
        yield return new WaitForSecondsRealtime(Intervalo);
        UIHORA.text = "16:00";
        yield return new WaitForSecondsRealtime(Intervalo);
        UIHORA.text = "16:30";
        yield return new WaitForSecondsRealtime(Intervalo);
        UIHORA.text = "17:00";
        yield return new WaitForSecondsRealtime(Intervalo);
        UIHORA.text = "17:30";
        yield return new WaitForSecondsRealtime(Intervalo);
        UIHORA.text = "18:00";
        yield return new WaitForSecondsRealtime(Intervalo);
        UIHORA.text = "18:30";
        yield return new WaitForSecondsRealtime(Intervalo);
        UIHORA.text = "19:00";
        yield return new WaitForSecondsRealtime(Intervalo);
        UIHORA.text = "19:30";
        yield return null;
    }

    public void ShowAdditionalInfoReloj()
    {
        timer = onScreanTimer;
        startTImer = true;
        extraInfoBG.SetActive(true);
    }

    void ClearAdditionalInfo()
    {
        extraInfoBG.SetActive(false);
    }
}
