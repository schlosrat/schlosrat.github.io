// Decompiled with JetBrains decompiler
// Type: MoonSharp.VsCodeDebugger.SDK.Capabilities
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.VsCodeDebugger.SDK
{
  public class Capabilities : ResponseBody
  {
    public bool supportsConfigurationDoneRequest;
    public bool supportsFunctionBreakpoints;
    public bool supportsConditionalBreakpoints;
    public bool supportsEvaluateForHovers;
    public object[] exceptionBreakpointFilters;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Capabilities() => throw null;
  }
}
