

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
	/** Package_BlueBack
	*/
	public static class Package_BlueBack
	{
		/** MenuItem_Add_AssetLib
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.AssetLib")]
		public static void MenuItem_Add_AssetLib()
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

		/** MenuItem_Add_Audio
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.Audio")]
		public static void MenuItem_Add_Audio()
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

		/** MenuItem_Add_Code
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.Code")]
		public static void MenuItem_Add_Code()
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

		/** MenuItem_Add_Console
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.Console")]
		public static void MenuItem_Add_Console()
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

		/** MenuItem_Add_DrawInstance
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.DrawInstance")]
		public static void MenuItem_Add_DrawInstance()
		{
			string t_name = "https://github.com/bluebackblue/UpmDrawInstance.git?path=BlueBackDrawInstance/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Add_Excel
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.Excel")]
		public static void MenuItem_Add_Excel()
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

		/** MenuItem_Add_Font
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.Font")]
		public static void MenuItem_Add_Font()
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

		/** MenuItem_Add_Gl
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.Gl")]
		public static void MenuItem_Add_Gl()
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

		/** MenuItem_Add_JsonItem
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.JsonItem")]
		public static void MenuItem_Add_JsonItem()
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

		/** MenuItem_Add_Math
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.Math")]
		public static void MenuItem_Add_Math()
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

		/** MenuItem_Add_Mouse
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.Mouse")]
		public static void MenuItem_Add_Mouse()
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

		/** MenuItem_Add_Pad
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.Pad")]
		public static void MenuItem_Add_Pad()
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

		/** MenuItem_Add_PoolList
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.PoolList")]
		public static void MenuItem_Add_PoolList()
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

		/** MenuItem_Add_Request
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.Request")]
		public static void MenuItem_Add_Request()
		{
			string t_name = "https://github.com/bluebackblue/UpmRequest.git?path=BlueBackRequest/Assets/UPM";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Add_Scene
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.Scene")]
		public static void MenuItem_Add_Scene()
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

		/** MenuItem_Add_SlackWebApi
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.SlackWebApi")]
		public static void MenuItem_Add_SlackWebApi()
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

		/** MenuItem_Add_TestLib
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.TestLib")]
		public static void MenuItem_Add_TestLib()
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

		/** MenuItem_Add_TimeScale
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.TimeScale")]
		public static void MenuItem_Add_TimeScale()
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

		/** MenuItem_Add_UnityPlayerLoop
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.UnityPlayerLoop")]
		public static void MenuItem_Add_UnityPlayerLoop()
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

		/** MenuItem_Add_VersionManager
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/BlueBack.VersionManager")]
		public static void MenuItem_Add_VersionManager()
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

		/** MenuItem_Remove_AssetLib
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.AssetLib")]
		public static void MenuItem_Remove_AssetLib()
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

		/** MenuItem_Remove_Audio
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.Audio")]
		public static void MenuItem_Remove_Audio()
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

		/** MenuItem_Remove_Code
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.Code")]
		public static void MenuItem_Remove_Code()
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

		/** MenuItem_Remove_Console
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.Console")]
		public static void MenuItem_Remove_Console()
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

		/** MenuItem_Remove_DrawInstance
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.DrawInstance")]
		public static void MenuItem_Remove_DrawInstance()
		{
			string t_name = "blueback.drawinstance";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Remove_Excel
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.Excel")]
		public static void MenuItem_Remove_Excel()
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

		/** MenuItem_Remove_Font
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.Font")]
		public static void MenuItem_Remove_Font()
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

		/** MenuItem_Remove_Gl
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.Gl")]
		public static void MenuItem_Remove_Gl()
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

		/** MenuItem_Remove_JsonItem
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.JsonItem")]
		public static void MenuItem_Remove_JsonItem()
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

		/** MenuItem_Remove_Math
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.Math")]
		public static void MenuItem_Remove_Math()
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

		/** MenuItem_Remove_Mouse
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.Mouse")]
		public static void MenuItem_Remove_Mouse()
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

		/** MenuItem_Remove_Pad
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.Pad")]
		public static void MenuItem_Remove_Pad()
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

		/** MenuItem_Remove_PoolList
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.PoolList")]
		public static void MenuItem_Remove_PoolList()
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

		/** MenuItem_Remove_Request
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.Request")]
		public static void MenuItem_Remove_Request()
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

		/** MenuItem_Remove_Scene
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.Scene")]
		public static void MenuItem_Remove_Scene()
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

		/** MenuItem_Remove_SlackWebApi
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.SlackWebApi")]
		public static void MenuItem_Remove_SlackWebApi()
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

		/** MenuItem_Remove_TestLib
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.TestLib")]
		public static void MenuItem_Remove_TestLib()
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

		/** MenuItem_Remove_TimeScale
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.TimeScale")]
		public static void MenuItem_Remove_TimeScale()
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

		/** MenuItem_Remove_UnityPlayerLoop
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.UnityPlayerLoop")]
		public static void MenuItem_Remove_UnityPlayerLoop()
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

		/** MenuItem_Remove_VersionManager
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/BlueBack.VersionManager")]
		public static void MenuItem_Remove_VersionManager()
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
