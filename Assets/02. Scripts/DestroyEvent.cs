using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destroytime = 3f;

    void Start()
    {
        Destroy(this.gameObject, destroytime); // �ڱ� �ڽ��� n�� �ڿ� �ı��ϴ� ���
    }

    void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name}�� �ı��Ǿ����ϴ�");
    }
}