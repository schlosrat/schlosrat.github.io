﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.VsCodeDebugger.SDK.Capabilities
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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