﻿using Autofac;
using Core;
using Microsoft.Extensions.Localization;
using System;
using System.Linq;
using System.Reflection;
using XperienceAdapter.Localization;
using XperienceAdapter.Repositories;
using XperienceAdapter.Services;

namespace MedioClinic.Configuration
{
    public class AutoFacConfig
    {
        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .Where(type => type.IsClass && !type.IsAbstract && typeof(IService).IsAssignableFrom(type))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .Where(type => type.GetTypeInfo()
                    .ImplementedInterfaces.Any(
                        @interface => @interface.IsGenericType && @interface.GetGenericTypeDefinition() == typeof(IRepository<>)))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .Where(type => type.GetTypeInfo()
                    .ImplementedInterfaces.Any(
                        @interface => @interface.IsGenericType && @interface.GetGenericTypeDefinition() == typeof(IPageRepository<,>)))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterType<XperienceStringLocalizerFactory>()
                .As<IStringLocalizerFactory>()
                .InstancePerLifetimeScope();

            builder.RegisterType<RepositoryServices>()
                .As<IRepositoryServices>()
                .InstancePerLifetimeScope();
        }
    }
}
