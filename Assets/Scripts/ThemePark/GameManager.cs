using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton instance
    private static GameManager _instance;

    // Property to access the singleton instance
    public static GameManager Instance
    {
        get
        {
            // If the instance doesn't exist, try to find it in the scene
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();

                // If it still doesn't exist, create a new GameObject with GameManager attached
                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject("GameManager");
                    _instance = singletonObject.AddComponent<GameManager>();
                }
            }

            return _instance;
        }
    }

    // Your GameManager functionality goes here

    void Awake()
    {
        // Ensure there is only one instance of GameManager
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    // Example method for GameManager functionality
    public void StartThemePark()
    {
        Debug.Log("Theme park is now open!");
        // Implement any initialization or game start logic here

        // debug log the name of the active scene
        Debug.Log("Active scene is: " + UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
