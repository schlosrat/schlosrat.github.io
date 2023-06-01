// Decompiled with JetBrains decompiler
// Type: KSP.Game.LoadOrSaveCampaignOperation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
