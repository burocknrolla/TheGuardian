using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOperator : MonoBehaviour
{
    public Transform player;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire()
    {
        Instantiate(bullet, player.position, Quaternion.identity);
    }
}
