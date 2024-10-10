using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDistance : MonoBehaviour
{
  public GameObject cubo;
  public GameObject cilindro;

  void Start()
  {
    cubo = GameObject.FindWithTag("cubo");
    cilindro = GameObject.FindWithTag("cilindro");
    float distanciaCubo = Vector3.Distance(transform.position, cubo.transform.position);
    float distanciaCilindro = Vector3.Distance(transform.position, cilindro.transform.position);
    Debug.Log($"Distancia al cubo: {distanciaCubo}");
    Debug.Log($"Distancia al cilindro: {distanciaCilindro}");
  }
}