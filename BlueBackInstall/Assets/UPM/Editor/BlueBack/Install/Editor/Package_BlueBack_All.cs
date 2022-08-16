

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
	/** Package_BlueBack_All
	*/
	public static class Package_BlueBack_All
	{
		/** MenuItem_AddAll
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/AddAll")]
		public static void MenuItem_AddAll()
		{
			#if(!USERDEF_BLUEBACK_ASSETLIB)
			Package_BlueBack.MenuItem_Add_AssetLib();
			#endif

			#if(!USERDEF_BLUEBACK_AUDIO)
			Package_BlueBack.MenuItem_Add_Audio();
			#endif

			#if(!USERDEF_BLUEBACK_CODE)
			Package_BlueBack.MenuItem_Add_Code();
			#endif

			#if(!USERDEF_BLUEBACK_CONSOLE)
			Package_BlueBack.MenuItem_Add_Console();
			#endif

			#if(!USERDEF_BLUEBACK_DEBUG)
			Package_BlueBack.MenuItem_Add_Debug();
			#endif

			#if(!USERDEF_BLUEBACK_DRAWINSTANCE)
			Package_BlueBack.MenuItem_Add_DrawInstance();
			#endif

			#if(!USERDEF_BLUEBACK_EXCEL)
			Package_BlueBack.MenuItem_Add_Excel();
			#endif

			#if(!USERDEF_BLUEBACK_FONT)
			Package_BlueBack.MenuItem_Add_Font();
			#endif

			#if(!USERDEF_BLUEBACK_GL)
			Package_BlueBack.MenuItem_Add_Gl();
			#endif

			#if(!USERDEF_BLUEBACK_INSTALL)
			Package_BlueBack.MenuItem_Add_Install();
			#endif

			#if(!USERDEF_BLUEBACK_JSONITEM)
			Package_BlueBack.MenuItem_Add_JsonItem();
			#endif

			#if(!USERDEF_BLUEBACK_MATH)
			Package_BlueBack.MenuItem_Add_Math();
			#endif

			#if(!USERDEF_BLUEBACK_MOUSE)
			Package_BlueBack.MenuItem_Add_Mouse();
			#endif

			#if(!USERDEF_BLUEBACK_PAD)
			Package_BlueBack.MenuItem_Add_Pad();
			#endif

			#if(!USERDEF_BLUEBACK_POOLLIST)
			Package_BlueBack.MenuItem_Add_PoolList();
			#endif

			#if(!USERDEF_BLUEBACK_REQUEST)
			Package_BlueBack.MenuItem_Add_Request();
			#endif

			#if(!USERDEF_BLUEBACK_SCENE)
			Package_BlueBack.MenuItem_Add_Scene();
			#endif

			#if(!USERDEF_BLUEBACK_SLACKWEBAPI)
			Package_BlueBack.MenuItem_Add_SlackWebApi();
			#endif

			#if(!USERDEF_BLUEBACK_TESTLIB)
			Package_BlueBack.MenuItem_Add_TestLib();
			#endif

			#if(!USERDEF_BLUEBACK_TIMESCALE)
			Package_BlueBack.MenuItem_Add_TimeScale();
			#endif

			#if(!USERDEF_BLUEBACK_UNITYPLAYERLOOP)
			Package_BlueBack.MenuItem_Add_UnityPlayerLoop();
			#endif

			#if(!USERDEF_BLUEBACK_VARIABLEDIGIT)
			Package_BlueBack.MenuItem_Add_VariableDigit();
			#endif

			#if(!USERDEF_BLUEBACK_VERSIONMANAGER)
			Package_BlueBack.MenuItem_Add_VersionManager();
			#endif

			#if(!USERDEF_BLUEBACK_VOSK)
			Package_BlueBack.MenuItem_Add_Vosk();
			#endif

		}
	}
}
#endif

