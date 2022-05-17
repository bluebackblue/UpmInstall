

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief ツール。
*/


/** BlueBack.Install.Samples.Simple
*/
#if(!DEF_BLUEBACK_INSTALL_SAMPLES_DISABLE)
namespace BlueBack.Install.Samples.Simple
{
	/** MenuItem
	*/
	#if(UNITY_EDITOR)
	public static class MenuItem
	{
		/** MenuItem_Code
		*/
		[UnityEditor.MenuItem("Samples/BlueBack.Install/com.unity.mathematics")]
		private static void MenuItem_InstalUnityMathmetics()
		{
			BlueBack.Install.Editor.Package_Unity.MenuItem_Add_com_unity_mathematics();
		}
	}
	#endif
}
#endif

