using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1, number2;

    void Start()
    {
        int addResult = AddMethod(); // �Լ� ȣ��

        int minusResult = MinusMethod(); // �Լ� ȣ��

        Debug.Log($"���� �� : {addResult} / �� �� : {minusResult}");
    }

    int AddMethod()
    {
        int result = number1 + number2;

        return result;
    }

    int MinusMethod()
    {
        int result = number1 - number2;

        return result;
    }
}
