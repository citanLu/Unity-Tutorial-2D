using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destroytime = 3f;

    void Start()
    {
        Destroy(this.gameObject, destroytime); // 자기 자신을 n초 뒤에 파괴하는 기능
    }

    void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name}이 파괴되었습니다");
    }
}