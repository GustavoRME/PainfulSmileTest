using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ChaserComponent))]
[CanEditMultipleObjects]
public class ChaserEditor : Editor
{
    private SerializedProperty _chaseMode;    
    private SerializedProperty _explosionDamage;
    private SerializedProperty _sightDistance;
    private SerializedProperty _maxDistanceToStop;
    private SerializedProperty _movementSpeed;

    private void OnEnable()
    {
        _chaseMode = serializedObject.FindProperty("chaseMode");        
        _explosionDamage = serializedObject.FindProperty("explosionDamage");
        _sightDistance = serializedObject.FindProperty("sightDistance");
        _maxDistanceToStop = serializedObject.FindProperty("distanceToStop");
        _movementSpeed = serializedObject.FindProperty("movementSpeed");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        GUI.enabled = false;
        EditorGUILayout.ObjectField("Script", MonoScript.FromMonoBehaviour((MonoBehaviour)target), typeof(ChaserComponent), false);
        GUI.enabled = true;

        EditorGUILayout.PropertyField(_chaseMode);
        EditorGUILayout.Space();
        
        EditorGUILayout.PropertyField(_sightDistance);

        EditorGUILayout.Space();
        EditorGUILayout.PropertyField(_movementSpeed);

        if(_chaseMode.enumValueIndex == 0)
        {
            EditorGUILayout.PropertyField(_maxDistanceToStop);
        }
        else
        {
            EditorGUILayout.PropertyField(_explosionDamage);
        }

        serializedObject.ApplyModifiedProperties();
    }
}
