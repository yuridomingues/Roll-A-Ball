using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    [SerializeField] private string minigame;
    [SerializeField] private GameObject principalMenu; 
    // public void Start()
    // {
    //     SceneManager.LoadScene(minigame);
    // }

    public void Play(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void Exit()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }


}
