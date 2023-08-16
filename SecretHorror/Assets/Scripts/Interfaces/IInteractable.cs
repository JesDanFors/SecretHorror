using UnityEngine;

public interface IInteractable 
{
   public void Interact(){
      Debug.Log("I was Interacted");
      //TODO: Make sure that all object that can be interacted with uses this
   }
}
