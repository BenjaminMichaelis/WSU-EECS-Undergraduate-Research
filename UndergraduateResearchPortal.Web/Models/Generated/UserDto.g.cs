using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace UndergraduateResearchPortal.Web.Models
{
    public partial class UserDtoGen : GeneratedDto<UndergraduateResearchPortal.Data.Models.User>
    {
        public UserDtoGen() { }

        private string _FirstName;
        private string _LastName;
        private int? _WSUId;
        private string _Major;
        private string _GraduationDate;
        private float? _GPA;
        private string _Experience;
        private string _ElectiveCourses;
        private string _Name;
        private string _Id;
        private string _UserName;
        private string _NormalizedUserName;
        private string _Email;
        private string _NormalizedEmail;
        private bool? _EmailConfirmed;
        private string _PasswordHash;
        private string _SecurityStamp;
        private string _ConcurrencyStamp;
        private string _PhoneNumber;
        private bool? _PhoneNumberConfirmed;
        private bool? _TwoFactorEnabled;
        private System.DateTimeOffset? _LockoutEnd;
        private bool? _LockoutEnabled;
        private int? _AccessFailedCount;

        public string FirstName
        {
            get => _FirstName;
            set { _FirstName = value; Changed(nameof(FirstName)); }
        }
        public string LastName
        {
            get => _LastName;
            set { _LastName = value; Changed(nameof(LastName)); }
        }
        public int? WSUId
        {
            get => _WSUId;
            set { _WSUId = value; Changed(nameof(WSUId)); }
        }
        public string Major
        {
            get => _Major;
            set { _Major = value; Changed(nameof(Major)); }
        }
        public string GraduationDate
        {
            get => _GraduationDate;
            set { _GraduationDate = value; Changed(nameof(GraduationDate)); }
        }
        public float? GPA
        {
            get => _GPA;
            set { _GPA = value; Changed(nameof(GPA)); }
        }
        public string Experience
        {
            get => _Experience;
            set { _Experience = value; Changed(nameof(Experience)); }
        }
        public string ElectiveCourses
        {
            get => _ElectiveCourses;
            set { _ElectiveCourses = value; Changed(nameof(ElectiveCourses)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }
        public string Id
        {
            get => _Id;
            set { _Id = value; Changed(nameof(Id)); }
        }
        public string UserName
        {
            get => _UserName;
            set { _UserName = value; Changed(nameof(UserName)); }
        }
        public string NormalizedUserName
        {
            get => _NormalizedUserName;
            set { _NormalizedUserName = value; Changed(nameof(NormalizedUserName)); }
        }
        public string Email
        {
            get => _Email;
            set { _Email = value; Changed(nameof(Email)); }
        }
        public string NormalizedEmail
        {
            get => _NormalizedEmail;
            set { _NormalizedEmail = value; Changed(nameof(NormalizedEmail)); }
        }
        public bool? EmailConfirmed
        {
            get => _EmailConfirmed;
            set { _EmailConfirmed = value; Changed(nameof(EmailConfirmed)); }
        }
        public string PasswordHash
        {
            get => _PasswordHash;
            set { _PasswordHash = value; Changed(nameof(PasswordHash)); }
        }
        public string SecurityStamp
        {
            get => _SecurityStamp;
            set { _SecurityStamp = value; Changed(nameof(SecurityStamp)); }
        }
        public string ConcurrencyStamp
        {
            get => _ConcurrencyStamp;
            set { _ConcurrencyStamp = value; Changed(nameof(ConcurrencyStamp)); }
        }
        public string PhoneNumber
        {
            get => _PhoneNumber;
            set { _PhoneNumber = value; Changed(nameof(PhoneNumber)); }
        }
        public bool? PhoneNumberConfirmed
        {
            get => _PhoneNumberConfirmed;
            set { _PhoneNumberConfirmed = value; Changed(nameof(PhoneNumberConfirmed)); }
        }
        public bool? TwoFactorEnabled
        {
            get => _TwoFactorEnabled;
            set { _TwoFactorEnabled = value; Changed(nameof(TwoFactorEnabled)); }
        }
        public System.DateTimeOffset? LockoutEnd
        {
            get => _LockoutEnd;
            set { _LockoutEnd = value; Changed(nameof(LockoutEnd)); }
        }
        public bool? LockoutEnabled
        {
            get => _LockoutEnabled;
            set { _LockoutEnabled = value; Changed(nameof(LockoutEnabled)); }
        }
        public int? AccessFailedCount
        {
            get => _AccessFailedCount;
            set { _AccessFailedCount = value; Changed(nameof(AccessFailedCount)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(UndergraduateResearchPortal.Data.Models.User obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            // Fill the properties of the object.

            this.FirstName = obj.FirstName;
            this.LastName = obj.LastName;
            this.WSUId = obj.WSUId;
            this.Major = obj.Major;
            this.GraduationDate = obj.GraduationDate;
            this.GPA = obj.GPA;
            this.Experience = obj.Experience;
            this.ElectiveCourses = obj.ElectiveCourses;
            this.Name = obj.Name;
            this.Id = obj.Id;
            this.UserName = obj.UserName;
            this.NormalizedUserName = obj.NormalizedUserName;
            this.Email = obj.Email;
            this.NormalizedEmail = obj.NormalizedEmail;
            this.EmailConfirmed = obj.EmailConfirmed;
            this.PasswordHash = obj.PasswordHash;
            this.SecurityStamp = obj.SecurityStamp;
            this.ConcurrencyStamp = obj.ConcurrencyStamp;
            this.PhoneNumber = obj.PhoneNumber;
            this.PhoneNumberConfirmed = obj.PhoneNumberConfirmed;
            this.TwoFactorEnabled = obj.TwoFactorEnabled;
            this.LockoutEnd = obj.LockoutEnd;
            this.LockoutEnabled = obj.LockoutEnabled;
            this.AccessFailedCount = obj.AccessFailedCount;
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(UndergraduateResearchPortal.Data.Models.User entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(FirstName))) entity.FirstName = FirstName;
            if (ShouldMapTo(nameof(LastName))) entity.LastName = LastName;
            if (ShouldMapTo(nameof(WSUId))) entity.WSUId = (WSUId ?? entity.WSUId);
            if (ShouldMapTo(nameof(Major))) entity.Major = Major;
            if (ShouldMapTo(nameof(GraduationDate))) entity.GraduationDate = GraduationDate;
            if (ShouldMapTo(nameof(GPA))) entity.GPA = (GPA ?? entity.GPA);
            if (ShouldMapTo(nameof(Experience))) entity.Experience = Experience;
            if (ShouldMapTo(nameof(ElectiveCourses))) entity.ElectiveCourses = ElectiveCourses;
            if (ShouldMapTo(nameof(Id))) entity.Id = Id;
            if (ShouldMapTo(nameof(UserName))) entity.UserName = UserName;
            if (ShouldMapTo(nameof(NormalizedUserName))) entity.NormalizedUserName = NormalizedUserName;
            if (ShouldMapTo(nameof(Email))) entity.Email = Email;
            if (ShouldMapTo(nameof(NormalizedEmail))) entity.NormalizedEmail = NormalizedEmail;
            if (ShouldMapTo(nameof(EmailConfirmed))) entity.EmailConfirmed = (EmailConfirmed ?? entity.EmailConfirmed);
            if (ShouldMapTo(nameof(PasswordHash))) entity.PasswordHash = PasswordHash;
            if (ShouldMapTo(nameof(SecurityStamp))) entity.SecurityStamp = SecurityStamp;
            if (ShouldMapTo(nameof(ConcurrencyStamp))) entity.ConcurrencyStamp = ConcurrencyStamp;
            if (ShouldMapTo(nameof(PhoneNumber))) entity.PhoneNumber = PhoneNumber;
            if (ShouldMapTo(nameof(PhoneNumberConfirmed))) entity.PhoneNumberConfirmed = (PhoneNumberConfirmed ?? entity.PhoneNumberConfirmed);
            if (ShouldMapTo(nameof(TwoFactorEnabled))) entity.TwoFactorEnabled = (TwoFactorEnabled ?? entity.TwoFactorEnabled);
            if (ShouldMapTo(nameof(LockoutEnd))) entity.LockoutEnd = LockoutEnd;
            if (ShouldMapTo(nameof(LockoutEnabled))) entity.LockoutEnabled = (LockoutEnabled ?? entity.LockoutEnabled);
            if (ShouldMapTo(nameof(AccessFailedCount))) entity.AccessFailedCount = (AccessFailedCount ?? entity.AccessFailedCount);
        }
    }
}
