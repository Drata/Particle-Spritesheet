using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour {

    [System.Serializable]
    public struct SistemaTiempo {
        public ParticleSystem ps;
        public float tiempo;
    }

    public SistemaTiempo[] sistemas;

	// Use this for initialization
	void Start () {
        StartCoroutine(Emite());	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Emite()
    {
        foreach (SistemaTiempo st in sistemas)
        {
            st.ps.Play();
            yield return new WaitForSeconds(st.tiempo);
            st.ps.Stop();
        }
        
    }
}
