

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief パッケージ更新。
*/


/** BlueBack.Install.Editor
*/
#if(UNITY_EDITOR)
namespace BlueBack.Install.Editor
{
	/** UpdatePackage_Unity
	*/
	public static class UpdatePackage_Unity
	{
		/** MenuItem_Mathematics
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/Unity.Mathematics")]
		public static void MenuItem_Mathematics()
		{
			const string t_name = "com.unity.mathematics";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Burst
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/Unity.Burst")]
		public static void MenuItem_Burst()
		{
			const string t_name = "com.unity.burst";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Ugui
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/Unity.Ugui")]
		public static void MenuItem_Ugui()
		{
			const string t_name = "com.unity.ugui";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
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

