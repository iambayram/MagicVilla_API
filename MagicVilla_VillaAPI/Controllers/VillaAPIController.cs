﻿using MagicVilla_VillaAPI.Data;

using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public VillaAPIController(ApplicationDbContext db)
        {

            _db = db;

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDto>> GetVillas()
        {
            
            return Ok(_db.Villas.ToList());
        }

        [HttpGet("{id:int}",Name ="GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDto> GetVilla(int id)
        {
            if(id == 0)
            {
                
                return BadRequest();
            }
            var villa = _db.Villas.FirstOrDefault(u => u.Id == id);
            if(villa == null)
            {
                return NotFound();
            }
            return Ok(villa);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<VillaDto> CreateVilla([FromBody]VillaDto villaDto)
        {
            if (_db.Villas.FirstOrDefault(u => u.Name.ToLower() == villaDto.Name.ToLower()) != null)
            {
                ModelState.AddModelError("CustomError", "Villa already exists!");
                return BadRequest(ModelState);
            }

            if (villaDto == null)
            {
                return BadRequest(villaDto);
            }
            if(villaDto.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            Villa model = new()
            {
                Amenity=villaDto.Amenity,
                Details=villaDto.Details,
                Id=villaDto.Id,
                ImageUrl=villaDto.ImageUrl,
                Name=villaDto.Name,
                Occupancy=villaDto.Occupancy,
                Rate=villaDto.Rate,
                Sqrmt=villaDto.Sqrmt
            };
            _db.Villas.Add(model);
            _db.SaveChanges();
            
            return CreatedAtRoute("GetVilla", new { id=villaDto.Id},villaDto);

        }

        [HttpDelete("{id:int}",Name ="DeleteVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa=_db.Villas.FirstOrDefault(u=>u.Id==id);
            if(villa == null)
            {
                return NotFound();
            }
            _db.Villas.Remove(villa);
            _db.SaveChanges();
            return NoContent();
        }

        [HttpPost("{id:int}",Name ="UpdateVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType (StatusCodes.Status400BadRequest)]
        public IActionResult UpdateVilla(int id, [FromBody] VillaDto villaDto)
        {
            if(villaDto == null || villaDto.Id !=id)
            {
                return BadRequest();
            }
            //var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);
            //villa.Name= villaDto.Name;
            //villa.Occupancy = villaDto.Occupancy;
            //villa.sqrmt = villaDto.sqrmt;

            Villa model = new()
            {
                Amenity = villaDto.Amenity,
                Details = villaDto.Details,
                Id = villaDto.Id,
                ImageUrl = villaDto.ImageUrl,
                Name = villaDto.Name,
                Occupancy = villaDto.Occupancy,
                Rate = villaDto.Rate,
                //Sqrmt = villaDto.sqrmt
            };
            _db.Villas.Update(model);
            _db.SaveChanges();
            return NoContent();
        }

        [HttpPatch("{id:int}",Name = "UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdatePartialVilla(int id,JsonPatchDocument<VillaDto> patchDto)
        {
            if(patchDto==null || id==0)
            {
                return BadRequest();
            }
            var villa=_db.Villas.AsNoTracking().FirstOrDefault(u=>u.Id==id);

            VillaDto villaDto = new()
            {
                Amenity = villa.Amenity,
                Details = villa.Details,
                Id = villa.Id,
                ImageUrl = villa.ImageUrl,
                Name = villa.Name,
                Occupancy = villa.Occupancy,
                Rate = villa.Rate,
                Sqrmt = villa.Sqrmt
            };

            if (villa == null)
            {
                return BadRequest();
            }
            patchDto.ApplyTo(villaDto, ModelState);
            Villa model = new ()
            {
                Amenity = villaDto.Amenity,
                Details = villaDto.Details,
                Id = villaDto.Id,
                ImageUrl = villaDto.ImageUrl,
                Name = villaDto.Name,
                Occupancy = villaDto.Occupancy,
                Rate = villaDto.Rate,
                Sqrmt = villaDto.Sqrmt
            };
            _db.Villas.Update(model);
            _db.SaveChanges();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return NoContent();
        }

    }
}
