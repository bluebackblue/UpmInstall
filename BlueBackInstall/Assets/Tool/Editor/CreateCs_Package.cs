

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief ツール。
*/


/** define
*/
#if((ASMDEF_BLUEBACK_CODE||USERDEF_BLUEBACK_CODE)&&(ASMDEF_BLUEBACK_ASSETLIB||USERDEF_BLUEBACK_ASSETLIB))
#define ASMDEF_TRUE
#else
#warning "ASMDEF_TRUE"
#endif


/** BlueBack.Install.Editor
*/
#if(UNITY_EDITOR)
namespace Tool
{
	/** CreateCs_Package
	*/
	public static class CreateCs_Package
	{
		/** MenuItem_Code
		*/
		[UnityEditor.MenuItem("BlueBack/Install/CreateCs_Package")]
		private static void MenuItem_Code()
		#if(ASMDEF_TRUE)
		{
			string[] t_blueback_list = new string[]{
				"AssetLib",
				"Audio",
				"Code",
				"Console",
				"Debug",
				"DrawInstance",
				"Excel",
				"Font",
				"Gl",
				"Install",
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
				"VariableDigit",
				"VersionManager",
				"Vosk",
			};

			string[] t_unity_list = new string[]{
				"com.unity.mathematics",
				"com.unity.burst",
				"com.unity.ugui",
				"com.unity.inputsystem",
				"com.unity.ide.visualstudio",
				"com.unity.ide.vscode",
				"com.unity.ide.rider",
				"com.unity.test-framework",
				"com.unity.textmeshpro",
				"com.unity.timeline",
				"com.unity.collab-proxy",
			};

			//チェック。
			{
				string t_path = string.Format("{0}/{1}",UnityEngine.Application.dataPath,"../../../");
				System.Collections.Generic.List<string> t_list = BlueBack.AssetLib.CreateDirectoryNameListWithFullPath.CreateTopOnly(t_path);
				int ii_max = t_list.Count;
				for(int ii=0;ii<t_list.Count;ii++){
					if(System.Array.Exists(t_blueback_list,(string a_a_item)=>{
						return (("Upm" + a_a_item) == t_list[ii]);
					}) == false){
						switch(t_list[ii]){
						case "UPM":
						case "config":
						case "UPMTest":
							{
							}break;
						default:
							{
								//「t_blueback_list」に追加が必要。
								UnityEngine.Debug.LogError(string.Format("NotFound : {0}",t_list[ii]));
							}break;
						}
					}
				}
			}

			//Package_BlueBack
			{
				System.Collections.Generic.List<string> t_template = new System.Collections.Generic.List<string>();
				{
					BlueBack.Code.Convert.Add(t_template,null,new string[]{
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

					BlueBack.Code.Convert.Duplicate(t_template,"<<INDEX>>",t_blueback_list.Length,0,null,new string[]{
						"		/** MenuItem_Add_<<Name.<<INDEX>>>>",
						"		*/",
						"		#if(!USERDEF_BLUEBACK_<<NAME.<<INDEX>>>>)",
						"		#if(ASMDEF_BLUEBACK_<<NAME.<<INDEX>>>>)",
						"		[UnityEditor.MenuItem(\"BlueBack/Install/BlueBack/Add/[*]BlueBack.<<Name.<<INDEX>>>>\")]",
						"		#else",
						"		[UnityEditor.MenuItem(\"BlueBack/Install/BlueBack/Add/[ ]BlueBack.<<Name.<<INDEX>>>>\")]",
						"		#endif",
						"		public static void MenuItem_Add_<<Name.<<INDEX>>>>()",
						"		{",
						"			string t_name = \"https://github.com/bluebackblue/Upm<<Name.<<INDEX>>>>.git?path=BlueBack<<Name.<<INDEX>>>>/Assets/UPM\";",
						"			UnityEditor.PackageManager.Requests.AddRequest t_request = UnityEditor.PackageManager.Client.Add(t_name);",
						"			while(t_request.Status == UnityEditor.PackageManager.StatusCode.InProgress){",
						"				if(UnityEditor.EditorUtility.DisplayCancelableProgressBar(t_name,t_name,1.0f) == true){",
						"					break;",
						"				}",
						"				System.Threading.Thread.Sleep(1000);",
						"			}",
						"			UnityEditor.EditorUtility.ClearProgressBar();",
						"		}",
						"		#endif",
						"",
					});

					BlueBack.Code.Convert.Duplicate(t_template,"<<INDEX>>",t_blueback_list.Length,0,null,new string[]{
						"		/** MenuItem_Remove_<<Name.<<INDEX>>>>",
						"		*/",
						"		#if(ASMDEF_BLUEBACK_<<NAME.<<INDEX>>>>)",
						"		[UnityEditor.MenuItem(\"BlueBack/Install/BlueBack/Remove/[*]BlueBack.<<Name.<<INDEX>>>>\")]",
						"		#else",
						"		[UnityEditor.MenuItem(\"BlueBack/Install/BlueBack/Remove/[ ]BlueBack.<<Name.<<INDEX>>>>\")]",
						"		#endif",
						"		public static void MenuItem_Remove_<<Name.<<INDEX>>>>()",
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

					BlueBack.Code.Convert.Add(t_template,null,new string[]{
						"	}",
						"}",
						"#endif",
						"",
					});
				}

				System.Collections.Generic.Dictionary<string,string> t_replace_list = new System.Collections.Generic.Dictionary<string,string>();
				{
					for(int ii=0;ii<t_blueback_list.Length;ii++){
						t_replace_list.Add("<<Name." + ii.ToString()  + ">>",t_blueback_list[ii]);
						t_replace_list.Add("<<name." + ii.ToString()  + ">>",t_blueback_list[ii].ToLower());
						t_replace_list.Add("<<NAME." + ii.ToString()  + ">>",t_blueback_list[ii].ToUpper());
					}
				}

				System.Text.StringBuilder t_stringbuilder = new System.Text.StringBuilder();
				BlueBack.Code.Convert.Add(t_stringbuilder,t_replace_list,t_template);

				BlueBack.AssetLib.Editor.SaveTextWithAssetsPath.SaveNoBomUtf8(t_stringbuilder.ToString(),"UPM/Editor/BlueBack/Install/Editor/Package_BlueBack.cs",BlueBack.AssetLib.LineFeedOption.CRLF);
				BlueBack.AssetLib.Editor.RefreshAssetDatabase.Refresh();
			}

			//Package_BlueBack_All
			{
				System.Collections.Generic.List<string> t_template = new System.Collections.Generic.List<string>();
				{
					BlueBack.Code.Convert.Add(t_template,null,new string[]{
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
						"	/** Package_BlueBack_All",
						"	*/",
						"	public static class Package_BlueBack_All",
						"	{",
						"		/** MenuItem_AddAll",
						"		*/",
						"		[UnityEditor.MenuItem(\"BlueBack/Install/BlueBack/AddAll\")]",
						"		public static void MenuItem_AddAll()",
						"		{",
					});

					BlueBack.Code.Convert.Duplicate(t_template,"<<INDEX>>",t_blueback_list.Length,0,null,new string[]{
						"			#if(!USERDEF_BLUEBACK_<<NAME.<<INDEX>>>>)",
						"			Package_BlueBack.MenuItem_Add_<<Name.<<INDEX>>>>();",
						"			#endif",
						"",
					});

					BlueBack.Code.Convert.Add(t_template,null,new string[]{
						"		}",
						"	}",
						"}",
						"#endif",
						"",
					});
				}

				System.Collections.Generic.Dictionary<string,string> t_replace_list = new System.Collections.Generic.Dictionary<string,string>();
				{
					for(int ii=0;ii<t_blueback_list.Length;ii++){
						t_replace_list.Add("<<Name." + ii.ToString()  + ">>",t_blueback_list[ii]);
						t_replace_list.Add("<<name." + ii.ToString()  + ">>",t_blueback_list[ii].ToLower());
						t_replace_list.Add("<<NAME." + ii.ToString()  + ">>",t_blueback_list[ii].ToUpper());
					}
				}

				System.Text.StringBuilder t_stringbuilder = new System.Text.StringBuilder();
				BlueBack.Code.Convert.Add(t_stringbuilder,t_replace_list,t_template);

				BlueBack.AssetLib.Editor.SaveTextWithAssetsPath.SaveNoBomUtf8(t_stringbuilder.ToString(),"UPM/Editor/BlueBack/Install/Editor/Package_BlueBack_All.cs",BlueBack.AssetLib.LineFeedOption.CRLF);
				BlueBack.AssetLib.Editor.RefreshAssetDatabase.Refresh();
			}


			//Package_Unity
			{
				System.Collections.Generic.List<string> t_template = new System.Collections.Generic.List<string>();
				{
					BlueBack.Code.Convert.Add(t_template,null,new string[]{
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

					BlueBack.Code.Convert.Duplicate(t_template,"<<INDEX>>",t_unity_list.Length,0,null,new string[]{
						"		/** MenuItem_Add_<<Name.<<INDEX>>>>",
						"		*/",
						"		[UnityEditor.MenuItem(\"BlueBack/Install/Unity/Add/<<Name.<<INDEX>>>>\")]",
						"		public static void MenuItem_Add_<<Name.<<INDEX>>>>()",
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

					BlueBack.Code.Convert.Duplicate(t_template,"<<INDEX>>",t_unity_list.Length,0,null,new string[]{
						"		/** MenuItem_Remove_<<Name.<<INDEX>>>>",
						"		*/",
						"		[UnityEditor.MenuItem(\"BlueBack/Install/Unity/Remove/<<Name.<<INDEX>>>>\")]",
						"		public static void MenuItem_Remove_<<Name.<<INDEX>>>>()",
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

					BlueBack.Code.Convert.Add(t_template,null,new string[]{
						"	}",
						"}",
						"#endif",
						""
					});
				}

				System.Collections.Generic.Dictionary<string,string> t_replace_list = new System.Collections.Generic.Dictionary<string,string>();
				{
					for(int ii=0;ii<t_unity_list.Length;ii++){
						t_replace_list.Add("<<Name." + ii.ToString()  + ">>",t_unity_list[ii].Replace('.','_').Replace('-','_'));
						t_replace_list.Add("<<name." + ii.ToString()  + ">>",t_unity_list[ii].ToLower());
						t_replace_list.Add("<<NAME." + ii.ToString()  + ">>",t_unity_list[ii].ToUpper());
					}
				}

				System.Text.StringBuilder t_stringbuilder = new System.Text.StringBuilder();
				BlueBack.Code.Convert.Add(t_stringbuilder,t_replace_list,t_template);

				BlueBack.AssetLib.Editor.SaveTextWithAssetsPath.SaveNoBomUtf8(t_stringbuilder.ToString(),"UPM/Editor/BlueBack/Install/Editor/Package_Unity.cs",BlueBack.AssetLib.LineFeedOption.CRLF);
				BlueBack.AssetLib.Editor.RefreshAssetDatabase.Refresh();
			}
		}
		#else
		{
			#warning "ASMDEF_TRUE"
		}
		#endif
	}
}
#endif

