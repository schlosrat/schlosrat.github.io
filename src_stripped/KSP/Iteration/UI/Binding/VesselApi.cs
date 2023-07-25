// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.Binding.VesselApi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
