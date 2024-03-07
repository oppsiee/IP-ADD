using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    [SerializeField]
    private int sceneIndexToLoad = 1;

    public void PlayGames()
    {
        SceneManager.LoadSceneAsync(sceneIndexToLoad);
    }
}
