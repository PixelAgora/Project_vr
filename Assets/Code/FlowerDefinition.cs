using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlowerDefinition : ScriptableObject
{
  public FlowerType type;
  public GameObject prefab;
  public Image image;
}