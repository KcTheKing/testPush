using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBar : MonoBehaviour
{
    public Transform transforms;
    public static float speed;
    public float life = 12f;
    
    void Update()
    {
        transform.position += new Vector3(0, speed*Time.deltaTime, 0);
    }

    private void Awake()
    {
        Destroy(gameObject,life);
    }
}
