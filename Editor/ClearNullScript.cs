using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class ClearNullScript 
{
#if UNITY_EDITOR
    [MenuItem("CleanUp/RMSR")]
    private static void FindAndRemoveMissingInSelected()
    {
        var deepSelection = EditorUtility.CollectDeepHierarchy(Selection.gameObjects);
        int compCount = 0;
        int goCount = 0;
        foreach(var o in deepSelection)
        {
            if(o is GameObject go)
            {
                int count = GameObjectUtility.GetMonoBehavioursWithMissingScriptCount(go);
                if(count > 0)
                {
                    Undo.RegisterCompleteObjectUndo(go, "Remove missing Script");
                    GameObjectUtility.RemoveMonoBehavioursWithMissingScript(go);
                    compCount += count;
                    goCount++;
                }
            }
        }
    }
#endif
}
