using BrillianceCodingC.Interfaces;
using BrillianceCodingC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BrillianceCodingC.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArrayCalcController : ControllerBase
    {
        private readonly IRepository _repository;

        public ArrayCalcController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public int[] Reverse([FromQuery] int[] productIds)
        {
            try
            {
                ArrayModel arrayModel = new ArrayModel();
                arrayModel.productsIds = productIds;

                return _repository.Reverse(arrayModel);
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }

        [HttpGet]
        public int[] DeletePart(int position, [FromQuery] int[] productIds )
        {
            try
            {
                ArrayModel arrayModel = new ArrayModel();
                arrayModel.productsIds = productIds;
                arrayModel.postion = position;

                return _repository.DeletePart(arrayModel);
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }
    }
}
