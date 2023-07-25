// Decompiled with JetBrains decompiler
// Type: KSP.UI.OptionToggleContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public class OptionToggleContext : ApiDataContext
  {
    public string Id;
    [DataProperty("toggleText")]
    public Property<string> ToggleText;
    [DataProperty("toggleValue")]
    public Property<bool> ToggleValue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OptionToggleContext(string id, string toggleText) => throw null;
  }
}
