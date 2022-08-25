using Mango.Services.ProductAPI.Model;
using Mango.Services.ProductAPI.Model.Dto;
using Mango.Services.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;


            
namespace Mango.Services.ProductAPI.Controllers
{
    [Route("api/product")]
    public class ProductAPIController : ControllerBase
    {
        protected ResponseDto _Respose;
        protected IProductRepository _IProductRepository;

        public ProductAPIController(IProductRepository ireposetory)
        {
            this._Respose = new ResponseDto();
            _IProductRepository = ireposetory;
        }

        [HttpGet]
        public async Task<Object> Get()
        {
            try
            {
                var ProductResult = await _IProductRepository.GetProducts();
                _Respose.Result = ProductResult;
            }
            catch (Exception ex)
            {

                _Respose.IsSuccess = false;
                _Respose.ErrorMessage = new List<string>()
                {
                    ex.ToString()
                };
            }

            return _Respose;
        }

        [HttpGet]
        [Route("{Id}")]

        public async Task<Object> Get(int Id)
        {
            try
            {
                var ProductResult = await _IProductRepository.GetProductById(Id);
                _Respose.Result = ProductResult;
            }
            catch (Exception ex)
            {

                _Respose.IsSuccess = false;
                _Respose.ErrorMessage = new List<string>()
                {
                    ex.ToString()
                };
            }

            return _Respose;
        }
        
        [HttpPost]
        public async Task<Object> Post([FromBody] ProductDto productDto)
        {
            try
            {
                var ProductResult = await _IProductRepository.CreateUpdateProduct(productDto);
                _Respose.Result = ProductResult;
            }
            catch (Exception ex)
            {

                _Respose.IsSuccess = false;
                _Respose.ErrorMessage = new List<string>()
                {
                    ex.ToString()
                };
            }

            return _Respose;
        }

        [HttpPut]
        public async Task<Object> Put([FromBody] ProductDto productDto)
        {
            try
            {
                var ProductResult = await _IProductRepository.CreateUpdateProduct(productDto);
                _Respose.Result = ProductResult;
            }
            catch (Exception ex)
            {

                _Respose.IsSuccess = false;
                _Respose.ErrorMessage = new List<string>()
                {
                    ex.ToString()
                };
            }

            return _Respose;
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<Object> Delete(int Id)
        {
            try
            {
                var ProductResult = await _IProductRepository.DeleteProduct(Id);
                _Respose.Result = ProductResult;
            }
            catch (Exception ex)
            {

                _Respose.IsSuccess = false;
                _Respose.ErrorMessage = new List<string>()
                {
                    ex.ToString()
                };
            }

            return _Respose;
        }

    }
}
