// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValueBinder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.UI.Binding.Core
{
  public abstract class UIValueBinder : UIDataContextBindBase, IUIValueBinder, IUIValueBindable
  {
    [FormerlySerializedAs("key")]
    [SerializeField]
    protected string valueKey;
    protected Action<bool> IsBoundChanged;
    protected bool IsContextKeyResolved;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnClick() => throw null;

    public string ValueKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    protected override bool CheckSelfForContextProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool HaveValueKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object GetObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetObject(object value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T GetObjectAs<T>() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetObjectAs<T>(T value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetObjectAs<T>(out T value) => throw null;

    public bool IsBound
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public System.Type BoundType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsConvertible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsEnum
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    private string LogTag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected IProperty PropertyReadOnly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    protected IPropertyWritable PropertyWritable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    protected Action<object> BoundSetter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    protected Func<object> BoundGetter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void BindContext(IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CheckForKeyRebinds(IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CheckForMetadataChanges(IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void UpdateBoundValueFromContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void UpdateMetadataFromContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void BindValue(IProperty valueProperty) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InternalSetBool(object newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InternalSetConvertible(object newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private object ParseEnum(System.Type enumType, string value, object defaultValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InternalSetEnum(object newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InternalSetValueType(object newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnValueChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected UIValueBinder() => throw null;
  }
}
