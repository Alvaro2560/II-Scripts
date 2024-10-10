using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectName : MonoBehaviour
{
  void Start()
  {
    Debug.Log("Nombre del objeto: " + gameObject.name);
  }
}