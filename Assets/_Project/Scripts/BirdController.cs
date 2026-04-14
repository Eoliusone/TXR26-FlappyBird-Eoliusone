using UnityEngine;

public class BirdController : MonoBehaviour
{
    private Transform monTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        monTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        monTransform.position += new Vector3(0.01f,0, 0);
    }
}
