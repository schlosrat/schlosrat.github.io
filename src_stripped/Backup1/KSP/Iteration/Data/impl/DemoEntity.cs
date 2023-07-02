// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.Data.impl.DemoEntity
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Api.Generic;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Iteration.Data.impl
{
  [Serializable]
  public class DemoEntity : IDemoEntity
  {
    [SerializeField]
    private string guid;
    [SerializeField]
    private int score;
    [SerializeField]
    private string name;
    public PropertyExternal<string> GuidInternal;
    public PropertyExternal<int> ScoreInternal;
    public PropertyExternal<string> NameInternal;

    public IProperty<string> Guid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IProperty<int> Score
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IPropertyWritable<string> Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DemoEntity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Randomize() => throw null;
  }
}
