// Decompiled with JetBrains decompiler
// Type: KSP.Game.LoadOrSaveCampaignOperation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.Game
{
  public enum LoadOrSaveCampaignOperation
  {
    None,
    Load_StartNewCampaign,
    Load_StartExistingCampaignFromJsonString,
    Load_LoadGameFromAsset,
    Load_LoadGameFromAddressable,
    Load_LoadGameFromFile,
    Load_LoadGameFromBuffer,
    Save_SaveGameToFile,
    Save_SaveGameToMemory,
    Save_SaveSpecificPlayerToFile,
    Save_SaveSpecificPlayerToMemory,
    DeleteSaveFile,
    DeleteDirectory,
  }
}
