using System.Collections.Generic;
using System.Threading.Tasks;
using Avalara.StateSalesTax.Data.Dtos;
using Avalara.StateSalesTax.Service.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Avalara.StateSalesTax.API.WebApi.Controllers
{
    /// <summary>
    /// I thought it'd be helpful to show some of the R of CRUD operations with APIs here.
    ///
    /// I'll create a separate API for performing the actual tax calculation for a given retail transaction.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class TaxRatesController : ControllerBase
    {
        private readonly ITaxRateDataService _TaxRateDataService;

        public TaxRatesController(ITaxRateDataService taxRateDataService)
        {
            _TaxRateDataService = taxRateDataService;
        }

        /// <summary>
        /// Gets an individual tax rate by ID.
        /// </summary>
        /// <param name="id">The database ID of the tax rate being queried for.</param>
        /// <returns>A TaxRateDto object.</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TaxRateDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _TaxRateDataService.GetTaxRateAsync(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        /// <summary>
        /// Gets a list of historical tax rates by a given zip code.
        /// </summary>
        /// <param name="zipCode">The provided zip code.</param>
        /// <returns>A list of historical tax rates as TaxRateDtos.</returns>
        [HttpGet("GetAllRatesByZipCode")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<TaxRateDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAllRatesByZipCode([FromQuery] string zipCode)
        {
            var result = await _TaxRateDataService.GetAllByZipCodeAsync(zipCode);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        /// <summary>
        /// Gets a list of historical tax rates by a given zip code.
        /// </summary>
        /// <param name="zipCode">The provided zip code.</param>
        /// <returns>A list of historical tax rates as TaxRateDtos.</returns>
        [HttpGet("GetAllActiveRatesByZipCode")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<TaxRateDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAllActiveRatesByZipCode([FromQuery] string zipCode)
        {
            var result = await _TaxRateDataService.GetAllActiveByZipCodeAsync(zipCode);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        /// <summary>
        /// Gets a list of historical tax rates for a given state. This is only for state-level tax rates (not county or city).
        /// </summary>
        /// <param name="stateName">The name of the state being queried for.</param>
        /// <returns>Returns a list of historical tax rates as TaxRateDtos.</returns>
        [HttpGet("GetStateRates")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<TaxRateDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetStateRates([FromQuery] string stateName = "North Carolina")
        {
            var result = await _TaxRateDataService.GetStateTaxRateByNameAsync(stateName);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        /// <summary>
        /// Gets the currently active, individual state-level tax rate for a given state. This is only for state-level tax rates (not county or city).
        /// </summary>
        /// <param name="stateName">The name of the state being queried for.</param>
        /// <returns>Returns an individual state-level tax rate as a TaxRateDto.</returns>
        [HttpGet("GetActiveStateRate")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<TaxRateDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetActiveStateRate([FromQuery] string stateName = "North Carolina")
        {
            var result = await _TaxRateDataService.GetActiveStateTaxRateByNameAsync(stateName);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        /// <summary>
        /// Get all TaxRates that are available in the database.
        /// </summary>
        /// <returns>A list of tax rates.</returns>
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<TaxRateDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAll()
        {
            List<TaxRateDto> result = await _TaxRateDataService.GetAllTaxRatesAsync();

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        /// <summary>
        /// Get all TaxRates that are currently active.
        /// </summary>
        /// <returns>Returns a list of currently active TaxRates.</returns>
        [HttpGet("GetAllActive")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<TaxRateDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAllActive()
        {
            List<TaxRateDto> result = await _TaxRateDataService.GetAllActiveTaxRatesAsync();

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
