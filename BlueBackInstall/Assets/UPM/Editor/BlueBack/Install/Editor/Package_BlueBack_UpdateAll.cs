

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
	/** Package_BlueBack_UpdateAll
	*/
	public static class Package_BlueBack_UpdateAll
	{
		/** MenuItem_UpdateAll
		*/
		[UnityEditor.MenuItem("BlueBack/Install/BlueBack/UpdateAll")]
		public static void MenuItem_UpdateAll()
		{
			#if(ASMDEF_BLUEBACK_ASSETLIB)
			Package_BlueBack.MenuItem_Add_AssetLib();
			#endif

			#if(ASMDEF_BLUEBACK_AUDIO)
			Package_BlueBack.MenuItem_Add_Audio();
			#endif

			#if(ASMDEF_BLUEBACK_CODE)
			Package_BlueBack.MenuItem_Add_Code();
			#endif

			#if(ASMDEF_BLUEBACK_CONSOLE)
			Package_BlueBack.MenuItem_Add_Console();
			#endif

			#if(ASMDEF_BLUEBACK_DEBUG)
			Package_BlueBack.MenuItem_Add_Debug();
			#endif

			#if(ASMDEF_BLUEBACK_DRAWINSTANCE)
			Package_BlueBack.MenuItem_Add_DrawInstance();
			#endif

			#if(ASMDEF_BLUEBACK_EXCEL)
			Package_BlueBack.MenuItem_Add_Excel();
			#endif

			#if(ASMDEF_BLUEBACK_FONT)
			Package_BlueBack.MenuItem_Add_Font();
			#endif

			#if(ASMDEF_BLUEBACK_GL)
			Package_BlueBack.MenuItem_Add_Gl();
			#endif

			#if(ASMDEF_BLUEBACK_INSTALL)
			Package_BlueBack.MenuItem_Add_Install();
			#endif

			#if(ASMDEF_BLUEBACK_JSONITEM)
			Package_BlueBack.MenuItem_Add_JsonItem();
			#endif

			#if(ASMDEF_BLUEBACK_MATH)
			Package_BlueBack.MenuItem_Add_Math();
			#endif

			#if(ASMDEF_BLUEBACK_MOUSE)
			Package_BlueBack.MenuItem_Add_Mouse();
			#endif

			#if(ASMDEF_BLUEBACK_PAD)
			Package_BlueBack.MenuItem_Add_Pad();
			#endif

			#if(ASMDEF_BLUEBACK_POOLLIST)
			Package_BlueBack.MenuItem_Add_PoolList();
			#endif

			#if(ASMDEF_BLUEBACK_REQUEST)
			Package_BlueBack.MenuItem_Add_Request();
			#endif

			#if(ASMDEF_BLUEBACK_SCENE)
			Package_BlueBack.MenuItem_Add_Scene();
			#endif

			#if(ASMDEF_BLUEBACK_SLACKWEBAPI)
			Package_BlueBack.MenuItem_Add_SlackWebApi();
			#endif

			#if(ASMDEF_BLUEBACK_TESTLIB)
			Package_BlueBack.MenuItem_Add_TestLib();
			#endif

			#if(ASMDEF_BLUEBACK_TIMESCALE)
			Package_BlueBack.MenuItem_Add_TimeScale();
			#endif

			#if(ASMDEF_BLUEBACK_UNITYPLAYERLOOP)
			Package_BlueBack.MenuItem_Add_UnityPlayerLoop();
			#endif

			#if(ASMDEF_BLUEBACK_VARIABLEDIGIT)
			Package_BlueBack.MenuItem_Add_VariableDigit();
			#endif

			#if(ASMDEF_BLUEBACK_VERSIONMANAGER)
			Package_BlueBack.MenuItem_Add_VersionManager();
			#endif

			#if(ASMDEF_BLUEBACK_VOSK)
			Package_BlueBack.MenuItem_Add_Vosk();
			#endif

		}
	}
}
#endif

