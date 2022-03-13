using CMS.Core;
using Identity;
using Identity.Models.Profile;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;

namespace MedioClinic.Areas.Identity.ModelBinders
{
    public class UserModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Metadata.ModelType != typeof(IUserViewModel))
            {
                return null!;
            }

            var classes = new[] { typeof(DoctorViewModel), typeof(PatientViewModel) };
            var binders = new Dictionary<Type, (ModelMetadata, IModelBinder)>();

            foreach (var type in classes)
            {
                var modelMetadata = context.MetadataProvider.GetMetadataForType(type);
                binders[type] = (modelMetadata, context.CreateBinder(modelMetadata));
            }

            var userManager = Service.Resolve<MedioClinicUserManager>();

            return new UserModelBinder(userManager, binders);
        }
    }
}
