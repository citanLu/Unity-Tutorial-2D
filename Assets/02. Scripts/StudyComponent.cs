using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj; // ť�� ���� ������Ʈ�� �������� �ʹ�

    public string changeName;

    void Start()
    {
        obj = GameObject.Find("Main Camera");
        // Main Camera ������Ʈ�� ã�Ƽ� �Ҵ��ϴ� ���

        obj.name = changeName;
    }
}