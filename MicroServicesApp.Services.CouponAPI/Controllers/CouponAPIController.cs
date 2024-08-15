using AutoMapper;
using MicroServicesApp.Services.CouponAPI.Data;
using MicroServicesApp.Services.CouponAPI.Models;
using MicroServicesApp.Services.CouponAPI.Models.Dto;
using MicroServicesApp.Services.CouponAPI.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace MicroServicesApp.Services.CouponAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/coupon")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;
        public CouponAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _db.Coupones.ToList();
                //_responseDto.Result = objList; -1
                 _response.Result = _mapper.Map<IEnumerable<CouponDto>>(objList);
                //return _responseDto; -1
            }
            catch (Exception ex) { 
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;

        }

        [HttpGet]
        [Route("{id:int}")]    
        public ResponseDto Get(int id)
        {
            try
            {
                Coupon obj = _db.Coupones.First(u => u.CouponId == id);
                //_responseDto.Result = obj;
                _response.Result = _mapper.Map<CouponDto>(obj);
            }
            catch (Exception ex) { 
                _response.IsSuccess =false;
                _response.Message = ex.Message;
            }
            return _response;

        }

        [HttpGet]
        [Route("GetyCode/{code}")]
        public ResponseDto Get(string code)
        {
            try
            {
                Coupon obj = _db.Coupones.FirstOrDefault(u => u.CouponCode.ToLower() == code.ToLower());
                //_responseDto.Result = obj;
                _response.Result = _mapper.Map<CouponDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;

        }

        [HttpPost]
        public ResponseDto Post([FromBody] CouponDto cuponDto)
        {
            try{

                Coupon obj = _mapper.Map<Coupon>(cuponDto);
                _db.Coupones.Add(obj);
                _db.SaveChanges();
                _response.Result = _mapper.Map<CouponDto>(obj);

            }catch(Exception ex)
            {
                _response.IsSuccess = false ;
                _response.Message = ex.Message;
            }

            return _response;
        }


        [HttpPut]
        public ResponseDto Put([FromBody] CouponDto cuponDto)
        {
            try
            {

                Coupon obj = _mapper.Map<Coupon>(cuponDto);
                _db.Coupones.Update(obj);
                _db.SaveChanges();
                _response.Result = _mapper.Map<CouponDto>(obj);

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }


        [HttpDelete]
        public ResponseDto Delete(int id)
        {
            try
            {

                Coupon obj = _db.Coupones.First(u => u.CouponId == id);
                _db.Coupones.Remove(obj);
                _db.SaveChanges();
                
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }



    }
}
