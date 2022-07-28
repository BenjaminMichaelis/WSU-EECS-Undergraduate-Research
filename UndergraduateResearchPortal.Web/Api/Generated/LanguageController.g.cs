
using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Api;
using IntelliTect.Coalesce.Api.Controllers;
using IntelliTect.Coalesce.Api.DataSources;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Mapping.IncludeTrees;
using IntelliTect.Coalesce.Models;
using IntelliTect.Coalesce.TypeDefinition;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using UndergraduateResearchPortal.Web.Models;

namespace UndergraduateResearchPortal.Web.Api
{
    [Route("api/Language")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class LanguageController
        : BaseApiController<UndergraduateResearchPortal.Data.Models.Language, LanguageDtoGen, UndergraduateResearchPortal.Data.AppDbContext>
    {
        public LanguageController(UndergraduateResearchPortal.Data.AppDbContext db) : base(db)
        {
            GeneratedForClassViewModel = ReflectionRepository.Global.GetClassViewModel<UndergraduateResearchPortal.Data.Models.Language>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<LanguageDtoGen>> Get(
            System.Guid id,
            DataSourceParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.Language> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<LanguageDtoGen>> List(
            ListParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.Language> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.Language> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<LanguageDtoGen>> Save(
            LanguageDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.Language> dataSource,
            IBehaviors<UndergraduateResearchPortal.Data.Models.Language> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<LanguageDtoGen>> Delete(
            System.Guid id,
            IBehaviors<UndergraduateResearchPortal.Data.Models.Language> behaviors,
            IDataSource<UndergraduateResearchPortal.Data.Models.Language> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
