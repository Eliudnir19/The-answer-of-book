using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public Button playButton;
    public Button optionsButton;
    public Button quitButton;
    public Button backButton;
    public VisualElement mainMenu;
    public VisualElement optionsMenu;

    private void Awake()
    {

        var root = GetComponent<UIDocument>().rootVisualElement;


        playButton = root.Q<Button>("PlayButton");
        optionsButton = root.Q<Button>("OptionsButton");
        quitButton = root.Q<Button>("QuitButton");
        backButton = root.Q<Button>("BackButton");
        mainMenu = root.Q<VisualElement>("MainMenu");
        optionsMenu = root.Q<VisualElement>("OptionsMenu");

        playButton.clicked += PlayButtonPressed;
        optionsButton.clicked += OptionsButtonPressed;
        quitButton.clicked += QuitButtonPressed;
        backButton.clicked += BackButtonPressed;
    }

    void PlayButtonPressed()
    {
        SceneManager.LoadScene("Main");
    }

    void OptionsButtonPressed()
    {
        mainMenu.style.display = DisplayStyle.None;
        optionsMenu.style.display = DisplayStyle.Flex;
    }

    void QuitButtonPressed()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    void BackButtonPressed()
    {
        optionsMenu.style.display = DisplayStyle.None;
        mainMenu.style.display = DisplayStyle.Flex;
    }
}