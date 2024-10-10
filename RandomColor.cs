using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
  public int currentFrames = 0;
  public int framesUntilChange = 120;
  private Color color;

  private void ApplyColor()
  {
    GetComponent<Renderer>().material.color = color;
  }
  void Start()
  {
    color = new Color(
      Random.Range(0f, 1f), 
      Random.Range(0f, 1f), 
      Random.Range(0f, 1f)
    );
    transform.position = new Vector3(
      Random.Range(-80f, 80f),
      Random.Range(-80f, 80f),
      Random.Range(-80f, 80f)
    );
    ApplyColor();
  }
  void Update()
  {
    currentFrames++;
    if (currentFrames == framesUntilChange)
    {
      color = new Color(
        Random.Range(0f, 1f), 
        Random.Range(0f, 1f), 
        Random.Range(0f, 1f)
      );
      ApplyColor();
      transform.position = new Vector3(
        Random.Range(-80f, 80f),
        Random.Range(-80f, 80f),
        Random.Range(-80f, 80f)
      );
      currentFrames = 0;
    }
  }
}