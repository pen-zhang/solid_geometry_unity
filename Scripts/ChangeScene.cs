using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void Load(string name)
    {
        SceneManager.LoadScene(name);

    }
}