using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExample: MonoBehaviour
{
    // 변수: 값을 담는 글릇
    // 자료형: 그 그릇의 모양

    // 변수의 선언 -> 자료형 식별자;
    int a;

    private void Start()
    {
        Debug.Log(a);
        // 값을 지정하지 않아도 Console창에는 0이 출력됨
        // why? 
    }
}
