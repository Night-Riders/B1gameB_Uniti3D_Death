using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusObject : MonoBehaviour {

        
        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.name == "Bonus Time")
            {
                Destroy(col.gameObject);
            }
        }
       
}