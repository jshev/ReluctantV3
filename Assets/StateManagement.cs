using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManagement : MonoBehaviour
{
    public enum GameState { MenuState, BlackState, RedState};
	public GameState currentGameState;

    public GameObject Menu;
	public GameObject RedSwirl;
	public GameObject BlackSwirl;

    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        // load Title state on play
		currentGameState = GameState.RedState;
		ShowScreen (RedSwirl);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("B key was pressed. Loading Black State.");
            currentGameState = GameState.BlackState;
            ShowScreen (BlackSwirl);
            Player.transform.position = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R key was pressed. Loading Red State.");
            currentGameState = GameState.RedState;
            ShowScreen (RedSwirl);
            Player.transform.position = new Vector3(0, 0, 0);
        }
    }

    void ShowScreen(GameObject gameObjectToShow) {
		// deactivate all state gameobjects
		Menu.SetActive(false);
		RedSwirl.SetActive(false);
		BlackSwirl.SetActive(false);

		// activate gameobect of current state
		gameObjectToShow.SetActive(true);
	}
}
