

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

		/** MenuItem_Add_com_unity_inputsystem
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Add/com_unity_inputsystem")]
		public static void MenuItem_Add_com_unity_inputsystem()
		{
			string t_name = "com.unity.inputsystem";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Add_com_unity_ide_visualstudio
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Add/com_unity_ide_visualstudio")]
		public static void MenuItem_Add_com_unity_ide_visualstudio()
		{
			string t_name = "com.unity.ide.visualstudio";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Add_com_unity_ide_vscode
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Add/com_unity_ide_vscode")]
		public static void MenuItem_Add_com_unity_ide_vscode()
		{
			string t_name = "com.unity.ide.vscode";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Add_com_unity_ide_rider
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Add/com_unity_ide_rider")]
		public static void MenuItem_Add_com_unity_ide_rider()
		{
			string t_name = "com.unity.ide.rider";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Add_com_unity_test_framework
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Add/com_unity_test_framework")]
		public static void MenuItem_Add_com_unity_test_framework()
		{
			string t_name = "com.unity.test-framework";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Add_com_unity_textmeshpro
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Add/com_unity_textmeshpro")]
		public static void MenuItem_Add_com_unity_textmeshpro()
		{
			string t_name = "com.unity.textmeshpro";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Add_com_unity_timeline
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Add/com_unity_timeline")]
		public static void MenuItem_Add_com_unity_timeline()
		{
			string t_name = "com.unity.timeline";
			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Add_com_unity_collab_proxy
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Add/com_unity_collab_proxy")]
		public static void MenuItem_Add_com_unity_collab_proxy()
		{
			string t_name = "com.unity.collab-proxy";
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

		/** MenuItem_Remove_com_unity_inputsystem
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Remove/com_unity_inputsystem")]
		public static void MenuItem_Remove_com_unity_inputsystem()
		{
			string t_name = "com.unity.inputsystem";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Remove_com_unity_ide_visualstudio
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Remove/com_unity_ide_visualstudio")]
		public static void MenuItem_Remove_com_unity_ide_visualstudio()
		{
			string t_name = "com.unity.ide.visualstudio";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Remove_com_unity_ide_vscode
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Remove/com_unity_ide_vscode")]
		public static void MenuItem_Remove_com_unity_ide_vscode()
		{
			string t_name = "com.unity.ide.vscode";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Remove_com_unity_ide_rider
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Remove/com_unity_ide_rider")]
		public static void MenuItem_Remove_com_unity_ide_rider()
		{
			string t_name = "com.unity.ide.rider";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Remove_com_unity_test_framework
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Remove/com_unity_test_framework")]
		public static void MenuItem_Remove_com_unity_test_framework()
		{
			string t_name = "com.unity.test-framework";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Remove_com_unity_textmeshpro
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Remove/com_unity_textmeshpro")]
		public static void MenuItem_Remove_com_unity_textmeshpro()
		{
			string t_name = "com.unity.textmeshpro";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Remove_com_unity_timeline
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Remove/com_unity_timeline")]
		public static void MenuItem_Remove_com_unity_timeline()
		{
			string t_name = "com.unity.timeline";
			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);
			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){
				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){
					break;
				}
				System.Threading.Thread.Sleep(1000);
			}
			UnityEditor.EditorUtility.ClearProgressBar();
		}

		/** MenuItem_Remove_com_unity_collab_proxy
		*/
		[UnityEditor.MenuItem("BlueBack/Install/Unity/Remove/com_unity_collab_proxy")]
		public static void MenuItem_Remove_com_unity_collab_proxy()
		{
			string t_name = "com.unity.collab-proxy";
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
