using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    ////Instancia de la clase
    [Header("Level Data")]
    public Subject Lesson;

    [Header("User Interface")]
    public TMP_Text QuestionTxt;
    public TMP_Text livestxt;
    public List<OptionBtm> Options;
    public GameObject CheckButton;
    public GameObject AnswerContainer;
    public Color Green;
    public Color Red;

    [Header("Game Configuration")]
    public int questionAmount = 0;
    public int currentQuestion = 0;
    public string question;
    public string correctAnswer;
    public int answerFromPlayer;
    public int lives = 5;

    [Header("Current Lesson")]
    public Leccion currentLesson;


    ////(.5 pts perdidos) Patron Singleton: Es un patron de diseño, encargado de crear una instancia de la clase


    //private void Awake()
    //{
    //    if (Instance != null)
    //    {
    //        return;
    //    }
    //    else
    //    {
    //        Instance = this;
    //    }
    //}
    //// Start is called before the first frame update
    //void Start()
    //{
    //    //Establecemos la cantidad de preguntas en la leccion
    //    questionAmount = Lesson.leccionList.Count;
    //    //cargar la primera pregunta
    //    LoadQuestion();
    //    //check player input
    //    CheckPlayerState();
    //}

    //private void LoadQuestion()
    //{
    //    //aseguramos que la pregunta actiual esté dentro de los límites
    //    if (currentQuestion < questionAmount)
    //    {
    //        //establecemos la lección actual
    //        currentLesson = Lesson.leccionList[currentQuestion];
    //        //establecemos la pregunta
    //        question = currentLesson.lessons;
    //        //establecemos la respuesta correcta
    //        correctAnswer = currentLesson.options[currentLesson.correctAnswer];
    //        //establecemos la pregunta en UI
    //        QuestionTxt.text = question;
    //        //establecemos las opciones 
    //        for (int i = 0; i < currentLesson.options.Count; i++)
    //        {
    //            Options[0].GetComponent<OptionBtm>().OptionName = currentLesson.options[0];
    //            Options[0].GetComponent<OptionBtm>().OptionID = i;
    //            Options[0].GetComponent<OptionBtm>().UpdateText();


    //        }

    //    }
    //    else
    //    {
    //        //si llegamos al final de las preguntas
    //        Debug.Log("Fin de las preguntas");
    //    }

    //}

    //public void NextQuestion()
    //{
    //    if (CheckPlayerState())
    //    {
    //        //Revisamos si la respuesta es correcta o no
    //        bool isCorrect = currentLesson.options[answerFromPlayer] == correctAnswer;

    //        AnswerContainer.SetActive(true);

    //        if (isCorrect )
    //        {
    //            AnswerContainer.GetComponent<Image>().color = Green;
    //            Debug.Log("Respuesta correcta.  " + question + ": " + correctAnswer);
    //        }
    //        else
    //        {
    //            AnswerContainer.GetComponent<Image>().color = Red;
    //            Debug.Log("Respuesta incorrecta.  " + question + ": " + correctAnswer);
    //        }

    //        //Actualizamos el contador de las vidas
    //        livesTxt.text = lives.ToString();

    //        //Incrementamos el indice de la pregunta actual
    //        currentQuestion++;

    //        //mostramos el resulatdo durante un tiempo 
    //        StartCoroutine(ShowResultAndLoadQuestion(isCorrect));

    //        //Reset answer from player
    //        answerFromPlayer = 9;
    //    }
    //    else
    //    {
    //        //Cambio de Escena
    //    }
    //}

    //private IEnumerator ShowResultAndLoadQuestion()
    //{
    //    yield return new WaitForSeconds(2.5f); //ajustar el tiempo que deseas mostrar el resultado


    //    //cargar nueva pregunta
    //    LoadQuestion();

    //    //Activa el botón luego de mostrar el resultado
    //     CheckPlayerState();
    //}

    //public void SetPlayerAnswer(int _answer)
    //{
    //    answerFromPlayer = _answer;
    //}

    //public bool CheckPlayerState()
    //{
    //    if (answerFromPlayer != 0)
    //    {
    //        CheckButton.GetComponent<Button>().interctable = true;
    //        CheckButton.GetComponent<Image>().color = Color.white;
    //    }
    //    else
    //    {
    //        CheckButton.GetComponent<Button>().interctable = false;
    //        CheckButton.GetComponent<Image>().color = Color.grey;

    //    }
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
