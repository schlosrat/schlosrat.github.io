// Decompiled with JetBrains decompiler
// Type: KSP.Game.LoadOrSaveCampaignOperation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
