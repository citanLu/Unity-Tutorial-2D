using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;

    public float rotSpeed = 30f; // 자전 속도

    public float revolutionSpeed = 100f; // 공전 속도

    public bool isRevolution = false; // 논리 타입 -> true / false

    void Update()
    {
        // 자전 기능
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);

        if (isRevolution == true) // 조건문 -> 만약 공전한다면
        {
            // 공전 기능
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime);
        }
    }
}