/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
  [SerializeField] private List<FlowerDefinition> fdefinitions;
  [SerializeField] private List<VaseDefinition> vdefinisions;
  [SerializeField] private int numberFlowersOfType = 1;
  [SerializeField] private int numberVaseOfType = 1;
  
  //[SerializeField] private int maximumFlowersOfType;

  //private Dictionary<FlowerType,int> currentFlowersSet = new Dictionary<FlowerType,int>();
  private Dictionary<FlowerType,int> currentFlowerSet = new Dictionary<FlowerType,int>();
  private Dictionary<VaseType,int> currentVaseSet = new Dictionary<VaseType,int>();

  /*private void PrepareNewSet()
  {
    currentFlowersSet.Clear();
    foreach(FlowerType type in Enum.GetValues(typeof(FlowerType)))
    {
      int flowersAmount = Random.Range(minimumFlowersOfType, maximumFlowersOfType);
      currentFlowersSet.Add(type,flowersAmount);
    }
  }

  private void PrepareNewSet()
  {
    currentFlowerSet.Clear();
    currentVaseSet.Clear();
    foreach(FlowerType type in Enum.GetValues(typeof(FlowerType)))
    {
      currentFlowerSet.Add(type,numberFlowersOfType);
      Debug.Log(currentFlowerSet);
    }
    foreach(VaseType type in Enum.GetValues(typeof(VaseType)))
    {
      currentVaseSet.Add(type,numberVaseOfType);
      Debug.Log(currentVaseSet);
    }
  }
}*/
