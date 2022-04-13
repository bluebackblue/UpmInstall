

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
	/** UpdatePackage_BlueBack
	*/
	public static class UpdatePackage_BlueBack
	{
		/** MenuItem_BlueBackAssetLib
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.AssetLib")]
		public static void MenuItem_BlueBackAssetLib()
		{
			string t_name = "https://github.com/bluebackblue/UpmAssetLib.git?path=BlueBackAssetLib/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_BlueBackAudio
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.Audio")]
		public static void MenuItem_BlueBackAudio()
		{
			string t_name = "https://github.com/bluebackblue/UpmAudio.git?path=BlueBackAudio/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_BlueBackCode
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.Code")]
		public static void MenuItem_BlueBackCode()
		{
			string t_name = "https://github.com/bluebackblue/UpmCode.git?path=BlueBackCode/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_BlueBackConsole
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.Console")]
		public static void MenuItem_BlueBackConsole()
		{
			string t_name = "https://github.com/bluebackblue/UpmConsole.git?path=BlueBackConsole/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_BlueBackExcel
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.Excel")]
		public static void MenuItem_BlueBackExcel()
		{
			string t_name = "https://github.com/bluebackblue/UpmExcel.git?path=BlueBackExcel/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_BlueBackFont
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.Font")]
		public static void MenuItem_BlueBackFont()
		{
			string t_name = "https://github.com/bluebackblue/UpmFont.git?path=BlueBackFont/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_BlueBackGl
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.Gl")]
		public static void MenuItem_BlueBackGl()
		{
			string t_name = "https://github.com/bluebackblue/UpmGl.git?path=BlueBackGl/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_BlueBackInstall
		*/
		#if(!DEF_USER_BLUEBACK_INSTALL)
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.Install")]
		public static void MenuItem_BlueBackInstall()
		{
			string t_name = "https://github.com/bluebackblue/UpmInstall.git?path=BlueBackInstall/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}
		#endif

		/** MenuItem_BlueBackJsonItem
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.JsonItem")]
		public static void MenuItem_BlueBackJsonItem()
		{
			string t_name = "https://github.com/bluebackblue/UpmJsonItem.git?path=BlueBackJsonItem/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_BlueBackMath
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.Math")]
		public static void MenuItem_BlueBackMath()
		{
			string t_name = "https://github.com/bluebackblue/UpmMath.git?path=BlueBackMath/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_BlueBackMouse
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.Mouse")]
		public static void MenuItem_BlueBackMouse()
		{
			string t_name = "https://github.com/bluebackblue/UpmMouse.git?path=BlueBackMouse/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_BlueBackPad
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.Pad")]
		public static void MenuItem_BlueBackPad()
		{
			string t_name = "https://github.com/bluebackblue/UpmPad.git?path=BlueBackPad/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_BlueBackPoolList
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.PoolList")]
		public static void MenuItem_BlueBackPoolList()
		{
			string t_name = "https://github.com/bluebackblue/UpmPoolList.git?path=BlueBackPoolList/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_BlueBackScene
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.Scene")]
		public static void MenuItem_BlueBackScene()
		{
			string t_name = "https://github.com/bluebackblue/UpmScene.git?path=BlueBackScene/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_BlueBackSlackWebApi
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.SlackWebApi")]
		public static void MenuItem_BlueBackSlackWebApi()
		{
			string t_name = "https://github.com/bluebackblue/UpmSlackWebApi.git?path=BlueBackSlackWebApi/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_BlueBackTestLib
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.TestLib")]
		public static void MenuItem_BlueBackTestLib()
		{
			string t_name = "https://github.com/bluebackblue/UpmTestLib.git?path=BlueBackTestLib/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_BlueBackThreadRequest
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.ThreadRequest")]
		public static void MenuItem_BlueBackThreadRequest()
		{
			string t_name = "https://github.com/bluebackblue/UpmThreadRequest.git?path=BlueBackThreadRequest/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_BlueBackTimeScale
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.TimeScale")]
		public static void MenuItem_BlueBackTimeScale()
		{
			string t_name = "https://github.com/bluebackblue/UpmTimeScale.git?path=BlueBackTimeScale/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_BlueBackUnityPlayerLoop
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.UnityPlayerLoop")]
		public static void MenuItem_BlueBackUnityPlayerLoop()
		{
			string t_name = "https://github.com/bluebackblue/UpmUnityPlayerLoop.git?path=BlueBackUnityPlayerLoop/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_BlueBackVersionManager
		*/
		[UnityEditor.MenuItem("BlueBack/Install/UpdatePackage/BlueBack.VersionManager")]
		public static void MenuItem_BlueBackVersionManager()
		{
			string t_name = "https://github.com/bluebackblue/UpmVersionManager.git?path=BlueBackVersionManager/Assets/UPM";
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

