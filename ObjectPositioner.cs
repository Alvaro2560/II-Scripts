using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPositioner : MonoBehaviour
{
  public GameObject cubo;
  public GameObject esfera;
  public GameObject cilindro;

  public Vector3 desplazamiento1;
  public Vector3 desplazamiento2;
  public Vector3 desplazamiento3;

  private Vector3 posicionOriginal1;
  private Vector3 posicionOriginal2;
  private Vector3 posicionOriginal3;

  void Start()
  {
    cubo = GameObject.FindWithTag("cubo");
    esfera = GameObject.FindWithTag("esfera");
    cilindro = GameObject.FindWithTag("cilindro");
    posicionOriginal1 = cubo.transform.position;
    posicionOriginal2 = esfera.transform.position;
    posicionOriginal3 = cilindro.transform.position;
  }

  void Update()
  {
    if (Input.GetAxis("Jump") > 0)
    {
      cubo.transform.position = posicionOriginal1 + desplazamiento1;
      esfera.transform.position = posicionOriginal2 + desplazamiento2;
      cilindro.transform.position = posicionOriginal3 + desplazamiento3;
    }
  }
}