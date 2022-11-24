using System.Collections;
using UnityEngine;

public class Percabangan : MonoBehaviour {
    int nilai = 88;
    void Start(){
        if (nilai > 80){
            Debug.Log("Nilai A");
        }else if (nilai > 60 && nilai <= 80) {
            Debug.Log("Nilai B");
        }else if (nilai > 40 && nilai <= 60) {
            Debug.Log("Nilai C");
        }else{
            Debug.Log("Nilai D");
        }
    }
}
