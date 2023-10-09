using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenExample : MonoBehaviour
{
    // 토큰이란?
    // 문장을 이루는 최소 단위
    // ex) new 는 새롭다 라는 뜻을 가지고 있지만 "ew"만 있거나 "n ew"만 있다고 그 뜻을 갖지 않는것 처럼
    //     문장을 구성할때는 최소한으로 지켜야 하는 구성요소들을 말한다.

    // 토큰의 종류?
    // 1. 예약어: C#에서 미리 정해놓은 토큰
    // 2. 식별자: 이름
    // 3. 리터럴: 값
    // 4. 연산자: 연산을 하기위한 토큰 ex) +,- 등등
    // 5. 구분자: 특정 요소를 문법적으로 구분하기 위한 토큰

    int a = 1;
    // int -> 예약어(키워드)
    // a   -> 식별자
    // =   -> 연산자
    // 1   -> 리터럴
    // ;   -> 구분자
}
