using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEffectScaledown : MonoBehaviour
{
    // Update is called once per frame
    public float scaleDownSpeed;
    void Update()
    {
        this.transform.localScale = new Vector3(transform.localScale.x - scaleDownSpeed, transform.localScale.y - scaleDownSpeed, transform.localScale.z - scaleDownSpeed);
        Object.Destroy(gameObject, 2f);
    }
}
