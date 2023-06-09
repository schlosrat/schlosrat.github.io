﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.MissionDialogEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Utilities;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  public class MissionDialogEntry : MonoBehaviour
  {
    [SerializeField]
    private ButtonExtended _buttonActivate;
    [SerializeField]
    private ButtonExtended _buttonReset;
    [SerializeField]
    private TextMeshProUGUI _labelMissionName;
    private bool _isInitialized;
    private string MissionID;

    public GameObjectPool<MissionDialogEntry> ObjectPool
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(string ID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ActivateMision() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetMision() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReturnToPool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionDialogEntry() => throw null;
  }
}
