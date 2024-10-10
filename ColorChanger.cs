using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
  public GameObject cilindro;
  public GameObject cubo;

  private Material m_MaterialCilindro;
  private Material m_MaterialCubo;

  void Start()
  {
    cilindro = GameObject.FindWithTag("cilindro");
    cubo = GameObject.FindWithTag("cubo");
    m_MaterialCilindro = cilindro.GetComponent<Renderer>().material;
    m_MaterialCubo = cubo.GetComponent<Renderer>().material;
  }

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.C))
    {
      CambiarColor(m_MaterialCilindro);
    }

    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      CambiarColor(m_MaterialCubo);
    }
  }

  private void CambiarColor(Material m_Material)
  {
    Vector3 colorVector = new Vector3(
        Random.Range(0f, 1f),
        Random.Range(0f, 1f),
        Random.Range(0f, 1f)
    );

    // Convertimos el Vector3 a Color
    Color nuevoColor = new Color(colorVector.x, colorVector.y, colorVector.z);

    m_Material.color = nuevoColor;
  }
}