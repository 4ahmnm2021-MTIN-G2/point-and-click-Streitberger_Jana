using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public GameObject bookOpen;
        
        public void OnMouseDown()
    {
        bookOpen.SetActive(true);
        StartCoroutine(Reading());

        IEnumerator Reading()
        {
            yield return new WaitForSeconds(3);
            bookOpen.SetActive(false);
        }
      
    }
}
