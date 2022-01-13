using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicGameObject : MonoBehaviour
{
   private static MusicGameObject instance;
   private void Awake() {
       if(instance == null){
          instance=this;
          DontDestroyOnLoad(instance);

       }
       else{
          Destroy(gameObject);
       }
   }
}
