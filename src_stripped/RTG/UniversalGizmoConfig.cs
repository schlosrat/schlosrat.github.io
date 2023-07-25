// Decompiled with JetBrains decompiler
// Type: RTG.UniversalGizmoConfig
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
  public class UniversalGizmoConfig : Settings
  {
    [SerializeField]
    private UniversalGizmoSettingsCategory _inheritCategory;
    [SerializeField]
    private UniversalGizmoSettingsType _inheritType;
    [SerializeField]
    private UniversalGizmoSettingsCategory _displayCategory;

    public UniversalGizmoSettingsCategory InheritCategory
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public UniversalGizmoSettingsType InheritType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public UniversalGizmoSettingsCategory DisplayCategory
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UniversalGizmoConfig() => throw null;
  }
}
