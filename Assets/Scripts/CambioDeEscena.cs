using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Proyecto26;
using System.Linq;

public class CambioDeEscena : MonoBehaviour
{
    public void CargaScene(string nombreEscenaDeJuego)
    {
        SceneManager.LoadScene(nombreEscenaDeJuego);
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }
}
