using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorCalculations : MonoBehaviour
{
  public Vector3 vector1;
  public Vector3 vector2;
  public float magnitud1;
  public float magnitud2;
  public float angulo;
  public float distancia;
  public string altura;

  void Start()
  {
    vector1 = new Vector3(1f, 6f, 3.5f);
    vector2 = new Vector3(4.1f, 5.9f, 6.7f);
    CalculateVectorProperties();
  }

  void CalculateVectorProperties()
  {
    magnitud1 = vector1.magnitude;
    magnitud2 = vector2.magnitude;
    angulo = Vector3.Angle(vector1, vector2);
    distancia = Vector3.Distance(vector1, vector2);
    altura = vector1.y > vector2.y ? "Vector1 está más alto" : "Vector2 está más alto";
    Debug.Log($"Magnitud Vector1: {magnitud1}");
    Debug.Log($"Magnitud Vector2: {magnitud2}");
    Debug.Log($"Ángulo entre vectores: {angulo}");
    Debug.Log($"Distancia entre vectores: {distancia}");
    Debug.Log(altura);
  }
}