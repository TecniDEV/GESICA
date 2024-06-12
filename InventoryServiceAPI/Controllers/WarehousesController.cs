using AutoMapper;
using InventoryServiceAPI.Data;
using InventoryServiceAPI.Models.Dto;
using InventoryServiceAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryServiceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WarehousesController(InventoryDbContext context, IMapper mapper) : ControllerBase
    {
        // Database Context for Entity Framework functionality
        private readonly InventoryDbContext _context = context;
        // AutoMapper
        private IMapper _mapper = mapper;

        [HttpGet]
        public async Task<ActionResult<WarehouseDto>> Get()
        {
            IEnumerable<Warehouse> warehousesList = await _context.Warehouses.ToListAsync();
            // Return Warehouses List if any
            if (warehousesList.Any())
                return Ok(_mapper.Map<IEnumerable<ProviderDto>>(warehousesList));
            // Return no content of empty warehouses
            return NoContent();
        }

        [HttpGet]
        [Route("{id:long}")]
        public async Task<ActionResult<WarehouseDto>> Get(long id)
        {
            try
            {
                // Get warehouse of given id
                Warehouse warehouse = await _context.Warehouses.FirstAsync(wh => wh.Id == id); 
                // Return mapped warehouseDto if any from warehouse found
                return Ok(_mapper.Map<WarehouseDto>(warehouse));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<WarehouseDto>> Create([FromBody] WarehouseDto warehouseDto)
        {
            try
            {
                // Map warehouseDto from body
                Warehouse warehouse = _mapper.Map<Warehouse>(warehouseDto);
                // Add given warehouse to table
                _context.Warehouses.Add(warehouse);
                // Save changes to Database using context
                await _context.SaveChangesAsync();
                // Return created warehouse
                var location = Url.Action(nameof(Create), new { id = warehouse.Id }) ?? $"/{warehouse.Id}";
                return Created(location, _mapper.Map<WarehouseDto>(warehouse));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("{id:long}")]
        public async Task<ActionResult<WarehouseDto>> Update(long id, [FromBody] WarehouseDto warehouseDto)
        {
            // Check given id equals providerDto Id
            if (warehouseDto.Id != id)
                return BadRequest(id);

            try
            {
                // Map warehouseDto from body
                Warehouse warehouse = _mapper.Map<Warehouse>(warehouseDto);
                // Update given warehouse to table
                _context.Warehouses.Update(warehouse);
                // Save changes to Database using context
                await _context.SaveChangesAsync();
                // Return created warehouse
                var location = Url.Action(nameof(Create), new { id = warehouse.Id }) ?? $"/{warehouse.Id}";
                return Created(location, _mapper.Map<WarehouseDto>(warehouse));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id:long}")]
        public async Task<ActionResult<WarehouseDto>> Delete(long id)
        {
            try
            {
                // Check if given id exists
                Warehouse warehouse = await _context.Warehouses.FirstAsync(wh => wh.Id == id);
                // Remove given warehouse from table
                _context.Warehouses.Remove(warehouse);
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
