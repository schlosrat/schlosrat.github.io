// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.Authentication.Models.PlayerProfileViewConstraints
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Networking.OnlineServices.Authentication.Models
{
  [Serializable]
  public class PlayerProfileViewConstraints
  {
    public bool ShowAvatarUrl;
    public bool ShowBannedUntil;
    public bool ShowCampaignAttributions;
    public bool ShowContactEmailAddresses;
    public bool ShowCreated;
    public bool ShowDisplayName;
    public bool ShowExperimentVariants;
    public bool ShowLastLogin;
    public bool ShowLinkedAccounts;
    public bool ShowLocations;
    public bool ShowMemberships;
    public bool ShowOrigination;
    public bool ShowPushNotificationRegistrations;
    public bool ShowStatistics;
    public bool ShowTags;
    public bool ShowTotalValueToDateInUsd;
    public bool ShowValuesToDate;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlayerProfileViewConstraints() => throw null;
  }
}
