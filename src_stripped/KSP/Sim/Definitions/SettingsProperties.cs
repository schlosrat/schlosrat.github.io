// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.SettingsProperties
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
