using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

[CustomEditor(typeof(Effects2DComponent))]
[CanEditMultipleObjects]
public class Effects2DEditor : Editor
{
    private SerializedProperty _effectType;
    private SerializedProperty _lifeTime;
    private SerializedProperty _fadeOutTime;
    private SerializedProperty _throwForce;
    private SerializedProperty _gravityForce;
    private SerializedProperty _useRandomDirection;
    private SerializedProperty _useFadeOutToDisable;
    private SerializedProperty _stickFiguresRends;
    private SerializedProperty _rb2D;
    private SerializedProperty _direction;

    private void OnEnable()
    {
        _effectType = serializedObject.FindProperty("effect");
        _lifeTime = serializedObject.FindProperty("lifeTime");
        _fadeOutTime = serializedObject.FindProperty("fadeOutTime");
        _throwForce = serializedObject.FindProperty("throwForce");
        _gravityForce = serializedObject.FindProperty("gravityTime");

        _useRandomDirection = serializedObject.FindProperty("useRandomDirection");
        _useFadeOutToDisable = serializedObject.FindProperty("useFadeOutToDisable");

        _stickFiguresRends = serializedObject.FindProperty("stickFiguresRenderers");
        _rb2D = serializedObject.FindProperty("rb2D");
        _direction = serializedObject.FindProperty("direction");


    }
    public override void OnInspectorGUI()
    {        
        GUI.enabled = false;

        EditorGUILayout.ObjectField("Script", MonoScript.FromMonoBehaviour((MonoBehaviour)target), typeof(Effects2DComponent), false);
        
        GUI.enabled = true;

        serializedObject.Update();              
        
        EditorGUILayout.PropertyField(_effectType);
        
        if(!_useFadeOutToDisable.boolValue)
        {
            EditorGUILayout.PropertyField(_lifeTime);
        }

        EditorGUILayout.Space();
        EditorGUILayout.PropertyField(_useFadeOutToDisable);
        
        if (_useFadeOutToDisable.boolValue)
        {
            EditorGUILayout.PropertyField(_fadeOutTime);
        }

        EditorGUILayout.Space();
        
        if(_effectType.enumValueIndex == 1)
        {
            EditorGUILayout.PropertyField(_throwForce);
            EditorGUILayout.PropertyField(_gravityForce);
            EditorGUILayout.PropertyField(_rb2D);

            EditorGUILayout.Space();
            EditorGUILayout.PropertyField(_useRandomDirection);

            if (!_useRandomDirection.boolValue)
                EditorGUILayout.PropertyField(_direction);            
        }                

        EditorGUILayout.Space();
        EditorGUILayout.PropertyField(_stickFiguresRends);

        serializedObject.ApplyModifiedProperties();        
    }    
}
