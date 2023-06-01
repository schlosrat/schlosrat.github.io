// Decompiled with JetBrains decompiler
// Type: KSP.Game.LoadOrSaveCampaignFailureCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
