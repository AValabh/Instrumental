using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickSoundButton : MonoBehaviour
{
    public GameObject effect;
    GameObject EffectHolder;
    public AudioSource Sound;
    public AudioClip[] notes;
    public void PlayEffect()
    {
        EffectHolder = GameObject.Find("Effects");
        Instantiate(effect, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z) , Quaternion.identity, EffectHolder.transform);
    }
    public void PlaySound()
    {
        Sound = this.gameObject.GetComponent<AudioSource>();
        if(notes.Length == 1)
        {
            Sound.PlayOneShot(notes[0], 1);
        }
        if (notes.Length == 2)
        {
            Sound.PlayOneShot(notes[0], 1);
            Sound.PlayOneShot(notes[1], 1);
        }
    }
}
