
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
    [Route("api/Application")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class ApplicationController
        : BaseApiController<UndergraduateResearchPortal.Data.Models.Application, ApplicationDtoGen, UndergraduateResearchPortal.Data.AppDbContext>
    {
        public ApplicationController(UndergraduateResearchPortal.Data.AppDbContext db) : base(db)
        {
            GeneratedForClassViewModel = ReflectionRepository.Global.GetClassViewModel<UndergraduateResearchPortal.Data.Models.Application>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<ApplicationDtoGen>> Get(
            System.Guid id,
            DataSourceParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.Application> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<ApplicationDtoGen>> List(
            ListParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.Application> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.Application> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<ApplicationDtoGen>> Save(
            ApplicationDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.Application> dataSource,
            IBehaviors<UndergraduateResearchPortal.Data.Models.Application> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<ApplicationDtoGen>> Delete(
            System.Guid id,
            IBehaviors<UndergraduateResearchPortal.Data.Models.Application> behaviors,
            IDataSource<UndergraduateResearchPortal.Data.Models.Application> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
