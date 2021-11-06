using UnityEditor;

namespace GeekProject
{
	public class MenuItems
	{
		[MenuItem("Geekbrains/InteractiveObjectChecker")]
		private static void MenuOption()
		{
			EditorWindow.GetWindow(typeof(InteractiveObjectChecker), false, "Geekbrains");
		}
	}
}