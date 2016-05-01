namespace Nuget.Server.AzureStorage.Doman.Entities
{
    using NuGet;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Versioning;


    public class AzurePackageReferenceSet
    {
        public IEnumerable<string> References { get; set; }
        public string FrameWorkName { get; set; }

        public AzurePackageReferenceSet() { }
        public AzurePackageReferenceSet(PackageReferenceSet referenceSet)
        {
            References = referenceSet.References.ToList();
            FrameWorkName = referenceSet.TargetFramework == null ? null : referenceSet.TargetFramework.ToString();
        }

        public PackageReferenceSet GetReferenceSet()
        {
            return new PackageReferenceSet(string.IsNullOrEmpty(FrameWorkName)?null: new FrameworkName(FrameWorkName), References);
        }

    }
}
