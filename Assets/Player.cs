using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    [Tooltip("In ns^-1")] [SerializeField] float xSpeed = 4f; // In meter per seconds
    [Tooltip("In m")] [SerializeField] float xRange = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        print(xThrow);

        float xOffset = xThrow * xSpeed * Time.deltaTime;
        float ramXpos = transform.localPosition.x + xOffset;
        float clampedXpos = Mathf.Clamp(ramXpos, -xRange, xRange);
        transform.localPosition = new Vector3(clampedXpos, transform.localPosition.y, transform.localPosition.z);
    }
}
