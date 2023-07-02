// Decompiled with JetBrains decompiler
// Type: I2.Loc.LanguageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace I2.Loc
{
  [Serializable]
  public class LanguageData
  {
    public string Name;
    public string Code;
    public byte Flags;
    [NonSerialized]
    public bool Compressed;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEnabled(bool bEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsLoaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CanBeUnloaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLoaded(bool loaded) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCanBeUnLoaded(bool allowUnloading) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LanguageData() => throw null;
  }
}
