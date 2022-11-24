using System.Collections;
using UnityEngine;

public class PercabanganSwitchCase : MonoBehaviour
{
    int angka = 2;
    void Start() {
        switch (angka)
        {
            case 1:
                Debug.Log("Tahu");
            break;
            case 2:
                Debug.Log("Ayam Goreng");
            break;
            case 3:
                Debug.Log("Sate Kambing");
            break;
            default:
                Debug.Log("Jus Jeruk");
            break;
        }
    }
}
