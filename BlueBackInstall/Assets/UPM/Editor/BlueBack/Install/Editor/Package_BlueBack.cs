

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
		#if(!USERDEF_BLUEBACK_ASSETLIB)
		#if(ASMDEF_BLUEBACK_ASSETLIB)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.AssetLib")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.AssetLib")]
		#endif
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
		#endif

		/** MenuItem_Add_Audio
		*/
		#if(!USERDEF_BLUEBACK_AUDIO)
		#if(ASMDEF_BLUEBACK_AUDIO)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.Audio")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.Audio")]
		#endif
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
		#endif

		/** MenuItem_Add_Code
		*/
		#if(!USERDEF_BLUEBACK_CODE)
		#if(ASMDEF_BLUEBACK_CODE)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.Code")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.Code")]
		#endif
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
		#endif

		/** MenuItem_Add_Console
		*/
		#if(!USERDEF_BLUEBACK_CONSOLE)
		#if(ASMDEF_BLUEBACK_CONSOLE)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.Console")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.Console")]
		#endif
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
		#endif

		/** MenuItem_Add_DrawInstance
		*/
		#if(!USERDEF_BLUEBACK_DRAWINSTANCE)
		#if(ASMDEF_BLUEBACK_DRAWINSTANCE)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.DrawInstance")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.DrawInstance")]
		#endif
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
		#endif

		/** MenuItem_Add_Excel
		*/
		#if(!USERDEF_BLUEBACK_EXCEL)
		#if(ASMDEF_BLUEBACK_EXCEL)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.Excel")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.Excel")]
		#endif
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
		#endif

		/** MenuItem_Add_Font
		*/
		#if(!USERDEF_BLUEBACK_FONT)
		#if(ASMDEF_BLUEBACK_FONT)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.Font")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.Font")]
		#endif
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
		#endif

		/** MenuItem_Add_Gl
		*/
		#if(!USERDEF_BLUEBACK_GL)
		#if(ASMDEF_BLUEBACK_GL)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.Gl")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.Gl")]
		#endif
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
		#endif

		/** MenuItem_Add_Install
		*/
		#if(!USERDEF_BLUEBACK_INSTALL)
		#if(ASMDEF_BLUEBACK_INSTALL)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.Install")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.Install")]
		#endif
		public static void MenuItem_Add_Install()
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

		/** MenuItem_Add_JsonItem
		*/
		#if(!USERDEF_BLUEBACK_JSONITEM)
		#if(ASMDEF_BLUEBACK_JSONITEM)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.JsonItem")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.JsonItem")]
		#endif
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
		#endif

		/** MenuItem_Add_Math
		*/
		#if(!USERDEF_BLUEBACK_MATH)
		#if(ASMDEF_BLUEBACK_MATH)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.Math")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.Math")]
		#endif
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
		#endif

		/** MenuItem_Add_Mouse
		*/
		#if(!USERDEF_BLUEBACK_MOUSE)
		#if(ASMDEF_BLUEBACK_MOUSE)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.Mouse")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.Mouse")]
		#endif
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
		#endif

		/** MenuItem_Add_Pad
		*/
		#if(!USERDEF_BLUEBACK_PAD)
		#if(ASMDEF_BLUEBACK_PAD)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.Pad")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.Pad")]
		#endif
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
		#endif

		/** MenuItem_Add_PoolList
		*/
		#if(!USERDEF_BLUEBACK_POOLLIST)
		#if(ASMDEF_BLUEBACK_POOLLIST)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.PoolList")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.PoolList")]
		#endif
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
		#endif

		/** MenuItem_Add_Request
		*/
		#if(!USERDEF_BLUEBACK_REQUEST)
		#if(ASMDEF_BLUEBACK_REQUEST)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.Request")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.Request")]
		#endif
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
		#endif

		/** MenuItem_Add_Scene
		*/
		#if(!USERDEF_BLUEBACK_SCENE)
		#if(ASMDEF_BLUEBACK_SCENE)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.Scene")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.Scene")]
		#endif
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
		#endif

		/** MenuItem_Add_SlackWebApi
		*/
		#if(!USERDEF_BLUEBACK_SLACKWEBAPI)
		#if(ASMDEF_BLUEBACK_SLACKWEBAPI)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.SlackWebApi")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.SlackWebApi")]
		#endif
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
		#endif

		/** MenuItem_Add_TestLib
		*/
		#if(!USERDEF_BLUEBACK_TESTLIB)
		#if(ASMDEF_BLUEBACK_TESTLIB)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.TestLib")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.TestLib")]
		#endif
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
		#endif

		/** MenuItem_Add_TimeScale
		*/
		#if(!USERDEF_BLUEBACK_TIMESCALE)
		#if(ASMDEF_BLUEBACK_TIMESCALE)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.TimeScale")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.TimeScale")]
		#endif
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
		#endif

		/** MenuItem_Add_UnityPlayerLoop
		*/
		#if(!USERDEF_BLUEBACK_UNITYPLAYERLOOP)
		#if(ASMDEF_BLUEBACK_UNITYPLAYERLOOP)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.UnityPlayerLoop")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.UnityPlayerLoop")]
		#endif
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
		#endif

		/** MenuItem_Add_VariableDigit
		*/
		#if(!USERDEF_BLUEBACK_VARIABLEDIGIT)
		#if(ASMDEF_BLUEBACK_VARIABLEDIGIT)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.VariableDigit")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.VariableDigit")]
		#endif
		public static void MenuItem_Add_VariableDigit()
		{
			string t_name = "https://github.com/bluebackblue/UpmVariableDigit.git?path=BlueBackVariableDigit/Assets/UPM";
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

		/** MenuItem_Add_VersionManager
		*/
		#if(!USERDEF_BLUEBACK_VERSIONMANAGER)
		#if(ASMDEF_BLUEBACK_VERSIONMANAGER)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.VersionManager")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.VersionManager")]
		#endif
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
		#endif

		/** MenuItem_Add_Vosk
		*/
		#if(!USERDEF_BLUEBACK_VOSK)
		#if(ASMDEF_BLUEBACK_VOSK)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[*]BlueBack.Vosk")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Add/[ ]BlueBack.Vosk")]
		#endif
		public static void MenuItem_Add_Vosk()
		{
			string t_name = "https://github.com/bluebackblue/UpmVosk.git?path=BlueBackVosk/Assets/UPM";
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

		/** MenuItem_Remove_AssetLib
		*/
		#if(ASMDEF_BLUEBACK_ASSETLIB)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.AssetLib")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.AssetLib")]
		#endif
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
		#if(ASMDEF_BLUEBACK_AUDIO)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.Audio")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.Audio")]
		#endif
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
		#if(ASMDEF_BLUEBACK_CODE)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.Code")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.Code")]
		#endif
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
		#if(ASMDEF_BLUEBACK_CONSOLE)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.Console")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.Console")]
		#endif
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
		#if(ASMDEF_BLUEBACK_DRAWINSTANCE)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.DrawInstance")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.DrawInstance")]
		#endif
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
		#if(ASMDEF_BLUEBACK_EXCEL)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.Excel")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.Excel")]
		#endif
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
		#if(ASMDEF_BLUEBACK_FONT)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.Font")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.Font")]
		#endif
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
		#if(ASMDEF_BLUEBACK_GL)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.Gl")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.Gl")]
		#endif
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

		/** MenuItem_Remove_Install
		*/
		#if(ASMDEF_BLUEBACK_INSTALL)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.Install")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.Install")]
		#endif
		public static void MenuItem_Remove_Install()
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

		/** MenuItem_Remove_JsonItem
		*/
		#if(ASMDEF_BLUEBACK_JSONITEM)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.JsonItem")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.JsonItem")]
		#endif
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
		#if(ASMDEF_BLUEBACK_MATH)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.Math")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.Math")]
		#endif
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
		#if(ASMDEF_BLUEBACK_MOUSE)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.Mouse")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.Mouse")]
		#endif
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
		#if(ASMDEF_BLUEBACK_PAD)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.Pad")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.Pad")]
		#endif
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
		#if(ASMDEF_BLUEBACK_POOLLIST)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.PoolList")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.PoolList")]
		#endif
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
		#if(ASMDEF_BLUEBACK_REQUEST)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.Request")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.Request")]
		#endif
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
		#if(ASMDEF_BLUEBACK_SCENE)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.Scene")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.Scene")]
		#endif
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
		#if(ASMDEF_BLUEBACK_SLACKWEBAPI)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.SlackWebApi")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.SlackWebApi")]
		#endif
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
		#if(ASMDEF_BLUEBACK_TESTLIB)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.TestLib")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.TestLib")]
		#endif
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
		#if(ASMDEF_BLUEBACK_TIMESCALE)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.TimeScale")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.TimeScale")]
		#endif
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
		#if(ASMDEF_BLUEBACK_UNITYPLAYERLOOP)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.UnityPlayerLoop")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.UnityPlayerLoop")]
		#endif
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

		/** MenuItem_Remove_VariableDigit
		*/
		#if(ASMDEF_BLUEBACK_VARIABLEDIGIT)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.VariableDigit")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.VariableDigit")]
		#endif
		public static void MenuItem_Remove_VariableDigit()
		{
			string t_name = "blueback.variabledigit";
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
		#if(ASMDEF_BLUEBACK_VERSIONMANAGER)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.VersionManager")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.VersionManager")]
		#endif
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

		/** MenuItem_Remove_Vosk
		*/
		#if(ASMDEF_BLUEBACK_VOSK)
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[*]BlueBack.Vosk")]
		#else
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/Remove/[ ]BlueBack.Vosk")]
		#endif
		public static void MenuItem_Remove_Vosk()
		{
			string t_name = "blueback.vosk";
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
