// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.SettingsProperties
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Definitions
{
  public struct SettingsProperties
  {
    public string name;
    public Dictionary<string, SettingsProperty> settings;
    private bool isValid;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SettingsProperties Defaults() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetValid(bool setValid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsValid() => throw null;
  }
}
