

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief ツール。
*/


/** BlueBack.Install.Editor
*/
#if(UNITY_EDITOR)
namespace Tool
{
	/** AutoGenerateCode
	*/
	public static class AutoGenerateCode
	{
		/** MenuItem_Code
		*/
		[UnityEditor.MenuItem("BlueBack/Install/AutoGenerateCode")]
		private static void MenuItem_Code()
		{
			//Package_BlueBack
			{
				string[] t_list = new string[]{
					"AssetLib",
					"Audio",
					"Code",
					"Console",
					"DrawInstance",
					"Excel",
					"Font",
					"Gl",
					//"Install",
					"JsonItem",
					"Math",
					"Mouse",
					"Pad",
					"PoolList",
					"Request",
					"Scene",
					"SlackWebApi",
					"TestLib",
					"TimeScale",
					"UnityPlayerLoop",
					"VersionManager",
				};

				System.Collections.Generic.List<string> t_template = new System.Collections.Generic.List<string>();
				{
					BlueBack.Code.Convert.Add(t_template,new string[]{
						"",
						"",
						"/**",
						"	Copyright (c) blueback",
						"	Released under the MIT License",
						"	@brief パッケージ更新。自動生成。",
						"*/",
						"",
						"",
						"/** BlueBack.Install.Editor",
						"*/",
						"#if(UNITY_EDITOR)",
						"namespace BlueBack.Install.Editor",
						"{",
						"	/** Package_BlueBack",
						"	*/",
						"	public static class Package_BlueBack",
						"	{",
					});

					BlueBack.Code.Convert.Duplicate(t_template,"<<INDEX>>",t_list.Length,new string[]{
						"		/** MenuItem_Add_<<NAME.<<INDEX>>>>",
						"		*/",
						"		[UnityEditor.MenuItem(\"BlueBack/Install/BlueBack/Add/BlueBack.<<NAME.<<INDEX>>>>\")]",
						"		public static void MenuItem_Add_<<NAME.<<INDEX>>>>()",
						"		{",
						"			string t_name = \"https://github.com/bluebackblue/Upm<<NAME.<<INDEX>>>>.git?path=BlueBack<<NAME.<<INDEX>>>>/Assets/UPM\";",
						"			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);",
						"			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){",
						"				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){",
						"					break;",
						"				}",
						"				System.Threading.Thread.Sleep(1000);",
						"			}",
						"			UnityEditor.EditorUtility.ClearProgressBar();",
						"		}",
						"",
					});

					BlueBack.Code.Convert.Duplicate(t_template,"<<INDEX>>",t_list.Length,new string[]{
						"		/** MenuItem_Remove_<<NAME.<<INDEX>>>>",
						"		*/",
						"		[UnityEditor.MenuItem(\"BlueBack/Install/BlueBack/Remove/BlueBack.<<NAME.<<INDEX>>>>\")]",
						"		public static void MenuItem_Remove_<<NAME.<<INDEX>>>>()",
						"		{",
						"			string t_name = \"blueback.<<name.<<INDEX>>>>\";",
						"			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);",
						"			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){",
						"				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){",
						"					break;",
						"				}",
						"				System.Threading.Thread.Sleep(1000);",
						"			}",
						"			UnityEditor.EditorUtility.ClearProgressBar();",
						"		}",
						"",
					});

					BlueBack.Code.Convert.Add(t_template,new string[]{
						"	}",
						"}",
						"#endif",
					});
				}

				System.Collections.Generic.Dictionary<string,string> t_replace_list = new System.Collections.Generic.Dictionary<string,string>();
				{
					for(int ii=0;ii<t_list.Length;ii++){
						t_replace_list.Add("<<NAME." + ii.ToString()  + ">>",t_list[ii]);
						t_replace_list.Add("<<name." + ii.ToString()  + ">>",t_list[ii].ToLower());
					}
				}

				System.Text.StringBuilder t_stringbuilder = new System.Text.StringBuilder();
				BlueBack.Code.Convert.Replace(t_stringbuilder,t_replace_list,t_template);

				BlueBack.AssetLib.Editor.SaveTextWithAssetsPath.Save(t_stringbuilder.ToString(),"UPM/Editor/BlueBack/Install/Editor/Package_BlueBack.cs",System.Text.Encoding.UTF8,BlueBack.AssetLib.LineFeedOption.CRLF);
				BlueBack.AssetLib.Editor.RefreshAssetDatabase.Refresh();
			}

			//Package_Unity
			{
				string[] t_list = new string[]{
					"com.unity.mathematics",
					"com.unity.burst",
					"com.unity.ugui",
				};

				System.Collections.Generic.List<string> t_template = new System.Collections.Generic.List<string>();
				{
					BlueBack.Code.Convert.Add(t_template,new string[]{
						"",
						"",
						"/**",
						"	Copyright (c) blueback",
						"	Released under the MIT License",
						"	@brief パッケージ更新。自動生成。",
						"*/",
						"",
						"",
						"/** BlueBack.Install.Editor",
						"*/",
						"#if(UNITY_EDITOR)",
						"namespace BlueBack.Install.Editor",
						"{",
						"	/** Package_Unity",
						"	*/",
						"	public static class Package_Unity",
						"	{",
					});

					BlueBack.Code.Convert.Duplicate(t_template,"<<INDEX>>",t_list.Length,new string[]{
						"		/** MenuItem_Add_<<NAME.<<INDEX>>>>",
						"		*/",
						"		[UnityEditor.MenuItem(\"BlueBack/Install/Unity/Add/<<NAME.<<INDEX>>>>\")]",
						"		public static void MenuItem_Add_<<NAME.<<INDEX>>>>()",
						"		{",
						"			string t_name = \"<<name.<<INDEX>>>>\";",
						"			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);",
						"			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){",
						"				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){",
						"					break;",
						"				}",
						"				System.Threading.Thread.Sleep(1000);",
						"			}",
						"			UnityEditor.EditorUtility.ClearProgressBar();",
						"		}",
						"",
					});

					BlueBack.Code.Convert.Duplicate(t_template,"<<INDEX>>",t_list.Length,new string[]{
						"		/** MenuItem_Remove_<<NAME.<<INDEX>>>>",
						"		*/",
						"		[UnityEditor.MenuItem(\"BlueBack/Install/Unity/Remove/<<NAME.<<INDEX>>>>\")]",
						"		public static void MenuItem_Remove_<<NAME.<<INDEX>>>>()",
						"		{",
						"			string t_name = \"<<name.<<INDEX>>>>\";",
						"			UnityEditor.PackageManager.Requests.RemoveRequest t_request = UnityEditor.PackageManager.Client.Remove(t_name);",
						"			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){",
						"				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){",
						"					break;",
						"				}",
						"				System.Threading.Thread.Sleep(1000);",
						"			}",
						"			UnityEditor.EditorUtility.ClearProgressBar();",
						"		}",
						"",
					});

					BlueBack.Code.Convert.Add(t_template,new string[]{
						"	}",
						"}",
						"#endif",
					});
				}

				System.Collections.Generic.Dictionary<string,string> t_replace_list = new System.Collections.Generic.Dictionary<string,string>();
				{
					for(int ii=0;ii<t_list.Length;ii++){
						t_replace_list.Add("<<NAME." + ii.ToString()  + ">>",t_list[ii].Replace('.','_'));
						t_replace_list.Add("<<name." + ii.ToString()  + ">>",t_list[ii].ToLower());
					}
				}

				System.Text.StringBuilder t_stringbuilder = new System.Text.StringBuilder();
				BlueBack.Code.Convert.Replace(t_stringbuilder,t_replace_list,t_template);

				BlueBack.AssetLib.Editor.SaveTextWithAssetsPath.Save(t_stringbuilder.ToString(),"UPM/Editor/BlueBack/Install/Editor/Package_Unity.cs",System.Text.Encoding.UTF8,BlueBack.AssetLib.LineFeedOption.CRLF);
				BlueBack.AssetLib.Editor.RefreshAssetDatabase.Refresh();
			}
		}
	}
}
#endif

