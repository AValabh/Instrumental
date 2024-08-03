using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardSound : MonoBehaviour
{
    GameObject Q;
    GameObject W;
    GameObject E;
    GameObject R;
    GameObject T;
    GameObject Y;
    GameObject U;

    GameObject A;
    GameObject S;
    GameObject D;
    GameObject F;
    GameObject G;
    GameObject H;
    GameObject J;

    GameObject Z;
    GameObject X;
    GameObject C;
    GameObject V;
    GameObject B;
    GameObject N;
    GameObject M;

    // Start is called before the first frame update
    void Start()
    {
        Q = GameObject.Find("3Button1");
        W = GameObject.Find("3Button2");
        E = GameObject.Find("3Button3");
        R = GameObject.Find("3Button4");
        T = GameObject.Find("3Button5");
        Y = GameObject.Find("3Button6");
        U = GameObject.Find("3Button7");

        A = GameObject.Find("2Button1");
        S = GameObject.Find("2Button2");
        D = GameObject.Find("2Button3");
        F = GameObject.Find("2Button4");
        G = GameObject.Find("2Button5");
        H = GameObject.Find("2Button6");
        J = GameObject.Find("2Button7");

        Z = GameObject.Find("1Button1");
        X = GameObject.Find("1Button2");
        C = GameObject.Find("1Button3");
        V = GameObject.Find("1Button4");
        B = GameObject.Find("1Button5");
        N = GameObject.Find("1Button6");
        M = GameObject.Find("1Button7");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Q.GetComponent<OnClickSoundButton>().PlayEffect();
            Q.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            W.GetComponent<OnClickSoundButton>().PlayEffect();
            W.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            E.GetComponent<OnClickSoundButton>().PlayEffect();
            E.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            R.GetComponent<OnClickSoundButton>().PlayEffect();
            R.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            T.GetComponent<OnClickSoundButton>().PlayEffect();
            T.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Y.GetComponent<OnClickSoundButton>().PlayEffect();
            Y.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            U.GetComponent<OnClickSoundButton>().PlayEffect();
            U.GetComponent<AudioSource>().Play();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            A.GetComponent<OnClickSoundButton>().PlayEffect();
            A.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            S.GetComponent<OnClickSoundButton>().PlayEffect();
            S.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            D.GetComponent<OnClickSoundButton>().PlayEffect();
            D.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            F.GetComponent<OnClickSoundButton>().PlayEffect();
            F.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            G.GetComponent<OnClickSoundButton>().PlayEffect();
            G.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            H.GetComponent<OnClickSoundButton>().PlayEffect();
            H.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            J.GetComponent<OnClickSoundButton>().PlayEffect();
            J.GetComponent<AudioSource>().Play();
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Z.GetComponent<OnClickSoundButton>().PlayEffect();
            Z.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            X.GetComponent<OnClickSoundButton>().PlayEffect();
            X.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            C.GetComponent<OnClickSoundButton>().PlayEffect();
            C.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            V.GetComponent<OnClickSoundButton>().PlayEffect();
            V.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            B.GetComponent<OnClickSoundButton>().PlayEffect();
            B.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            N.GetComponent<OnClickSoundButton>().PlayEffect();
            N.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            M.GetComponent<OnClickSoundButton>().PlayEffect();
            M.GetComponent<AudioSource>().Play();
        }
    }
}
