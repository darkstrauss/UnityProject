using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region INSTANCE
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
    #endregion

    #region VARIABLES
    private bool enablePlacement = false;
    private ITower.TowerType TowerPlacementType = ITower.TowerType.None;
    private GameObject previewPlacementTower = null;
    [SerializeField]
    private SO_Tower[] sO_Towers = null;
    #endregion

    public void EnablePlacement(bool i_enable)
    {
        enablePlacement = i_enable;
    }
    public void SetTowerPlacementType(int i_typeIndex)
    {
        TowerPlacementType = (ITower.TowerType)i_typeIndex;
    }

    private void Update()
    {
        if (!enablePlacement) { return; }

        Ray placementRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit placementHitInfo;
        if (Physics.Raycast(placementRay, out placementHitInfo))
        {
            if (previewPlacementTower == null)
            {
                switch (TowerPlacementType)
                {
                    case ITower.TowerType.None:

                        break;
                    case ITower.TowerType.Cannon:
                        previewPlacementTower = Instantiate(sO_Towers[0].Prefab, placementHitInfo.point, Quaternion.identity);
                        break;
                    case ITower.TowerType.PoisonSprayer:
                        break;
                    case ITower.TowerType.FlameThrower:
                        break;
                    case ITower.TowerType.Lazor:
                        break;
                    default:
                        break;
                }
            }
            previewPlacementTower.transform.position = placementHitInfo.point;
        }
        else
        {
            if (previewPlacementTower != null)
            {
                Destroy(previewPlacementTower);
                previewPlacementTower = null;
            }
        }

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
