
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
    [Route("api/Post")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class PostController
        : BaseApiController<UndergraduateResearchPortal.Data.Models.Post, PostDtoGen, UndergraduateResearchPortal.Data.AppDbContext>
    {
        public PostController(UndergraduateResearchPortal.Data.AppDbContext db) : base(db)
        {
            GeneratedForClassViewModel = ReflectionRepository.Global.GetClassViewModel<UndergraduateResearchPortal.Data.Models.Post>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<PostDtoGen>> Get(
            int id,
            DataSourceParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.Post> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<PostDtoGen>> List(
            ListParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.Post> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.Post> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<PostDtoGen>> Save(
            PostDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<UndergraduateResearchPortal.Data.Models.Post> dataSource,
            IBehaviors<UndergraduateResearchPortal.Data.Models.Post> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<PostDtoGen>> Delete(
            int id,
            IBehaviors<UndergraduateResearchPortal.Data.Models.Post> behaviors,
            IDataSource<UndergraduateResearchPortal.Data.Models.Post> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
