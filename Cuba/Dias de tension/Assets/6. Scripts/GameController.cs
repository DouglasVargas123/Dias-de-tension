using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{


    public StoryScene currentScene;
    public BottomBarController bottomBarController;

    [Header("FOV")]
    [SerializeField] Camera camera1;
    [SerializeField] Camera camera2;
    public Vector2 sens;
    public GameObject UI;

    public Carta carta;





    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && bottomBarController.Camara == false)
        {
            if (bottomBarController.IsCompleted())
            {
                if (bottomBarController.IsLastSentence())
                {
                    currentScene = currentScene.nextScene;
                    bottomBarController.PlayScene(currentScene);
                }
                else
                {
                    bottomBarController.PlayNextSentence();
                }             
            }
        }

        if(bottomBarController.Camara == true)
        {
            camera1.fieldOfView = Mathf.Lerp(camera1.fieldOfView, 80, 1f * Time.deltaTime);
            camera2.fieldOfView = Mathf.Lerp(camera2.fieldOfView, 80, 1f * Time.deltaTime);

            if(camera1.fieldOfView > 75 && camera1.fieldOfView < 85 && carta.inCarta == false)
            {
                ModoLibre();
                UI.SetActive(true);
            }
            else
            {
                UI.SetActive(false);
            }
        }
    }

    public void ModoLibre()
    {
        float hor = Input.GetAxis("Mouse X");
        float ver = Input.GetAxis("Mouse Y");
        if (hor != 0)
        {
            camera1.transform.rotation = Quaternion.Euler(camera1.transform.rotation.eulerAngles.x, camera1.transform.rotation.eulerAngles.y + hor * sens.x * Time.deltaTime, 0);
        }
        if (ver != 0)
        {
            camera1.transform.rotation = Quaternion.Euler(camera1.transform.rotation.eulerAngles.x - ver * sens.y * Time.deltaTime, camera1.transform.rotation.eulerAngles.y, 0);
        }
    }
}
