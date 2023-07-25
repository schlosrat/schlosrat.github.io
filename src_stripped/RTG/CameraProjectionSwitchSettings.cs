// Decompiled with JetBrains decompiler
// Type: RTG.CameraProjectionSwitchSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class CameraProjectionSwitchSettings : Settings
  {
    [SerializeField]
    private CameraProjectionSwitchMode _switchMode;
    [SerializeField]
    private float _transitionDurationInSeconds;

    public CameraProjectionSwitchMode SwitchMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float TransitionDurationInSeconds
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraProjectionSwitchSettings() => throw null;
  }
}
