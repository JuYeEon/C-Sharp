using UnityEngine;


public class 1 : MonoBehaviour {
    //배열 선언
    //자료형[] 이름 = new 자료형[배열 크기];
    int[] scores = new int[3];
    int[] scores2 = new int[]{100, 200, 300};
    int[] scores3 = {100, 200, 300};

    void Start(){
        Debug.Log(scores3[0]);
        scores3[1] = 50;

        Debug.Log(scores3[1]);
    }
}
