using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SubirScript : MonoBehaviour
{
    public TMP_InputField Nombre_IF;
    public TMP_InputField Apellido_IF;
    string nombre;
    string apellido;
    string sql;

    public void OnSubirClick()
    {
        nombre = Nombre_IF.text;
        apellido = Apellido_IF.text;
        Nombre_IF.text = "";
        Apellido_IF.text = "";

        Debug.Log("Nombre: " + nombre + "\nApellido: " + apellido);
        sql = "INSERT INTO Board (Nombre, Apellido) VALUES ('" + nombre + "', '" + apellido + "')";
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
