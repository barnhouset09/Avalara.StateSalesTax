using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalara.StateSalesTax.Data.Dtos;
using Avalara.StateSalesTax.Service.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Avalara.StateSalesTax.API.WebApi.Controllers
{
    /// <summary>
    /// Contains endpoints that offer the ability to calculate the amount of taxes for a given retail transaction.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class TaxRateCalculationController : ControllerBase
    {
        private readonly ITaxCalculationService _TaxCalculationService;

        public TaxRateCalculationController(ITaxCalculationService taxCalculationService)
        {
            _TaxCalculationService = taxCalculationService;
        }

        /// <summary>
        /// Calculates the total state taxes required for a given retail transaction. Currently only works for NC zip codes.
        /// </summary>
        /// <param name="request">The RetailTransactionDto that contains the zip code and retail transaction items being purchase.</param>
        /// <returns>A CalculatedTaxResponseDto, which includes the total taxes required, as well as a breakdown of how the taxes were tallied.</returns>
        [HttpPost("CalculateTaxes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CalculatedTaxResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CalculateTaxes([FromBody]RetailTransactionDto request)
        {
            CalculatedTaxResponseDto response = await _TaxCalculationService.CalculateTaxesAsync(request);

            if (response == null)
                return NotFound("No tax rates were found for the provided zip code.");

            return Ok(response);
        }
    }
}
