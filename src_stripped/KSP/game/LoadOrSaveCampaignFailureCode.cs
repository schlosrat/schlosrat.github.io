// Decompiled with JetBrains decompiler
// Type: KSP.Game.LoadOrSaveCampaignFailureCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

namespace KSP.Game
{
  public enum LoadOrSaveCampaignFailureCode
  {
    None,
    Error_CantStartBecauseAlreadyStarted,
    Error_CantStartUnsupportedStatus,
    Error_CantStartOperationIsNone,
    Error_CantStartOperationIsUnsupported,
    Error_BusyNone,
    Error_BusyLoading,
    Error_BusySaving,
    Error_BusyUnknown,
    Error_LoadFileDoesNotExist,
    Error_SaveFileIsReadOnly,
    Error_SaveFileAlreadyExists,
    Error_JsonDeserializeException,
    Error_CantDeleteFile,
    Error_CantDeleteDirectory,
    Error_SomeUnknownError,
  }
}
