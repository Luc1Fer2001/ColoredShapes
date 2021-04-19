using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRaycast : MonoBehaviour
{
    private GeometryObjectModel geometryObjectModel;
    private Camera cameraMain;

    private void Awake()
    {
        cameraMain = Camera.main;
    }
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(cameraMain.transform.position, cameraMain.ScreenPointToRay(Input.mousePosition).direction, out hit))
        {
            geometryObjectModel = hit.collider.GetComponent<GeometryObjectModel>();
            if(geometryObjectModel != null)
            {
                geometryObjectModel.clickCount++;
                CheckClickCount(hit.collider.gameObject, geometryObjectModel.clickCount);
            }
        }
    }

    private void CheckClickCount(GameObject gameObject, int clickCount)
    {
        var clickColorData = gameObject.GetComponent<ClickColorGetData>();
        int minClickCount = clickColorData.ClickColor.minClicksCount;
        int maxClickCount = clickColorData.ClickColor.maxClicksCount;
        Color color = clickColorData.ClickColor.color;
        if(clickCount >= minClickCount && clickCount <= maxClickCount)
        {
            SetColorClick(color, gameObject);
        }
    }

    private void SetColorClick(Color color, GameObject targetSetColor)
    {
        targetSetColor.GetComponent<Renderer>().material.color = color;
        targetSetColor.GetComponent<GeometryObjectModel>().geometryColor = color;
        targetSetColor.GetComponent<RandomColorByTimer>().PublicTimer.Restart();
    }
}
