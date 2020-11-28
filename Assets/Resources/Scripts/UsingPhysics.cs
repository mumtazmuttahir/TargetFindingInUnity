using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingPhysics : MonoBehaviour
{
    [SerializeField] float attackRange = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //https://docs.unity3d.com/ScriptReference/Physics.OverlapSphere.html
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, attackRange);
        foreach (Collider item in hitColliders) {
            Debug.Log ("Enemy found with name = " + item.gameObject.name);
        }
        
    }
}
