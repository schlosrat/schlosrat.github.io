// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.Binding.VesselApi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
