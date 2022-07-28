
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
    [Route("api/Field")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class FieldController
        : BaseApiController<UndergraduateResearchPortal.Data.Models.Field, FieldDtoGen, UndergraduateResearchPortal.Data.AppDbContext>
    {
        public FieldController(UndergraduateResearchPortal.Data.AppDbContext db) : base(db)
        {
            GeneratedForClassViewModel = ReflectionRepository.Global.GetClassViewModel<UndergraduateResearchPortal.Data.Models.Field>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<FieldDtoGen>> Get(
            System.Guid id,
            DataSourceParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.Field> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<FieldDtoGen>> List(
            ListParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.Field> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.Field> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<FieldDtoGen>> Save(
            FieldDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.Field> dataSource,
            IBehaviors<UndergraduateResearchPortal.Data.Models.Field> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<FieldDtoGen>> Delete(
            System.Guid id,
            IBehaviors<UndergraduateResearchPortal.Data.Models.Field> behaviors,
            IDataSource<UndergraduateResearchPortal.Data.Models.Field> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
