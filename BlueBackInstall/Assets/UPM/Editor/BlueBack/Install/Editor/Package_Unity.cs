

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief パッケージ更新。自動生成。
*/


/** BlueBack.Install.Editor
*/
#if(UNITY_EDITOR)
namespace BlueBack.Install.Editor
{
	/** Package_Unity
	*/
	public static class Package_Unity
	{
		/** MenuItem_Add_com_unity_mathematics
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Add/com_unity_mathematics")]
		public static void MenuItem_Add_com_unity_mathematics()
		{
			string t_name = "com.unity.mathematics";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Add_com_unity_burst
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Add/com_unity_burst")]
		public static void MenuItem_Add_com_unity_burst()
		{
			string t_name = "com.unity.burst";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Add_com_unity_ugui
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Add/com_unity_ugui")]
		public static void MenuItem_Add_com_unity_ugui()
		{
			string t_name = "com.unity.ugui";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Remove_com_unity_mathematics
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Remove/com_unity_mathematics")]
		public static void MenuItem_Remove_com_unity_mathematics()
		{
			string t_name = "com.unity.mathematics";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Remove_com_unity_burst
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Remove/com_unity_burst")]
		public static void MenuItem_Remove_com_unity_burst()
		{
			string t_name = "com.unity.burst";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Remove_com_unity_ugui
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Remove/com_unity_ugui")]
		public static void MenuItem_Remove_com_unity_ugui()
		{
			string t_name = "com.unity.ugui";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

	}
}
#endif
