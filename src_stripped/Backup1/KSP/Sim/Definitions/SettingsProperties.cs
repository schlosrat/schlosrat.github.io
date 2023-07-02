// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.SettingsProperties
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
