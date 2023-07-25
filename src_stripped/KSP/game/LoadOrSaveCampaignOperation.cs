// Decompiled with JetBrains decompiler
// Type: KSP.Game.LoadOrSaveCampaignOperation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
