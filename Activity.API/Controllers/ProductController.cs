using Activity.BLL;
using Activity.DAL.ORM;
using Activity.Dto;
using Activity.Dto.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Activity.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private IUnitOfWork unitOfWork;

    public ProductController(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    [HttpPost]
    public IActionResult AddProduct(CreateProductRequestDto model)
    {
        Product product = new Product();
        product.Name = model.Name;
        product.Description = model.Description;
        product.Stock = model.Stock;
        product.ActivityId = model.ActivityId;
        product.UnitPrice = model.UnitPrice;
        unitOfWork.ProductRepository.Add(product);
        unitOfWork.Save();
        return Ok(product);
    }
    [HttpPut("{id}")]
    public IActionResult UpdateProduct(Guid id, UpdateProductRequestDto model)
    {
        var product = unitOfWork.ProductRepository.GetById(id);
        if (product == null)
        {
            return NotFound();
        }
        else
        {

            product.Name = model.Name;
            product.Description = model.Description;
            product.Stock = model.Stock;
            unitOfWork.Save();
            return Ok(product);
        }

    }

    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(Guid id)
    {
        var product = unitOfWork.ProductRepository.GetById(id);
        unitOfWork.ProductRepository.Remove(id);
        unitOfWork.Save();
        return Ok();
    }

    [HttpGet]
    public IActionResult GetAllProducts()
    {
        var response = new List<GetAllProductResponseDto>();
        var products = unitOfWork.ProductRepository.GetAll();
        foreach (var product in products)
        {
            GetAllProductResponseDto productsDto = new GetAllProductResponseDto();
            productsDto.Name = product.Name;
            productsDto.Description = product.Description;
            productsDto.Stock = product.Stock;
            productsDto.ActivityId = product.ActivityId;
            response.Add(productsDto);

        }
        return Ok(response);
    }
    [HttpGet("{id}")]
    public IActionResult GetProduct(Guid id)
    {
        var result = unitOfWork.CategoryRepository.GetById(id);
        return Ok(result);
    }
}
