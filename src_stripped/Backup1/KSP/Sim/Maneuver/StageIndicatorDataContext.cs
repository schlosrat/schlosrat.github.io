// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Maneuver.StageIndicatorDataContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Maneuver
{
  public class StageIndicatorDataContext : ApiDataContext
  {
    public int StageID;
    public Property<int> DisplayStageID;
    public PropertyExternal<float> StagePos;
    private float _marker;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StageIndicatorDataContext(int stageID, int displayStageID, float stagePos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateStagePos(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetStagePos() => throw null;
  }
}
