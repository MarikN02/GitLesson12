using System.Collections;
using UnityEngine;

public class CorutineSemple : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1.0f;
        Coroutine coroutine = StartCoroutine(timer());
        
    }

    private IEnumerator timer()
    {
        for(int i = 1; i <= 10; i++)
        {
            yield return new WaitForSeconds(1); 
            yield return new WaitForSecondsRealtime(1); 
            
            Debug.Log(i);
        }
            


    }
}
