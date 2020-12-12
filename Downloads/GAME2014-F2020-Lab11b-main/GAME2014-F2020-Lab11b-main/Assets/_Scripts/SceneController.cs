using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public AudioSource click;

    public void OnButtonPressed()
    {
        click.Play();
        SceneManager.LoadScene("Platformer");
    }

    public void onButtonPressedInstructions()
    {
        click.Play();
        SceneManager.LoadScene("Instructions");

    }
    public void onButtonPressedMenu()
    {
        click.Play();
        SceneManager.LoadScene("Start");

    }
}
