using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MainCameraControl : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;
    [SerializeField]
    private GameObject targetObject;

    // Start is called before the first frame update
    void Start()
    {
        if (mainCamera == null)
        {
            Debug.LogError("MainCamera is Null");
        }

        if(targetObject == null)
        {
            Debug.LogError("Target is Null.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.transform.LookAt(targetObject.transform);
    }
}
