using Pizzaria.Desktop.Helpers;
using Pizzaria.Desktop.DTOs;


namespace Pizzaria.Desktop.Services
{
    public class CategoriasApiService
    {
        private readonly HttpClientHelper _http;

        public CategoriasApiService()
        {
            _http = HttpClientHelper.Instance;
        }

    
        public async Task<List<CategoriaResponseDto>> GetAllAsync()
        {
            try
            {
                var categorias = await _http.GetAsync<List<CategoriaResponseDto>>("/api/categories");
                return categorias ?? new List<CategoriaResponseDto>();
            }
            catch
            {
                return new List<CategoriaResponseDto>();
            }
        }

  
        public async Task<(bool Success, CategoriaResponseDto? Categoria, string ErrorMessage)>
            CreateAsync(CreateCategoriaDto dto)
        {
            return await _http.PostAsync<CategoriaResponseDto>("/api/categories", dto);
        }

     
        public async Task<(bool Success, CategoriaResponseDto? Categoria, string ErrorMessage)>
           UpdateAsync(int id, UpdateCategoriaDto dto)
        {
            return await _http.PutAsync<CategoriaResponseDto>($"/api/categories/{id}", dto);
        }


        public async Task<(bool Success, string ErrorMessage)>
           DeleteAsync(int id)
        {
            return await _http.DeleteAsync($"/api/categories/{id}");
        }




    }
}
