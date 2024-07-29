using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickFaller : MonoBehaviour
{
    [SerializeField] GameObject Rock;
    GameObject Player;
    float SonDusenZamani;
    float TetiklenmeZamani;
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        SonDusenZamani = 0F;
        TetiklenmeZamani = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 RockSpawnPosition;
        if (Time.time >= TetiklenmeZamani + SonDusenZamani)
        {
            SonDusenZamani = Time.time;
            RockSpawnPosition = Player.transform.position;
            RockSpawnPosition.y += 5f;
            Instantiate(Rock,RockSpawnPosition, Quaternion.identity);
        }
        
    }
}
