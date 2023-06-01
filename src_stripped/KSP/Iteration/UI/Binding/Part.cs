// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.Binding.Part
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using System.Runtime.CompilerServices;

namespace KSP.Iteration.UI.Binding
{
  public class Part : ApiDataContext
  {
    [DataProperty("name")]
    public PropertyReadonly<string> name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [DataProperty("isOn")]
    public Property<bool> isOn
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Part(string name) => throw null;

    [DataAction("toggleIsOn")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleIsOn() => throw null;
  }
}
