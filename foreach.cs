using UnityEngine;

public class foreach : MonoBehaviour
{
    int[] = numbers = {1, 2, 3, 4, 5};

    void Start(){
        /*foreach(변수의 타입 변수의 식별자 in 배열의 식별자){
            반복 내용
        }
        */
        foreach(int number in numbers){
            Debug.Log(number);
        }
    }
}
