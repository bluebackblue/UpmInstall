

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
	/** RemovePackage_BlueBack
	*/
	public static class RemovePackage_BlueBack
	{
		/** MenuItem_BlueBackAssetLib
		*/
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.AssetLib")]
		public static void MenuItem_BlueBackAssetLib()
		{
			string t_name = "blueback.assetlib";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
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
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.Audio")]
		public static void MenuItem_BlueBackAudio()
		{
			string t_name = "blueback.audio";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
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
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.Code")]
		public static void MenuItem_BlueBackCode()
		{
			string t_name = "blueback.code";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
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
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.Console")]
		public static void MenuItem_BlueBackConsole()
		{
			string t_name = "blueback.console";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
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
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.Excel")]
		public static void MenuItem_BlueBackExcel()
		{
			string t_name = "blueback.excel";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
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
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.Font")]
		public static void MenuItem_BlueBackFont()
		{
			string t_name = "blueback.font";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
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
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.Gl")]
		public static void MenuItem_BlueBackGl()
		{
			string t_name = "blueback.gl";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
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
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.Install")]
		public static void MenuItem_BlueBackInstall()
		{
			string t_name = "blueback.install";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
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
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.JsonItem")]
		public static void MenuItem_BlueBackJsonItem()
		{
			string t_name = "blueback.jsonitem";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
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
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.Math")]
		public static void MenuItem_BlueBackMath()
		{
			string t_name = "blueback.math";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
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
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.Mouse")]
		public static void MenuItem_BlueBackMouse()
		{
			string t_name = "blueback.mouse";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
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
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.Pad")]
		public static void MenuItem_BlueBackPad()
		{
			string t_name = "blueback.pad";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
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
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.PoolList")]
		public static void MenuItem_BlueBackPoolList()
		{
			string t_name = "blueback.poollist";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
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
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.Scene")]
		public static void MenuItem_BlueBackScene()
		{
			string t_name = "blueback.scene";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
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
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.SlackWebApi")]
		public static void MenuItem_BlueBackSlackWebApi()
		{
			string t_name = "blueback.slackwebapi";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
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
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.TestLib")]
		public static void MenuItem_BlueBackTestLib()
		{
			string t_name = "blueback.testlib";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
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
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.Request")]
		public static void MenuItem_BlueBackThreadRequest()
		{
			string t_name = "blueback.request";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
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
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.TimeScale")]
		public static void MenuItem_BlueBackTimeScale()
		{
			string t_name = "blueback.timescale";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
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
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.UnityPlayerLoop")]
		public static void MenuItem_BlueBackUnityPlayerLoop()
		{
			string t_name = "blueback.unityplayerloop";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
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
		[UnityEditor.MenuItem("BlueBack/Install/RemovePackage/BlueBack.VersionManager")]
		public static void MenuItem_BlueBackVersionManager()
		{
			string t_name = "blueback.versionmanager";
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

