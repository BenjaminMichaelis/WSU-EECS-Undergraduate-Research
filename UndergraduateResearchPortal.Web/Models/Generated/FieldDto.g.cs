using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace UndergraduateResearchPortal.Web.Models
{
    public partial class FieldDtoGen : GeneratedDto<UndergraduateResearchPortal.Data.Models.Field>
    {
        public FieldDtoGen() { }

        private System.Guid? _FieldId;
        private string _Name;

        public System.Guid? FieldId
        {
            get => _FieldId;
            set { _FieldId = value; Changed(nameof(FieldId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(UndergraduateResearchPortal.Data.Models.Field obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            // Fill the properties of the object.

            this.FieldId = obj.FieldId;
            this.Name = obj.Name;
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(UndergraduateResearchPortal.Data.Models.Field entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(FieldId))) entity.FieldId = (FieldId ?? entity.FieldId);
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
        }
    }
}
