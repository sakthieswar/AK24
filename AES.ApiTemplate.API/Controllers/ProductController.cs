//using AES.ApiTemplate.CoreServices.Repository;
using AES.ApiTemplate.Models.Models;
using AES.ApiTemplate.Services.Interfaces;
using AES.ApiTemplate.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace AES.ApiTemplate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILoggerManager _logger;
        //private IUnitOfWorkFactory _unitOfWorkFactory;    


        public ProductController(IUnitOfWork unitOfWork, ILoggerManager logger)
        {
            //this.dapper = dapper;
            this._unitOfWork = unitOfWork;
            this._logger = logger;
        }

        [HttpGet]
        [Route("GetProducts")]
        public async Task<IReadOnlyList<Product>> GetProducts()
        {
            _logger.LogInfo("Here is info message from the controller.");
            _logger.LogDebug("Here is debug message from the controller.");
            _logger.LogWarn("Here is warn message from the controller.");
            _logger.LogError("Here is error message from the controller.");

            IReadOnlyList<Product> ss = await _unitOfWork.Repository<Product>().GetAll();
            return ss;
        }
        [HttpGet]
        [Route("GetProduct")]
        public async Task<Product> GetProduct(int id)
        {
            Product ss = await _unitOfWork.Repository<Product>().GetById(id);
            return ss;
        }
        [HttpPost]
        [Route("AddProduuct")]
        public async Task AddProduuct(Product  product)
        {
            Product prd = new Product() { name = "UOW Product", description= "UOW Product" };
            var res = await _unitOfWork.Repository<Product>().Add(product);
        }

        //public ProductController(IUnitOfWorkFactory unitOfWorkFactory)
        //{
        //    //this.dapper = dapper;
        //    this._unitOfWorkFactory = unitOfWorkFactory;
        //}

        //[HttpGet]
        //[Route("GetProducts")]
        //public async Task<IEnumerable<Product>> GetProducts()
        //{
        //    using var uow = _unitOfWorkFactory.CreateUnitOfWork();
        //    var insertTask1 = uow.Repository<Product>().InsertAsync(new Product() { Name = "PenDrive", CategoryID = 1, Description = "" });
        //    ////var insertTask2 = uow.Repository<Product>().InsertAsync(new Product() { Name = "HardDisk", CreatedDate = DateTime.Now });
        //    ////var insertTask3 = uow.Repository<Product>().InsertAsync(new Product() { Name = "Mouse", CreatedDate = DateTime.Now });
        //    //// await Task.WhenAll(insertTask1, insertTask2, insertTask3);
        //    //await Task.WhenAll(insertTask1);
        //    uow.Commit();

        //    //using var uow2 = _unitOfWorkFactory.CreateUnitOfWork();
        //    return await uow.Repository<Product>().GetAllAsync();


        //    //IReadOnlyList<Product> ss = await _unitOfWorkFactory.
        //    //return ss;
        //}

    }
}
