using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//el script se puede convertir en una secuencia de bytes para su almacenamiento o transmisi�n
[System.Serializable]

public class Leccion
{
    //representa el identificador �nico de la lecci�n
    public int ID;
    //sirve para el almacenamiento de la lecci�n en formato de texto
    public string lessons;
    //contiene una lista de opciones para la lecci�n
    public List<string> options;
    //indica la opci�n correcta dentro de la lista
    public int correctAnswer;
}
