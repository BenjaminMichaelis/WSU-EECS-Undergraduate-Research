using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace UndergraduateResearchPortal.Web.Models
{
    public partial class PostDtoGen : GeneratedDto<UndergraduateResearchPortal.Data.Models.Post>
    {
        public PostDtoGen() { }

        private int? _PostID;
        private string _Title;
        private string _Description;
        private System.DateTime? _StartDate;
        private System.DateTime? _EndDate;
        private int? _TimeCommitment;
        private string _Qualifications;
        private UndergraduateResearchPortal.Web.Models.UserDtoGen _User;
        private System.DateTime? _CreationDate;

        public int? PostID
        {
            get => _PostID;
            set { _PostID = value; Changed(nameof(PostID)); }
        }
        public string Title
        {
            get => _Title;
            set { _Title = value; Changed(nameof(Title)); }
        }
        public string Description
        {
            get => _Description;
            set { _Description = value; Changed(nameof(Description)); }
        }
        public System.DateTime? StartDate
        {
            get => _StartDate;
            set { _StartDate = value; Changed(nameof(StartDate)); }
        }
        public System.DateTime? EndDate
        {
            get => _EndDate;
            set { _EndDate = value; Changed(nameof(EndDate)); }
        }
        public int? TimeCommitment
        {
            get => _TimeCommitment;
            set { _TimeCommitment = value; Changed(nameof(TimeCommitment)); }
        }
        public string Qualifications
        {
            get => _Qualifications;
            set { _Qualifications = value; Changed(nameof(Qualifications)); }
        }
        public UndergraduateResearchPortal.Web.Models.UserDtoGen User
        {
            get => _User;
            set { _User = value; Changed(nameof(User)); }
        }
        public System.DateTime? CreationDate
        {
            get => _CreationDate;
            set { _CreationDate = value; Changed(nameof(CreationDate)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(UndergraduateResearchPortal.Data.Models.Post obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            // Fill the properties of the object.

            this.PostID = obj.PostID;
            this.Title = obj.Title;
            this.Description = obj.Description;
            this.StartDate = obj.StartDate;
            this.EndDate = obj.EndDate;
            this.TimeCommitment = obj.TimeCommitment;
            this.Qualifications = obj.Qualifications;
            this.CreationDate = obj.CreationDate;
            if (tree == null || tree[nameof(this.User)] != null)
                this.User = obj.User.MapToDto<UndergraduateResearchPortal.Data.Models.User, UserDtoGen>(context, tree?[nameof(this.User)]);

        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(UndergraduateResearchPortal.Data.Models.Post entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(PostID))) entity.PostID = (PostID ?? entity.PostID);
            if (ShouldMapTo(nameof(Title))) entity.Title = Title;
            if (ShouldMapTo(nameof(Description))) entity.Description = Description;
            if (ShouldMapTo(nameof(StartDate))) entity.StartDate = (StartDate ?? entity.StartDate);
            if (ShouldMapTo(nameof(EndDate))) entity.EndDate = (EndDate ?? entity.EndDate);
            if (ShouldMapTo(nameof(TimeCommitment))) entity.TimeCommitment = (TimeCommitment ?? entity.TimeCommitment);
            if (ShouldMapTo(nameof(Qualifications))) entity.Qualifications = Qualifications;
            if (ShouldMapTo(nameof(CreationDate))) entity.CreationDate = (CreationDate ?? entity.CreationDate);
        }
    }
}
