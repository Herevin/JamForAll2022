using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesligarAutomatico : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine(Desativar());
        GetComponent<AudioSource>().Play();
    }

   IEnumerator Desativar()
    {
        yield return new WaitForSeconds(1.3f);
        this.gameObject.SetActive(false);
    }
}
