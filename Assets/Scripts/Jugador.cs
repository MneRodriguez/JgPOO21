using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Proyecto26;
using System.Linq;

[Serializable]

public class Jugador
{
    public string nombreJugador { get; set; }
    public int scoreLogradoPorJugador { get; set; }

    public Jugador()
    {
        //nombreJugador = nombre;
        //scoreLogradoPorJugador = scoreObtenido;
        
        // HASTA AHI EL CONSTRUCTOR, AHORA DEFINO ESTAS VARIABLES CON AQUELLAS RESPECTIVAS PARA QUE LA INFO SE GUARDE EN LA DATABASE

        // ¿ESTO CUENTA COMO CONSTRUCTOR?
        nombreJugador = GuardadoDeScores.playerName;
        scoreLogradoPorJugador = GameManager.scoreDeLaPartida;
    }

    // EJEMPLO DE HERENCIA
    /*public class Jgdr : Jugador
    {
        // CREO CONSTRUCTOR PUBLICO DE LA CLASE; "base" LLAMA AL CONSTRUCTOR "public Jugador" DE LA BASE!!!
        public Jugador (string nombre, int puntaje) : base(nombre, puntaje)

    }*/

    /*public string nombreJugador
    {
        get { }
    }*/


    /* METODO DONDE SE TOMA EL INPUT DEL JUGADOR EN CADA EJERCICIO

    public void IngresoRespuestas()
    {
        public InputField rtaFCE1, rtaFCE2, rtaFCE3, rtaCAE1, rtaCAE2, rtaCAE3, rtaCPE1, rtaCPE2, rtaCPE3;
    } */             
}
