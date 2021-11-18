using Amazon.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanphamsController : ControllerBase
    {
        private readonly ISanphamRepository sanphamRepository;

        public SanphamsController(ISanphamRepository sanphamRepository)
        {
            this.sanphamRepository = sanphamRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetSanphams()
        {
            try
            {
                return Ok(await sanphamRepository.GetSanphams());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Sanpham>> GetSanpham(int id)
        {
            try
            {
                var result = await sanphamRepository.GetSanpham(id);

                if (result == null) return NotFound();

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Sanpham>> CreateSanpham(Sanpham sanpham)
        {
            try
            {
                if (sanpham == null)

                    return BadRequest();

                var createdSanpham = await sanphamRepository.AddSanpham(sanpham);

                return CreatedAtAction(nameof(GetSanpham),
                    new { id = createdSanpham.SanphamId }, createdSanpham);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Sanpham>> UpdateSanpham(int id, Sanpham sanpham)
        {
            try
            {
                if (id != sanpham.SanphamId)
                    return BadRequest("Employee ID mismatch");

                var sanphamToUpdate = await sanphamRepository.GetSanpham(id);

                if (sanphamToUpdate == null)
                    return NotFound($"Employee with Id = {id} not found");

                return await sanphamRepository.UpdateSanpham(sanpham);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Sanpham>> DeleteSanpham(int id)
        {
            try
            {
                var sanphamToDelete = await sanphamRepository.GetSanpham(id);

                if (sanphamToDelete == null)
                {
                    return NotFound($"Employee with Id = {id} not found");
                }

                return await sanphamRepository.DeleteSanpham(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<Sanpham>>> Search(string name, Color? color)
        {
            try
            {
                var result = await sanphamRepository.Search(name, color);

                if (result.Any())
                {
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}
