using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGeometry : MonoBehaviour
{
    [SerializeField]
    private GameObject[] prefabs;
    private GameObject prefab;
    private Camera cameraMain;

    private void Awake()
    {
        cameraMain = Camera.main;
    }

    private void OnMouseDown()
    {
        prefab = prefabs[Random.Range(0, prefabs.Length)];
        var groundPlane = new Plane(Vector3.up, Vector3.zero);
        Ray ray = cameraMain.ScreenPointToRay(Input.mousePosition);

        if (groundPlane.Raycast(ray, out float position))
        {
            Vector3 worlPosition = ray.GetPoint(position);

            Instantiate(prefab, new Vector3(worlPosition.x, worlPosition.y, worlPosition.z), Quaternion.identity);
        }
    }
}
