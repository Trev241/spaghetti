using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, startPos;
    public Camera cameraObj;
    public float parallaxEffect = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float temp = cameraObj.transform.position.x * (1 - parallaxEffect);
        float distance = cameraObj.transform.position.x * parallaxEffect;
        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

        if (temp > startPos + length) startPos += length;
        else if (temp < startPos - length) startPos -= length;
    }
}
