using UnityEngine;
using UnityEngine.SceneManagement;

//dont destroy on load, to set assets(music etc) to the game and not a scene
//Will always load the scene that is on top of the build setting option

public class DDOL : MonoBehaviour
{
	private void Awake()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene(1);
    }
}
