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
    public class ProductsController(InventoryDbContext context, IMapper mapper) : ControllerBase
    {
        // Database Context for Entity Framework functionality
        private readonly InventoryDbContext _context = context;
        // AutoMapper
        private IMapper _mapper = mapper;

        [HttpGet]
        [Route("All")]
        public async Task<ActionResult<ProductDto>> Get()
        {
            IEnumerable<Product> productsList = await _context.Products.ToListAsync();
            if (productsList.Any())
                return Ok(_mapper.Map<IEnumerable<ProductDto>>(productsList));

            return NoContent();
        }

        [HttpGet]
        [Route("{id:long}")]
        public async Task<ActionResult<ProductDto>> Get(long id)
        {
            try
            {
                Product? product = await _context.Products.FindAsync(id);
                if (product is null)
                    return NotFound();
                return Ok(_mapper.Map<ProductDto>(product));

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
