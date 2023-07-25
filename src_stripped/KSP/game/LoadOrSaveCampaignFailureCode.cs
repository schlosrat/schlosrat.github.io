// Decompiled with JetBrains decompiler
// Type: KSP.Game.LoadOrSaveCampaignFailureCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
