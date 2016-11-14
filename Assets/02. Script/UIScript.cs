using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class UIScript : MonoBehaviour
{


    public void Scene_SimonSays()
    {
        Debug.Log("Click Scene_SimonSays");
        SceneManager.LoadScene("Scene_SimonSays");
    }

    public void Scene_TicTacToe()
    {
        Debug.Log("Click Scene_TicTacToe");
        SceneManager.LoadScene("Scene_TicTacToe");
    }
    public void Scene_LunarBomb()
    {
        Debug.Log("Click Scene_LunarBomb");
        SceneManager.LoadScene("Scene_LunarBomb");
    }
    public void Scene_SpaceShooter()
    {
        Debug.Log("Click Scene_SpaceShooter");
        SceneManager.LoadScene("Scene_SpaceShooter");
    }

    public void BackToMenu()
    {
        Debug.Log("Click BackToMenu");
        SceneManager.LoadScene("Scene_Menu");
    }

    public void Scene_Config()
    {
        Debug.Log("Click Scene_Config");
        SceneManager.LoadScene("Scene_Config");
    }

}
