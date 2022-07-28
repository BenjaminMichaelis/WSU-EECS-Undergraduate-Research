
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
    [Route("api/User")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class UserController
        : BaseApiController<UndergraduateResearchPortal.Data.Models.User, UserDtoGen, UndergraduateResearchPortal.Data.AppDbContext>
    {
        public UserController(UndergraduateResearchPortal.Data.AppDbContext db) : base(db)
        {
            GeneratedForClassViewModel = ReflectionRepository.Global.GetClassViewModel<UndergraduateResearchPortal.Data.Models.User>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<UserDtoGen>> Get(
            string id,
            DataSourceParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.User> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<UserDtoGen>> List(
            ListParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.User> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.User> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<UserDtoGen>> Save(
            UserDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.User> dataSource,
            IBehaviors<UndergraduateResearchPortal.Data.Models.User> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<UserDtoGen>> Delete(
            string id,
            IBehaviors<UndergraduateResearchPortal.Data.Models.User> behaviors,
            IDataSource<UndergraduateResearchPortal.Data.Models.User> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
