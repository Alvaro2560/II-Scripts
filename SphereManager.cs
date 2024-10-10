using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SphereManager : MonoBehaviour
{
  public GameObject cubo;
  public string etiquetaGrupo2 = "esfera_grupo2";
  public float incrementoAltura = 0.5f;

  private GameObject[] esferasGrupo2;

  void Start()
  {
    cubo = GameObject.FindWithTag("cubo");
    esferasGrupo2 = GameObject.FindGameObjectsWithTag(etiquetaGrupo2);
  }

  void Update()
  {
    GameObject[] esferasOrdenadas = esferasGrupo2.OrderBy(
      esfera => Vector3.Distance(cubo.transform.position, esfera.transform.position)
    ).ToArray();
    GameObject esferaMasCercana = esferasOrdenadas[0];
    if (esferaMasCercana != null)
    {
      esferaMasCercana.transform.position += Vector3.up * incrementoAltura * Time.deltaTime;
    }

    if (Input.GetKeyDown(KeyCode.Space))
    {
      GameObject esferaMasLejana = esferasOrdenadas[esferasOrdenadas.Length - 1];
      if (esferaMasLejana != null)
      {
        CambiarColor(esferaMasLejana);
      }
    }
  }

  void CambiarColor(GameObject esfera)
  {
    Renderer renderer = esfera.GetComponent<Renderer>();
    renderer.material.color = new Color(
      Random.Range(0f, 1f),
      Random.Range(0f, 1f),
      Random.Range(0f, 1f)
    );
  }
}