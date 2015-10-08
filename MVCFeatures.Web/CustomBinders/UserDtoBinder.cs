using MVCFeatures.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFeatures.Web.CustomBinders
{
    public class UserDtoBinder : DefaultModelBinder
    {
        protected override object GetPropertyValue(ControllerContext controllerContext, ModelBindingContext bindingContext, System.ComponentModel.PropertyDescriptor propertyDescriptor, IModelBinder propertyBinder)
        {
            if (propertyDescriptor.Name == "FirstName")
            {
                ValueProviderResult result = bindingContext.ValueProvider.GetValue("FirstName");
                string firstName = result.AttemptedValue;

                return string.Format("{0} Custom", firstName);
            }

            //let the default model binder do it's thing
            return base.GetPropertyValue(controllerContext, bindingContext, propertyDescriptor, propertyBinder);
        }

    } 
}