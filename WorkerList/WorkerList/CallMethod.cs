using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace WorkerList
{
    public class CallMethod : MarkupExtension
    {

        public string MethodName { get; set; }

        public CallMethod(string name)
        {
            MethodName = name;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            IProvideValueTarget targetProvider = serviceProvider.GetService(typeof(IProvideValueTarget)) as IProvideValueTarget;
            Type delegateType = null;

            if (targetProvider.TargetProperty.GetType().BaseType == typeof(EventInfo))
            {
                EventInfo targetEventInfo = targetProvider.TargetProperty as EventInfo;
                delegateType = targetEventInfo.EventHandlerType;
            }
            else
            {
                MethodInfo targetEventMethodInfo = targetProvider.TargetProperty as MethodInfo;
                ParameterInfo[] parameters = targetEventMethodInfo.GetParameters();
                delegateType = parameters[1].ParameterType;
            }

            FrameworkElement frameworkElement = targetProvider.TargetObject as FrameworkElement;
            MethodInfo methodInfo = frameworkElement.DataContext.GetType().GetMethod(MethodName, BindingFlags.Public | BindingFlags.Instance);
            Delegate returnedDelegate = Delegate.CreateDelegate(delegateType, frameworkElement.DataContext, methodInfo);


            return returnedDelegate;
        }
    }
}
