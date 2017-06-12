using System;
using System.Reflection;

namespace KeepEverything.Consumer.RaysaDutra.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}