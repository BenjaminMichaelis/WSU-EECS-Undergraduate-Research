using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace UndergraduateResearchPortal.Web.Models
{
    public partial class ApplicationDtoGen : GeneratedDto<UndergraduateResearchPortal.Data.Models.Application>
    {
        public ApplicationDtoGen() { }

        private System.Guid? _ApplicationId;
        private UndergraduateResearchPortal.Web.Models.UserDtoGen _User;
        private string _PreferredName;
        private string _Description;
        private string _ReferenceName;
        private string _ReferenceEmail;
        private bool? _ApprovedForInterview;
        private bool? _Hired;
        private bool? _NotHired;

        public System.Guid? ApplicationId
        {
            get => _ApplicationId;
            set { _ApplicationId = value; Changed(nameof(ApplicationId)); }
        }
        public UndergraduateResearchPortal.Web.Models.UserDtoGen User
        {
            get => _User;
            set { _User = value; Changed(nameof(User)); }
        }
        public string PreferredName
        {
            get => _PreferredName;
            set { _PreferredName = value; Changed(nameof(PreferredName)); }
        }
        public string Description
        {
            get => _Description;
            set { _Description = value; Changed(nameof(Description)); }
        }
        public string ReferenceName
        {
            get => _ReferenceName;
            set { _ReferenceName = value; Changed(nameof(ReferenceName)); }
        }
        public string ReferenceEmail
        {
            get => _ReferenceEmail;
            set { _ReferenceEmail = value; Changed(nameof(ReferenceEmail)); }
        }
        public bool? ApprovedForInterview
        {
            get => _ApprovedForInterview;
            set { _ApprovedForInterview = value; Changed(nameof(ApprovedForInterview)); }
        }
        public bool? Hired
        {
            get => _Hired;
            set { _Hired = value; Changed(nameof(Hired)); }
        }
        public bool? NotHired
        {
            get => _NotHired;
            set { _NotHired = value; Changed(nameof(NotHired)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(UndergraduateResearchPortal.Data.Models.Application obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            // Fill the properties of the object.

            this.ApplicationId = obj.ApplicationId;
            this.PreferredName = obj.PreferredName;
            this.Description = obj.Description;
            this.ReferenceName = obj.ReferenceName;
            this.ReferenceEmail = obj.ReferenceEmail;
            this.ApprovedForInterview = obj.ApprovedForInterview;
            this.Hired = obj.Hired;
            this.NotHired = obj.NotHired;
            if (tree == null || tree[nameof(this.User)] != null)
                this.User = obj.User.MapToDto<UndergraduateResearchPortal.Data.Models.User, UserDtoGen>(context, tree?[nameof(this.User)]);

        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(UndergraduateResearchPortal.Data.Models.Application entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(ApplicationId))) entity.ApplicationId = (ApplicationId ?? entity.ApplicationId);
            if (ShouldMapTo(nameof(PreferredName))) entity.PreferredName = PreferredName;
            if (ShouldMapTo(nameof(Description))) entity.Description = Description;
            if (ShouldMapTo(nameof(ReferenceName))) entity.ReferenceName = ReferenceName;
            if (ShouldMapTo(nameof(ReferenceEmail))) entity.ReferenceEmail = ReferenceEmail;
            if (ShouldMapTo(nameof(ApprovedForInterview))) entity.ApprovedForInterview = (ApprovedForInterview ?? entity.ApprovedForInterview);
            if (ShouldMapTo(nameof(Hired))) entity.Hired = (Hired ?? entity.Hired);
            if (ShouldMapTo(nameof(NotHired))) entity.NotHired = (NotHired ?? entity.NotHired);
        }
    }
}
