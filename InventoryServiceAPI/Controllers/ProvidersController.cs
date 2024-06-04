using AutoMapper;
using InventoryServiceAPI.Data;
using InventoryServiceAPI.Models;
using InventoryServiceAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryServiceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProvidersController(InventoryDbContext context, IMapper mapper) : ControllerBase
    {
        // Database Context for Entity Framework functionality
        private readonly InventoryDbContext _context = context;
        // AutoMapper
        private IMapper _mapper = mapper;

        [HttpGet]
        public async Task<ActionResult<ProviderDto>> Get()
        {
            IEnumerable<Provider> providersList = await _context.Providers.ToListAsync();
            // Return Providers List if any
            if(providersList.Any()) 
                return Ok(_mapper.Map<IEnumerable<ProviderDto>>(providersList));
            // Return no content of empty providers
            return NoContent();
        }

        [HttpGet]
        [Route("{id:long}")]
        public async Task<ActionResult<ProviderDto>> Get(long id)
        {
            try
            {
                // Get provider of given id
                Provider provider = await _context.Providers.FirstAsync(p => p.Id == id);
                // Return mapped providerDto if any from provider found
                return Ok(_mapper.Map<ProviderDto>(provider));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ProviderDto>> Create([FromBody] ProviderDto providerDto)
        {
            try
            {
                // Map providerDto from body
                Provider provider = _mapper.Map<Provider>(providerDto);
                // Add given provider to table
                _context.Providers.Add(provider);
                // Save changes to Database using context
                await _context.SaveChangesAsync();
                // Return created provider
                var location = Url.Action(nameof(Create), new { id = provider.Id }) ?? $"/{provider.Id}";
                return Created(location, _mapper.Map<ProviderDto>(provider));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("{id:long}")]
        public async Task<ActionResult<ProviderDto>> Update(long id,  [FromBody] ProviderDto providerDto)
        { 
            // Check given id equals providerDto Id
            if (providerDto.Id != id)
                return BadRequest(id);

            try
            {
                // Map providerDto from body
                Provider provider = _mapper.Map<Provider>(providerDto);
                // Update given provider to table
                _context.Providers.Update(provider);
                // Save changes to Database using context
                await _context.SaveChangesAsync();
                // Return created provider
                var location = Url.Action(nameof(Create), new { id = provider.Id }) ?? $"/{provider.Id}";
                return Created(location, _mapper.Map<ProviderDto>(provider));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id:long}")]
        public async Task<ActionResult<ProviderDto>> Delete(long id)
        {
            try
            {
                // Check if given id exists
                Provider provider = await _context.Providers.FirstAsync(p => p.Id == id);
                // Remove given provider from table
                _context.Providers.Remove(provider);
                // Update changes to Database using context
                await _context.SaveChangesAsync();
                // Return no content
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
