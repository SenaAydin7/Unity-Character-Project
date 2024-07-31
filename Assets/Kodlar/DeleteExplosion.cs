using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteExplosion : MonoBehaviour
{
    void Start()
    {
        Invoke("DeleteIt", 1f);
    }
    
    private void DeleteIt()
    {
        Destroy(gameObject);
    }
}
