using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverE : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI name;

    [SerializeField]
    TextMeshProUGUI ganaste;
    

    void Start() // O puede ser Awake()
    {
        // Accede a la instancia de StateManager
        StateManager stateManager = StateManager.Instance;


        // Obtiene los datos del StateManager
        string playerName = stateManager.getName();
        float totalWin = stateManager.GetTotalWin(); // Asume que tienes una variable TotalWin en StateManager

        // Configura los campos de texto
        name.text = "Nombre: " + playerName;
        ganaste.text = "Total Ganado: $" + totalWin.ToString("F2");
    }
}
