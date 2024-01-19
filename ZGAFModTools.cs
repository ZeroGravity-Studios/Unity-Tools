using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class SettingsMenu : MonoBehaviour
{
    [MenuItem("ZGAF Mod Tools//Lighting/Apply Lights To Empties")]
    static void ApplyLightToEmpty()
    {
        var lightObject = Selection.activeGameObject;

        for (int i = 0; i < lightObject.transform.childCount; i++)
        {
            GameObject child = lightObject.transform.GetChild(i).gameObject;

            if (child.name.Contains("Lights"))
            {
                child.AddComponent<Light>();
                Debug.Log("Added light to " + child.name);
            }

        }

    }

    [MenuItem("ZGAF Mod Tools/Lighting/Remove Lights From Empties")]
    static void RemoveLightToEmpty()
    {
        var lightObject = Selection.activeGameObject;

        for (int i = 0; i < lightObject.transform.childCount; i++)
        {
            GameObject child = lightObject.transform.GetChild(i).gameObject;

            if (child.name.Contains("Lights"))
            {
                Component lightComponent = child.GetComponent<Light>();
                DestroyImmediate(lightComponent);

                Debug.Log("Removed light From " + child.name);
            }

        }

    }

    [MenuItem("ZGAF Mod Tools/DunGen/Add Doors To Empties")]
    static void AddDoorToEmpty()
    {
        var meshObject = Selection.activeGameObject;

        for (int i = 0; i < meshObject.transform.childCount; i++)
        {
            GameObject child = meshObject.transform.GetChild(i).gameObject;

            if (child.name.Contains("DunGenDoor"))
            {
                child.AddComponent<DunGen.Doorway>();

                Debug.Log("Added Door To " + child.name);
            }

        }

    }

}
