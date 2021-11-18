using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;

namespace GeekProject
{
    public class InteractiveObjectChecker : EditorWindow
    {
        private List<Object> _components;
        private string _path;
        private TrapAndBonusesDataBase _trapAndBonusesDataBase;
        private Vector3[] _coordinates;
        private bool _foldout = false;
        private bool _addNew = false;


        CoordinatePoint cp;

        //MouseCreatePoint _mousePointer;

        

        private void OnGUI()
        {
            
            _path = EditorGUILayout.TextField("TrapAndBonusesDataBase");
            var SetPathButton = GUILayout.Button("Refresh");
            
            if (SetPathButton)
            {
                LoadCoordinates(_path);
                
            }
            
            if (_trapAndBonusesDataBase) _foldout = EditorGUILayout.Foldout(_foldout, "Coordinates");
            if (_foldout && _coordinates.Length!=0)
            {
                for (var i = 0; i < _coordinates.Length; i++)
                {                   
                    EditorGUILayout.Vector3Field("Точка " + (i+1).ToString(), _coordinates[i]) ;
                }
            }

            _addNew = GUILayout.Toggle(_addNew, "Add point to file");
            if (_addNew)
            {
                cp = FindObjectOfType<CoordinatePoint>();

                if (!cp)
                {
                    cp = Instantiate(_trapAndBonusesDataBase.GetCoordinatePoint(), new Vector3(0f, 2.5f, 0f), Quaternion.identity);
                }
                
                  

                var _setExtraCoordinates = GUILayout.Button("Choose coordinates");
                if (_setExtraCoordinates)
                {
                    _trapAndBonusesDataBase.AddPoint(cp.transform.position);
                    LoadCoordinates(_path);
                    EditorUtility.SetDirty(_trapAndBonusesDataBase);
                    // _trapAndBonusesDataBase.SetDirty();
                }
            }

        }

        private void LoadCoordinates(string path)
        {
            _trapAndBonusesDataBase = Resources.Load<TrapAndBonusesDataBase>(Path.Combine("Data/" + path));
            _coordinates = _trapAndBonusesDataBase.GetCoordinates();
        }

    }
}