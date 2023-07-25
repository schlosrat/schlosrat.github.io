// Decompiled with JetBrains decompiler
// Type: RTG.CameraMoveSettings
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
  public class CameraMoveSettings : Settings
  {
    private static readonly float _minMoveSpeed;
    [SerializeField]
    private float _moveSpeed;
    [SerializeField]
    private float _accelerationRate;

    public float MoveSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float AccelerationRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraMoveSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CameraMoveSettings() => throw null;
  }
}
