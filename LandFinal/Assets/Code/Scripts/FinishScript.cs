using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour {

    public void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Finish")
        {

            Destroy(this.gameObject); // Вместо этой строчки пишешь что будет происходить после того как доедешь до финиша, в данном случае машина удалиться с сцены.

        }

    }

}


