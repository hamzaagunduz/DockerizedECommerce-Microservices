using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.FeatureDtos;
using MultiShop.Catalog.Services.FeatureServices;

namespace MultiShop.Catalog.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : Controller
    {
        private readonly IFeatureService _FeatureService;

        public FeaturesController(IFeatureService FeatureService)
        {
            _FeatureService = FeatureService;
        }
        [HttpGet]
        public async Task<IActionResult> FeatureList()
        {
            var values = await _FeatureService.GettAllFeatureAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeatureById(string id)
        {
            var values = await _FeatureService.GetByIdFeatureAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureDto createFeatureDto)
        {
            await _FeatureService.CreateFeatureAsync(createFeatureDto);
            return Ok("Özellik başarıyla eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFeature(string id)
        {
            await _FeatureService.DeleteFeatureAsync(id);
            return Ok("Özellik başarıyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            await _FeatureService.UpdateFeatureAsync(updateFeatureDto);
            return Ok("Özellik başarıyla güncellendi");
        }
    }
}
