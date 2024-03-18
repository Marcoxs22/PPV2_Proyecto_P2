using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//indica a Unity que cree un men� en el editor para crear instancias de este ScriptableObject. fileName especifica el nombre del archivo cuando se crea una nueva instancia, menuName especifica la ruta del men� donde aparecer� en el editor de Unity, y order determina el orden en el que aparecer� en el men�
[CreateAssetMenu(fileName = "New Subject", menuName = "ScriptableObjects/NewLesson", order = 1)]

//define una clase Subject que hereda de ScriptableObject, lo que indica que esta clase representa un objeto de script que se puede crear, configurar y guardar en el proyecto de Unity
public class Subject : ScriptableObject
{
    //coloca un encabezado en el inspector para agrupar variables bajo la categor�a "GameObject Configuration"
    [Header("GameObject Configuration")]
    //declara una variable p�blica Lessson e inicializa su valor en 0
    public int Lessson = 0;

    //coloca un encabezado en el inspector para agrupar variables bajo la categor�a "Lesson Quest Configuration"
    [Header("Lesson Quest Configuration")]
    //declara una lista p�blica Leccion, que contiene objetos de la clase Leccion. Esta lista representa la configuraci�n de las lecciones relacionadas con el tema (Subject)
    public List<Leccion> leccionList;
}
