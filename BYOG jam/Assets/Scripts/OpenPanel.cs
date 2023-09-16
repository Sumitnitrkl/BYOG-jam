using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{

    public GameObject panelToOpen;

    private bool isGamePaused = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (panelToOpen != null)
            {
                // Enable the panel
                panelToOpen.SetActive(true);
                PauseGame();
            }
        }
    }

    private void PauseGame()
    {
        isGamePaused = true;
        Time.timeScale = 0f; // Pause the game
    }

    public void ResumeGame()
    {
        isGamePaused = false;
        Time.timeScale = 1f; // Resume the game
        panelToOpen.SetActive(false); // Disable the panel
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
