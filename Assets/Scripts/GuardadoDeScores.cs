using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;
using System.Linq;

public class GuardadoDeScores : MonoBehaviour
{
    [SerializeField] Text textoScore; // NUM DEL SCORE QUE SE VA A GUARDAR EN LA DATABASE
    public InputField nombreDelJugador; // ESPACIO DONDE EL JUGADOR ESCRIBE SU NOMBRE PARA SER GUARDADO EN LA DATABASE

    public string URLdeDatabase = "https://jgprogavnzda21empedrodgz-default-rtdb.firebaseio.com/";

    private System.Random random = new System.Random();

    Jugador jugador = new Jugador(); // CONSTRUIMOS LA CLASE "Jugador"

    public static int playerScore;
    public static string playerName;

    void Start()
    {
        textoScore.text = "SCORE: " + GameManager.scoreDeLaPartida;
    }


    private void UpdateScore() // EN LA PANTALLA DE "Ver score" MOSTRAMOS EL NOMBRE Y PUNTAJE DE 'x' JUGADOR PREVIO QUE FUE GUARDADO EN LA DATABASE
    {
        textoScore.text = jugador.nombreJugador + " logró " + jugador.scoreLogradoPorJugador + " puntos ";
    }
    private void PostToDataBase()
    {
        Jugador jugador = new Jugador(); // NO SE SI CORRESPONDE CREARLO RECIEN ACA O AL PRINCIPIO, COMO EN LA LINEA 18

        // VI QUE SI NO DECLARO EL NEW USER ACA, EN LA DATABASE AL SUBMITTEAR CADA NUEVA PARTIDA JUGADA
        // EL JUGADOR APARECE SIN NOMBRE Y CON SCORE 0!!!!

        RestClient.Put(URLdeDatabase + playerName + ".json", jugador);

    }
    public void OnSubmit()
    {
        playerName = nombreDelJugador.text;
        PostToDataBase();
    }
    private void RetrieveFromDataBase()
    {
        RestClient.Get<Jugador>(URLdeDatabase + nombreDelJugador.text + ".json").Then(response =>

        {
            jugador = response; // LEO DE MANERA INDIVIDUAL CADA USUARIO GUARDADO; ESTO PERMITE QUE EL BOTON "GET SCORE" ANDE
            UpdateScore();
        });
    }
    public void OnGetScore()
    {
        RetrieveFromDataBase();
    }


}
