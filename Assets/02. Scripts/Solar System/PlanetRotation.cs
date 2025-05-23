using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;

    public float rotSpeed = 30f; // ���� �ӵ�

    public float revolutionSpeed = 100f; // ���� �ӵ�

    public bool isRevolution = false; // �� Ÿ�� -> true / false

    void Update()
    {
        // ���� ���
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);

        if (isRevolution == true) // ���ǹ� -> ���� �����Ѵٸ�
        {
            // ���� ���
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime);
        }
    }
}