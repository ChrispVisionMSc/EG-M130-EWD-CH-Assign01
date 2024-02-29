using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

//public class HeadHitting : MonoBehaviour
//{
//     public float headHittingCount;
//    public class SaveObject
//        {

//            public float headHittingCount;
//        }
//    public void save()
//        {
//            Debug.Log("saving to " + Application.dataPath);

//            SaveObject saveObject = new SaveObject()
//            {
//                headHittingCount = headHittingCount,

//            };
//            string json = JsonUtility.ToJson(saveObject);
//            File.WriteAllText(Application.dataPath + "/save.txt", json);

//        }
    public class Entertrigger : MonoBehaviour
    { 
        
        public GameObject redCube;
        public float headHittingCount;
        // Start is called before the first frame update



        public void OnTriggerEnter(Collider MainCamera)
        {
            redCube.SetActive(true);
            headHittingCount++;
            Debug.Log("ouch" + headHittingCount + "\n\n");
        }
        public void OnTriggerExit(Collider MainCamera)
        {
            redCube.SetActive(false);
        }
    }
}
