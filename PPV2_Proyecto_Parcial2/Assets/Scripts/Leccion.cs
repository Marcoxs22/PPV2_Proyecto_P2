using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//el script se puede convertir en una secuencia de bytes para su almacenamiento o transmisión
[System.Serializable]

public class Leccion
{
    //representa el identificador único de la lección
    public int ID;
    //sirve para el almacenamiento de la lección en formato de texto
    public string lessons;
    //contiene una lista de opciones para la lección
    public List<string> options;
    //indica la opción correcta dentro de la lista
    public int correctAnswer;
}
