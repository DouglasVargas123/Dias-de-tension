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
                bottomBarController.PlayNextSentence();
                
            }
        }

        if (bottomBarController.Camara == true)
        {

        }
    }

    IEnumerator TRANSICIONAGAMEPLAY()
    {

        yield return null;
    }
}
