using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackRange : MonoBehaviour
{
    [SerializeField] float attackRange = 60.0f;
    [SerializeField] GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        if(camera == null) {
            camera = GameObject.FindGameObjectWithTag("MainCamera");
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject opponent in camera.GetComponent<OpponentList>().getOpponentsList()) {
            if(Vector3.Distance(opponent.gameObject.transform.position, this.transform.position) <= attackRange) {
                Debug.Log("Enemy Found");
            }
        }
    }
}
