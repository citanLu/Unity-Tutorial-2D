using UnityEngine;

public class StudyGameobject : MonoBehaviour
{
    public GameObject prefab;

    void Awake()
    {
        CreateAmongus();
    }

    void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab);

        obj.name = "어몽어스 캐릭터";

        //Debug.Log($"캐릭터의 자식 오브젝트 수 : {obj.transform.childCount}");

        //Debug.Log($"캐릭터의 첫번째 자식 오브젝트 수 : {obj.transform.GetChild(0).name}");

        //Debug.Log($"캐릭터의 마지막 자식 오브젝트 수 : {obj.transform.GetChild(obj.transform.childCount - 1).name}");
    }
}