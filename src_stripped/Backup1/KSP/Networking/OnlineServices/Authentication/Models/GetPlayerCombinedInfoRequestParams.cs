// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.Authentication.Models.GetPlayerCombinedInfoRequestParams
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Networking.OnlineServices.Authentication.Models
{
  [Serializable]
  public class GetPlayerCombinedInfoRequestParams
  {
    public bool GetCharacterInventories;
    public bool GetCharacterList;
    public bool GetPlayerProfile;
    public bool GetPlayerStatistics;
    public bool GetTitleData;
    public bool GetUserAccountInfo;
    public bool GetUserData;
    public bool GetUserInventory;
    public bool GetUserReadOnlyData;
    public bool GetUserVirtualCurrency;
    public List<string> PlayerStatisticNames;
    public PlayerProfileViewConstraints ProfileConstraints;
    public List<string> TitleDataKeys;
    public List<string> UserDataKeys;
    public List<string> UserReadOnlyDataKeys;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GetPlayerCombinedInfoRequestParams() => throw null;
  }
}
