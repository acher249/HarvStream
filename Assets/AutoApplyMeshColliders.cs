using UnityEngine;
using UnityEditor;
using System.Collections;
using System;

public class AutoApplyMeshColliders : ScriptableWizard
{
    // RootParent needs to be a prefab ///////////////////////////////////////////////
    public GameObject RootParent;


    [MenuItem("SHoP Utilities/Add Colliders")]
    static void CreateWizard()
    {
        ScriptableWizard.DisplayWizard("Automatically Add Colliders", typeof(AutoApplyMeshColliders), "Bingo Bango");
    }

    void OnWizardCreate()
    {
        // Map Textures
        Debug.Log("adding colliders..");

        // Getting all children and putting them in an array (even inactive)
        var RootChildren = RootParent.GetComponentsInChildren<Transform>(true);
        AddColliders(RootChildren);
    }

    void AddColliders(Transform[] trans)
    {
        Debug.Log("entered Addcolliders");
        foreach(var t in trans)
        {
            Debug.Log(t.gameObject.name + " being examined");
            if(t.gameObject.GetComponent<MeshRenderer>()!=null && t.gameObject.GetComponent<MeshCollider>() == null)
            {
                t.gameObject.AddComponent<MeshCollider>();
                Debug.Log(t.gameObject.name + " being added");

            }
        }
    }
    
}
