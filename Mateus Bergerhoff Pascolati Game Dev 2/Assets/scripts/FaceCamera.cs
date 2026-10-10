using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    public float baseScale = 0.1f;
    private Camera mainCamera;
    private Vector3 startScale;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera = Camera.main;
        startScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = mainCamera.transform.rotation;
        transform.localScale = startScale * (baseScale *
            Vector3.Distance(transform.position, mainCamera.transform.position));
    }
}