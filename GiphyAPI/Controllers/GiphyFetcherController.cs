using DataLogic.Enums;
using DataLogic.Interfaces;
using DataLogic.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiphyAPI.Controllers
{
    [ApiController]
    [Route("API/GiphyFetcher")]
    public class GiphyFetcherController : ControllerBase
    {
        #region Members
        private IServiceManager Manager;
        #endregion

        #region Ctor
        public GiphyFetcherController(IServiceManager manager)
        {
            Manager = manager;
        }
        #endregion


        [HttpGet]
        [Route("GetAllTrendingGifs")]
        public async Task<IActionResult> GetAllTrendingGifs()
        {
            try
            {
                GiphyRequestModel operations = new GiphyRequestModel()
                {
                    Criteria = string.Empty,
                    Operation = DataLogic.Enums.GiphyEnums.E_OperationType.GetAllTrendingGifs
                };

                var response = await Manager.GetServiceOperations(E_ServiceType.GiphyFetcher).GetData(operations);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("GetSpecificGif")]
        public async Task<IActionResult> GetSpecificGif(string gif)
        {
            try
            {
                GiphyRequestModel operations = new GiphyRequestModel()
                {
                    Criteria = gif,
                    Operation = DataLogic.Enums.GiphyEnums.E_OperationType.SearchSpecificGif
                };

                var response = await Manager.GetServiceOperations(E_ServiceType.GiphyFetcher).GetData(operations);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

    }
}
