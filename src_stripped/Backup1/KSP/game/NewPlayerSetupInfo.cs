// Decompiled with JetBrains decompiler
// Type: KSP.Game.NewPlayerSetupInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class NewPlayerSetupInfo
  {
    public const NewPlayerAgencyChoice DEFAULT_AGENCY_CHOICE = NewPlayerAgencyChoice.None;
    public static string DEFAULT_NEW_AGENCY_NAME;
    public static Color DEFAULT_NEW_AGENCY_COLOR_BASE;
    public static Color DEFAULT_NEW_AGENCY_COLOR_ACCENT;
    public static string DEFAULT_NEW_AGENCY_FLAG_SPRITE_LOCATION;
    public const int DEFAULT_EXISTING_AGENCY_ID = 0;
    public const bool DEFAULT_IS_FTUE_ENABLED = false;
    private NewPlayerAgencyChoice _agencyChoice;
    private string _newAgencyName;
    private Color _newAgencyColorBase;
    private Color _newAgencyColorAccent;
    private string _newAgencyFlagSpriteLocation;
    private int _existingAgencyId;
    private bool _isFTUEEnabled;

    public NewPlayerAgencyChoice AgencyChoice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAgencyChoice(NewPlayerAgencyChoice agencyChoice) => throw null;

    public string NewAgencyName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNewAgencyName(string newAgencyName) => throw null;

    public Color NewAgencyColorBase
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNewAgencyColorBase(Color newAgencyColorBase) => throw null;

    public Color NewAgencyColorAccent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNewAgencyColorAccent(Color newAgencyColorAccent) => throw null;

    public string NewAgencyFlagSpriteLocation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNewAgencyFlagSpriteLocation(string newAgencyFlagSpriteLocation) => throw null;

    public int ExistingAgencyId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetExistingAgencyId(int existingAgencyId) => throw null;

    public bool IsFTUEEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetIsFTUEEnabled(bool isFTUEEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NewPlayerSetupInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NewPlayerSetupInfo(
      NewPlayerAgencyChoice agencyChoice,
      string newAgencyName,
      Color newAgencyColorBase,
      Color newAgencyColorAccent,
      string newAgencyFlagSpriteLocation,
      int existingAgencyId,
      bool isFTUEEnabled)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NewPlayerSetupInfo(NewPlayerSetupInfo src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~NewPlayerSetupInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(
      NewPlayerAgencyChoice agencyChoice,
      string newAgencyName,
      Color newAgencyColorBase,
      Color newAgencyColorAccent,
      string newAgencyFlagSpriteLocation,
      int existingAgencyId,
      bool isFTUEEnabled)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(NewPlayerSetupInfo src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(
      NewPlayerAgencyChoice agencyChoice,
      string newAgencyName,
      Color newAgencyColorBase,
      Color newAgencyColorAccent,
      string newAgencyFlagSpriteLocation,
      int existingAgencyId,
      bool isFTUEEnabled)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(NewPlayerSetupInfo src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString(bool abbrev = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Matches(NewPlayerSetupInfo other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SanityChecks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static NewPlayerSetupInfo() => throw null;
  }
}
