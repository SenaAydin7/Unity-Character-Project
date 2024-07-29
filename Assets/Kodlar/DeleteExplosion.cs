using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteExplosion : MonoBehaviour
{
    [SerializeField] GameObject SmallExplosion;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            Instantiate(SmallExplosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
