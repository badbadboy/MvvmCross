// IMvxLayoutInfactorFactory.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System.Collections.Generic;
using Android.Views;
using Cirrious.MvvmCross.Binding.Bindings;

namespace Cirrious.MvvmCross.Binding.Droid.Binders
{
    public interface IMvxLayoutInfactorFactory
        : LayoutInflater.IFactory
    {
        List<IMvxUpdateableBinding> CreatedBindings { get; }
    }
}