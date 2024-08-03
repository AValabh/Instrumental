using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEffect : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale = new Vector3(transform.localScale.x + 0.1f, transform.localScale.y + 0.1f, transform.localScale.z + 0.1f);
        Object.Destroy(gameObject, 0.5f);
    }
}
