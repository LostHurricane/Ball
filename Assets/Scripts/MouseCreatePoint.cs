using System.Collections;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace GeekProject
{
	//[ExecuteInEditMode]
	public class MouseCreatePoint// : MonoBehaviour
    {
        public void MakePoint (out Vector3 value)
        {
			
				Ray ray = Camera.current.ScreenPointToRay(new Vector3(Event.current.mousePosition.x, SceneView.currentDrawingSceneView.camera.pixelHeight - Event.current.mousePosition.y));

				if (Physics.Raycast(ray, out var hit))
				{

					value = hit.point;
					
				}
				else value = Vector3.zero;

		}

	}
}