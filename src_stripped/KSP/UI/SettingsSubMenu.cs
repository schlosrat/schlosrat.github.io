// Decompiled with JetBrains decompiler
// Type: KSP.UI.SettingsSubMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public abstract class SettingsSubMenu : KerbalMonoBehaviour
  {
    public SettingsConfigVariables settingsConfigVariables;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnShow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Apply() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Revert() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CheckUnsavedSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected SettingsSubMenu() => throw null;
  }
}
