using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace UndergraduateResearchPortal.Web.Models
{
    public partial class LanguageDtoGen : GeneratedDto<UndergraduateResearchPortal.Data.Models.Language>
    {
        public LanguageDtoGen() { }

        private System.Guid? _LanguageId;
        private string _Name;

        public System.Guid? LanguageId
        {
            get => _LanguageId;
            set { _LanguageId = value; Changed(nameof(LanguageId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(UndergraduateResearchPortal.Data.Models.Language obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            // Fill the properties of the object.

            this.LanguageId = obj.LanguageId;
            this.Name = obj.Name;
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(UndergraduateResearchPortal.Data.Models.Language entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(LanguageId))) entity.LanguageId = (LanguageId ?? entity.LanguageId);
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
        }
    }
}
