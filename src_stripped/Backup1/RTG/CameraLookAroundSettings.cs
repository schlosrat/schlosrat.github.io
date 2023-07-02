// Decompiled with JetBrains decompiler
// Type: RTG.CameraLookAroundSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class CameraLookAroundSettings : Settings
  {
    [SerializeField]
    private CameraLookAroundMode _lookAroundMode;
    [SerializeField]
    private float _standardLookAroundSensitivity;
    [SerializeField]
    private float _smoothLookAroundSensitivity;
    [SerializeField]
    private float smoothValue;
    [SerializeField]
    private bool _invertX;
    [SerializeField]
    private bool _invertY;
    [SerializeField]
    private bool _isLookAroundEnabled;

    public CameraLookAroundMode LookAroundMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float StandardLookAroundSensitivity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float SmoothLookAroundSensitivity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float Sensitivity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SmoothValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool InvertX
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool InvertY
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsLookAroundEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraLookAroundSettings() => throw null;
  }
}
