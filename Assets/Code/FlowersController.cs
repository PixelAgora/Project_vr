/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowersController : MonoBehaviour
{
  [SerializeField] private List<FlowerDefinition> definitions;
  [SerializeField] private int minimumFlowersOfType;
  [SerializeField] private int maximumFlowersOfType;

  private Dictionary<FlowerType,int> currentFlowersSet = new Dictionary<FlowerType,int>();

  private void PrepareNewSet()
  {
    currentFlowersSet.Clear();
    foreach(FlowerType type in Enum.GetValues(typeof(FlowerType)))
    {
      int flowersAmount = Random.Range(minimumFlowersOfType, maximumFlowersOfType);
      currentFlowersSet.Add(type,flowersAmount);
    }
  }
}*/
