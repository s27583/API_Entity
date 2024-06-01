using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Entity.Contexts;
using API_Entity.DTOs;
using API_Entity.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;
namespace API_Entity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public ProductsController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<Product>> CreateProduct(int id, ProductDTO productDto)
        {
            var product = new Product
            {
                ProductName = productDto.ProductName,
                ProductWeight = (decimal)productDto.ProductWeight,
                ProductWidth = (decimal)productDto.ProductWidth,
                ProductHeight = (decimal)productDto.ProductHeight,
                ProductDepth = (decimal)productDto.ProductDepth
            };

            foreach (var categoryId in productDto.ProductCategories)
            {
                var category = await _context.Categories.FindAsync(categoryId);
                if (category != null)
                {
                    product.ProductCategories.Append(new ProductCategory
                    {
                        Category = category,
                        Product = product
                    });
                }
            }

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, product);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

    }


}