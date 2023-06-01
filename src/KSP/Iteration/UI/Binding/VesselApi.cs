// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.Binding.VesselApi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using System.Runtime.CompilerServices;

namespace KSP.Iteration.UI.Binding
{
  public class VesselApi : ApiDataContext
  {
    [DataList("parts")]
    public ContextListProperty<Part> parts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [DataSubContext("rootPart")]
    public Part rootPart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselApi() => throw null;

    [DataAction("addPart")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPart(string name = "unnamed") => throw null;
  }
}
