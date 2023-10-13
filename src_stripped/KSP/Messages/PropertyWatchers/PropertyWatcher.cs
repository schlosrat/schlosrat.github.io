// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.PropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Game.Missions.Definitions;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [Serializable]
  public class PropertyWatcher
  {
    public Action<int> OnIntChanged;
    public Action<double> OnDoubleChanged;
    public Action<string> OnStringChanged;
    public Action<int> OnEnumChanged;
    public Action<bool> OnBoolChanged;
    private string _lastString;
    private int _lastInt;
    private double _lastDouble;
    private bool _lastBool;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ViewDataProvider ViewDataProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Type baseType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void MissionStageActivated(string missionID, string inputValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void MissionStageDeactivated(string missionID, string inputValue) => throw null;

    public virtual bool IsValid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PollForValueChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string GetValueString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetValueInt() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool GetValueBool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string GetValueString(string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool GetValueBool(string missionID, string inputValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetValueInt(MissionData missionData, string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyWatcher() => throw null;
  }
}
