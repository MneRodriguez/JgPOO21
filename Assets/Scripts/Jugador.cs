using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;
using System.Linq;

[Serializable]

public class Jugador
{
    public string nombreJugador { get; set; };
    public int scoreLogradoPorJugador { get; set; };

    public Jugador()
    {
        nombreJugador = GuardadoDeScores.playerName;
        scoreLogradoPorJugador = GameManager.scoreDeLaPartida;
    }

    public string nombreJugador
    {
        get { }
    }
}
