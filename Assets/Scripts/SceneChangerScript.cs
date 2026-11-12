using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneChangerScript : MonoBehaviour
{
    public void ExitGame()
    {
        StartCoroutine(Exit());
    }

    IEnumerator Exit()
    {
        yield return new WaitForSeconds(0.8f);

        if(UnityEditor.EditorApplication.isPlaying)
            UnityEditor.EditorApplication.isPlaying = false;
        else
            Application.Quit();
    }
}


// Fonā jāpievieno animēti mākoņi, kas lidinās apkārt
/* Jāizstrādā jauna aina priekš Settings ar:
 * 1) Iespēju mainīt mūzikas skaļumu
 * 2) Iespēju mainīt skaņas efektu skaļumu
 * 3) Pārslēgt manuāli dziesmu
 * 4) Mainīt spēles rezulūciju
 * 5) Mainīt spēles kvalitāti
 * 6) Viena paša izdomāta funkcionalitāte
 * 7) Poga, kas atgriež uz galveno izvēlni
 */