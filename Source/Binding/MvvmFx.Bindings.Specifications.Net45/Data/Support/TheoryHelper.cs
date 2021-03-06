﻿using System;
using System.Collections.Generic;
using MvvmFx.Bindings.Specifications.Support.Entities;

namespace MvvmFx.Bindings.Specifications.Support
{
    public static class TheoryHelper
    {
        public static IEnumerable<Func<IPerson>> PersonFactories
        {
            get
            {
                yield return () => new MvvmFx.Bindings.Specifications.Support.Entities.INPC.Person();
                yield return () => new MvvmFx.Bindings.Specifications.Support.Entities.XxxChanged.Person();
                yield return () => new MvvmFx.Bindings.Specifications.Support.Entities.SystemDOs.Person();
                yield return () => new MvvmFx.Bindings.Specifications.Support.Entities.MvvmFxDOs.Person();
            }
        }

        public static IEnumerable<Func<IAddress>> AddressFactories
        {
            get
            {
                yield return () => new MvvmFx.Bindings.Specifications.Support.Entities.INPC.Address();
                yield return () => new MvvmFx.Bindings.Specifications.Support.Entities.XxxChanged.Address();
                yield return () => new MvvmFx.Bindings.Specifications.Support.Entities.SystemDOs.Address();
                yield return () => new MvvmFx.Bindings.Specifications.Support.Entities.MvvmFxDOs.Address();
            }
        }
    }
}