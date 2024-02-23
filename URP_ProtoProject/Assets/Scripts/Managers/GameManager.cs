using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        // Check if the left mouse button is pressed
        if (Input.GetMouseButtonDown(0))
        {
            // Cast a ray from the mouse position into the scene
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Create a RaycastHit variable to store information about what the ray hits
            RaycastHit hitInfo;

            // Perform the raycast
            if (Physics.Raycast(ray, out hitInfo))
            {
                // Check if the ray hits something
                Debug.Log("Hit something!");

                // Access information about the object that was hit
                Debug.Log("Hit object name: " + hitInfo.collider.gameObject.name);
                Debug.Log("Hit point: " + hitInfo.point);
                Debug.Log("Hit normal: " + hitInfo.normal);
            }
            else
            {
                // If the ray does not hit anything
                Debug.Log("Did not hit anything.");
            }
        }
    }
}
